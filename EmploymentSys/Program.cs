using DataLayer.Models;
using DTOLayer;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.IdentityModel.Tokens;
using RepositoryLayer.IRepository;
using RepositoryLayer.Repository;
using ServiceLayer.CustomServices;
using ServiceLayer.Extension;
using ServiceLayer.ICustomServices;
using System.Text;

internal class Program
{
    private static void Main(string[] args)
    {
        var builder = WebApplication.CreateBuilder(args);

        // Add services to the container.

        #region addCorsePolicy
        builder.Services.AddCors(options =>
        {
            options.AddPolicy("AllowSpecificOrigin",
                builder =>
                {
                    builder.WithOrigins("https://www.test.ir")
                           .AllowAnyMethod()
                           .AllowAnyHeader();
                });
        });

        #endregion
        //var ConnectionString = builder.Configuration.GetConnectionString("DefaultConnection");
        builder.Services.AddDbContext<EmploymentSysContext>(options => options.UseSqlServer("Data Source=.;Initial Catalog=EmploymentSys;Integrated Security=True;Trust Server Certificate=True"));

        builder.Services.AddControllers();
        // Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
        builder.Services.AddEndpointsApiExplorer();
        builder.Services.AddSwaggerGen();




        #region Service Injected
        builder.Services.AddHttpContextAccessor();
        builder.Services.AddSingleton<TokenService, TokenService>();
        builder.Services.AddSingleton<AuthService, AuthService>();
        builder.Services.AddScoped(typeof(IRepository<>), typeof(Repository<>));
        builder.Services.AddScoped<UserReository, UserReository>();
        builder.Services.AddScoped<AdvertismentRepository, AdvertismentRepository>();
        builder.Services.AddScoped<ICustomUserServices<UserDTO>, UserService>();
        builder.Services.AddScoped<ICustomServices<LocationDTO>, LocationService>();
        builder.Services.AddScoped<ICustomServices<RoleDTO>, RoleService>();
        builder.Services.AddScoped<ICustomServices<AdvertismentCatDTO>, AdvertismentCatService>();
        builder.Services.AddScoped<ICustomServices<AdvertismentDTO>, AdvertismentService>();
        #endregion

        #region AddTokenSetting
        builder.Services.AddAuthentication(JwtBearerDefaults.AuthenticationScheme).AddJwtBearer(options =>
        {
            options.RequireHttpsMetadata = false;
            options.SaveToken = true; 
            options.TokenValidationParameters = new TokenValidationParameters
            {
                ValidateIssuer = false,
                ValidateAudience = false,
                ValidateLifetime = true,
                ValidateIssuerSigningKey = true,
                ValidIssuer = builder.Configuration["Jwt:Issuer"],
                ValidAudience = builder.Configuration["Jwt:Audience"],
                IssuerSigningKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes("aaagggg55555cccccddddddddvsvsvsvsvvooooo"))
            };
        });

        builder.Services.AddAuthorization();
        #endregion

        var app = builder.Build();

        // Configure the HTTP request pipeline.
        if (app.Environment.IsDevelopment())
        {
            app.UseDeveloperExceptionPage();
            app.UseCors(builder =>
            {
                builder.AllowAnyOrigin()
                .AllowAnyMethod()
                .AllowAnyHeader();
            });
            app.UseSwagger();
            app.UseSwaggerUI();
        }

        app.UseHttpsRedirection();

        app.UseAuthentication();

        app.UseAuthorization();

        app.MapControllers();

        app.Run();
    }
}

