using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace crudmvc.Models
{
    public partial class alanContext : DbContext
    {
        public alanContext()
        {
        }

        public alanContext(DbContextOptions<alanContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Roles> Roles { get; set; }
        public virtual DbSet<Users> Users { get; set; }
        public virtual DbSet<UsersRoles> UsersRoles { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseNpgsql("Host=localhost;Database=alan;Username=postgres;Password=1234;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("ProductVersion", "2.2.6-servicing-10079");

            modelBuilder.Entity<Roles>(entity =>
            {
                entity.HasKey(e => e.Idrole)
                    .HasName("roles_pkey");

                entity.ToTable("roles");

                entity.Property(e => e.Idrole)
                    .HasColumnName("idrole")
                    .HasDefaultValueSql("nextval('roles_idrol_seq'::regclass)");

                entity.Property(e => e.Rolename).HasColumnName("rolename");
            });

            modelBuilder.Entity<Users>(entity =>
            {
                entity.HasKey(e => e.Iduser)
                    .HasName("users_pkey");

                entity.ToTable("users");

                entity.Property(e => e.Iduser).HasColumnName("iduser");

                entity.Property(e => e.Nickname).HasColumnName("nickname");

                entity.Property(e => e.Password).HasColumnName("password");
            });

            modelBuilder.Entity<UsersRoles>(entity =>
            {
                entity.HasKey(e => new { e.IduserUr, e.IdroleUr })
                    .HasName("users_roles_pkey");

                entity.ToTable("users_roles");

                entity.Property(e => e.IduserUr).HasColumnName("iduser_ur");

                entity.Property(e => e.IdroleUr).HasColumnName("idrole_ur");
            });

            modelBuilder.HasSequence("roles_idrol_seq")
                .HasMin(1)
                .HasMax(2147483647);
        }
    }
}
