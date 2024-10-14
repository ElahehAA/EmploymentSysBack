using DataLayer.Models;
using DTOLayer;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using RepositoryLayer.IRepository;
using RepositoryLayer.Repository;
using ServiceLayer.CustomServices;
using ServiceLayer.ICustomServices;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
//var ConnectionString = builder.Configuration.GetConnectionString("DefaultConnection");
builder.Services.AddDbContext<EmploymentSysContext>(options => options.UseSqlServer("Data Source=.;Initial Catalog=EmploymentSys;Integrated Security=True;Trust Server Certificate=True"));

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

#region Service Injected
builder.Services.AddScoped(typeof(IRepository<>), typeof(Repository<>));
builder.Services.AddScoped<ICustomServices<UserDTO>, UserService>();
builder.Services.AddScoped<ICustomServices<LocationDTO>, LocationService>();
builder.Services.AddScoped<ICustomServices<RoleDTO>, RoleService>();
builder.Services.AddScoped<ICustomServices<AdvertismentCatDTO>, AdvertismentCatService>();
builder.Services.AddScoped<ICustomServices<AdvertismentDTO>, AdvertismentService>();
#endregion

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
