using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

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
        public virtual DbSet<TblBookInfo> TblBookInfos { get; set; } = null!;
        public virtual DbSet<TblBorrow> TblBorrows { get; set; } = null!;
        public virtual DbSet<TblBorrowDetail> TblBorrowDetails { get; set; } = null!;
        public virtual DbSet<TblCategory> TblCategories { get; set; } = null!;
        public virtual DbSet<TblRole> TblRoles { get; set; } = null!;
        public virtual DbSet<TblUser> TblUsers { get; set; } = null!;

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("Server=(local);uid=sa;pwd=12345;database=LibrarySystemManagement;TrustServerCertificate=True");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<TblBook>(entity =>
            {
                entity.HasKey(e => e.BookId)
                    .HasName("PK__tblBook__C220CF9C6067927C");

                entity.ToTable("tblBook");

                entity.Property(e => e.BookId)
                    .HasMaxLength(7)
                    .IsUnicode(false)
                    .HasColumnName("BookID");

                entity.Property(e => e.Description).HasMaxLength(255);

                entity.Property(e => e.Isbn)
                    .HasMaxLength(6)
                    .IsUnicode(false)
                    .HasColumnName("ISBN");

                entity.HasOne(d => d.IsbnNavigation)
                    .WithMany(p => p.TblBooks)
                    .HasForeignKey(d => d.Isbn)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_tblBook_tblBookInfo");
            });

            modelBuilder.Entity<TblBookInfo>(entity =>
            {
                entity.HasKey(e => e.Isbn);

                entity.ToTable("tblBookInfo");

                entity.Property(e => e.Isbn)
                    .HasMaxLength(6)
                    .IsUnicode(false)
                    .HasColumnName("ISBN");

                entity.Property(e => e.Author).HasMaxLength(255);

                entity.Property(e => e.BookIdprefix)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasColumnName("BookIDPrefix");

                entity.Property(e => e.CategoryId).HasColumnName("CategoryID");

                entity.Property(e => e.Description).HasMaxLength(255);

                entity.Property(e => e.Title).HasMaxLength(255);

                entity.HasOne(d => d.Category)
                    .WithMany(p => p.TblBookInfos)
                    .HasForeignKey(d => d.CategoryId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_tblBookInfo_tblCategory");
            });

            modelBuilder.Entity<TblBorrow>(entity =>
            {
                entity.HasKey(e => e.BookingId)
                    .HasName("PK__tblBooki__35AAE1F800ED2242");

                entity.ToTable("tblBorrow");

                entity.Property(e => e.BookingId)
                    .ValueGeneratedNever()
                    .HasColumnName("BookingID");

                entity.Property(e => e.BookingDay).HasColumnType("datetime");

                entity.Property(e => e.UserId).HasColumnName("UserID");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.TblBorrows)
                    .HasForeignKey(d => d.UserId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_tblBooking_tblUser");
            });

            modelBuilder.Entity<TblBorrowDetail>(entity =>
            {
                entity.HasKey(e => new { e.BookingId, e.BookId });

                entity.ToTable("tblBorrowDetail");

                entity.Property(e => e.BookingId).HasColumnName("BookingID");

                entity.Property(e => e.BookId)
                    .HasMaxLength(7)
                    .IsUnicode(false)
                    .HasColumnName("BookID");

                entity.Property(e => e.ExpiredDay).HasColumnType("datetime");

                entity.Property(e => e.Note).HasMaxLength(255);

                entity.Property(e => e.ReturnDay).HasColumnType("datetime");

                entity.HasOne(d => d.Book)
                    .WithMany(p => p.TblBorrowDetails)
                    .HasForeignKey(d => d.BookId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_tblBorrowDetail_tblBook");

                entity.HasOne(d => d.Booking)
                    .WithMany(p => p.TblBorrowDetails)
                    .HasForeignKey(d => d.BookingId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_tblBorrowDetail_tblBorrow");
            });

            modelBuilder.Entity<TblCategory>(entity =>
            {
                entity.HasKey(e => e.CategoryId)
                    .HasName("PK__tblCateg__6DB28136FE86000C");

                entity.ToTable("tblCategory");

                entity.Property(e => e.CategoryId)
                    .ValueGeneratedNever()
                    .HasColumnName("CategoryID");

                entity.Property(e => e.CategoryName).HasMaxLength(50);
            });

            modelBuilder.Entity<TblRole>(entity =>
            {
                entity.HasKey(e => e.RoleId)
                    .HasName("PK__tblRole__D80BB0931347DF2B");

                entity.ToTable("tblRole");

                entity.Property(e => e.RoleId)
                    .ValueGeneratedNever()
                    .HasColumnName("RoleID");

                entity.Property(e => e.RoleName)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TblUser>(entity =>
            {
                entity.HasKey(e => e.UserId)
                    .HasName("PK__tblUser__206A9DF84FA32B01");

                entity.ToTable("tblUser");

                entity.Property(e => e.UserId)
                    .ValueGeneratedNever()
                    .HasColumnName("UserID");

                entity.Property(e => e.DoB).HasColumnType("datetime");

                entity.Property(e => e.FirstName).HasMaxLength(20);

                entity.Property(e => e.Gender).HasMaxLength(5);

                entity.Property(e => e.LastName).HasMaxLength(20);

                entity.Property(e => e.Password)
                    .HasMaxLength(12)
                    .IsUnicode(false);

                entity.Property(e => e.Phone)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.RoleId).HasColumnName("RoleID");

                entity.Property(e => e.Username)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.HasOne(d => d.Role)
                    .WithMany(p => p.TblUsers)
                    .HasForeignKey(d => d.RoleId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__tblUser__Role_id__4BAC3F29");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
