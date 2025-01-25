using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace DataLayer.Models
{
    public partial class EmploymentSysContext : DbContext
    {
        public EmploymentSysContext()
        {
        }

        public EmploymentSysContext(DbContextOptions<EmploymentSysContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Advertisment> Advertisments { get; set; } = null!;
        public virtual DbSet<AdvertismentCat> AdvertismentCats { get; set; } = null!;
        public virtual DbSet<Location> Locations { get; set; } = null!;
        public virtual DbSet<Role> Roles { get; set; } = null!;
        public virtual DbSet<User> Users { get; set; } = null!;

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("Data Source=.;Initial Catalog=EmploymentSys;Integrated Security=True;Trust Server Certificate=True");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Advertisment>(entity =>
            {
                entity.Property(e => e.Gender).HasComment("خانم 1//\r\nآقا 2//\r\nخانم/آقا 0");

                entity.Property(e => e.IsActive).HasDefaultValueSql("((1))");

                entity.Property(e => e.Rights).HasDefaultValueSql("(N'توافقی')");

                entity.HasOne(d => d.AdvertismentCat)
                    .WithMany(p => p.Advertisments)
                    .HasForeignKey(d => d.AdvertismentCatId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Advertisment_AdvertismentCat");

                entity.HasOne(d => d.City)
                    .WithMany(p => p.Advertisments)
                    .HasForeignKey(d => d.CityId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Advertisment_Location");

                entity.HasOne(d => d.Cuser)
                    .WithMany(p => p.Advertisments)
                    .HasForeignKey(d => d.CuserId)
                    .HasConstraintName("FK_Advertisment_User");
            });

            modelBuilder.Entity<AdvertismentCat>(entity =>
            {
                entity.Property(e => e.IsActive).HasDefaultValueSql("((1))");
            });

            modelBuilder.Entity<Location>(entity =>
            {
                entity.HasOne(d => d.PidNavigation)
                    .WithMany(p => p.InversePidNavigation)
                    .HasForeignKey(d => d.Pid)
                    .HasConstraintName("FK_Location_Location1");
            });

            modelBuilder.Entity<User>(entity =>
            {
                entity.Property(e => e.Email).IsFixedLength();

                entity.Property(e => e.IsActive).HasDefaultValueSql("((1))");

                entity.Property(e => e.PhoneNum).IsFixedLength();

                entity.HasOne(d => d.Role)
                    .WithMany(p => p.Users)
                    .HasForeignKey(d => d.RoleId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_User_Role");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
