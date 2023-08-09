using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.Extensions.Configuration;

namespace BookLibrary_Repository.Models
{
    public partial class LibrarySystemManagementContext : DbContext
    {
        public LibrarySystemManagementContext()
        {
        }

        public LibrarySystemManagementContext(DbContextOptions<LibrarySystemManagementContext> options)
            : base(options)
        {
        }

        public virtual DbSet<TblBook> TblBooks { get; set; } = null!;
        public virtual DbSet<TblBooking> TblBookings { get; set; } = null!;
        public virtual DbSet<TblCategory> TblCategories { get; set; } = null!;
        public virtual DbSet<TblRole> TblRoles { get; set; } = null!;
        public virtual DbSet<TblUser> TblUsers { get; set; } = null!;

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer(GetConnectionString());
            }
        }
        private string GetConnectionString()
        {
            IConfiguration config = new ConfigurationBuilder()
                 .SetBasePath(Directory.GetCurrentDirectory())
                        .AddJsonFile("appsettings.json", true, true)
                        .Build();
            var strConn = config["ConnectionStrings:DefaultConnectionStringDB"];

            return strConn;
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<TblBook>(entity =>
            {
                entity.HasKey(e => e.BookId)
                    .HasName("PK__tblBook__C220CF9C88096F08");

                entity.ToTable("tblBook");

                entity.Property(e => e.BookId)
                    .ValueGeneratedNever()
                    .HasColumnName("Book_id");

                entity.Property(e => e.Author).HasMaxLength(100);

                entity.Property(e => e.BookName)
                    .HasMaxLength(255)
                    .HasColumnName("Book_name");

                entity.Property(e => e.CategoryId).HasColumnName("Category_id");

                entity.Property(e => e.Description).HasMaxLength(255);

                entity.Property(e => e.Status)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.HasOne(d => d.Category)
                    .WithMany(p => p.TblBooks)
                    .HasForeignKey(d => d.CategoryId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__tblBook__Categor__2B3F6F97");
            });

            modelBuilder.Entity<TblBooking>(entity =>
            {
                entity.HasKey(e => e.BookingId)
                    .HasName("PK__tblBooki__35AAE1F8A0802841");

                entity.ToTable("tblBooking");

                entity.Property(e => e.BookingId)
                    .ValueGeneratedNever()
                    .HasColumnName("Booking_id");

                entity.Property(e => e.BookId).HasColumnName("Book_id");

                entity.Property(e => e.BookingDay)
                    .HasColumnType("datetime")
                    .HasColumnName("Booking_day");

                entity.Property(e => e.ExpiredDay)
                    .HasColumnType("datetime")
                    .HasColumnName("Expired_day");

                entity.Property(e => e.UserId).HasColumnName("User_id");

                entity.HasOne(d => d.Book)
                    .WithMany(p => p.TblBookings)
                    .HasForeignKey(d => d.BookId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__tblBookin__Book___2E1BDC42");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.TblBookings)
                    .HasForeignKey(d => d.UserId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__tblBookin__User___2F10007B");
            });

            modelBuilder.Entity<TblCategory>(entity =>
            {
                entity.HasKey(e => e.CategoryId)
                    .HasName("PK__tblCateg__6DB28136A960BDC0");

                entity.ToTable("tblCategory");

                entity.Property(e => e.CategoryId)
                    .ValueGeneratedNever()
                    .HasColumnName("Category_id");

                entity.Property(e => e.CategoryName)
                    .HasMaxLength(255)
                    .HasColumnName("Category_name");
            });

            modelBuilder.Entity<TblRole>(entity =>
            {
                entity.HasKey(e => e.RoleId)
                    .HasName("PK__tblRole__D80BB093BB21D7E3");

                entity.ToTable("tblRole");

                entity.Property(e => e.RoleId)
                    .ValueGeneratedNever()
                    .HasColumnName("Role_id");

                entity.Property(e => e.RoleName)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("Role_name");
            });

            modelBuilder.Entity<TblUser>(entity =>
            {
                entity.HasKey(e => e.UserId)
                    .HasName("PK__tblUser__206A9DF84C01E7D3");

                entity.ToTable("tblUser");

                entity.Property(e => e.UserId)
                    .ValueGeneratedNever()
                    .HasColumnName("User_id");

                entity.Property(e => e.DoB).HasColumnType("datetime");

                entity.Property(e => e.FirstName).HasMaxLength(100);

                entity.Property(e => e.Gender).HasMaxLength(50);

                entity.Property(e => e.LastName).HasMaxLength(100);

                entity.Property(e => e.Password)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Phone)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.RoleId).HasColumnName("Role_id");

                entity.Property(e => e.Username)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.HasOne(d => d.Role)
                    .WithMany(p => p.TblUsers)
                    .HasForeignKey(d => d.RoleId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__tblUser__Role_id__267ABA7A");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
