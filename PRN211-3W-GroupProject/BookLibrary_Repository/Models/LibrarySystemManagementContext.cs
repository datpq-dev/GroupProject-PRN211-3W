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
        public virtual DbSet<TblBookDetail> TblBookDetails { get; set; } = null!;
        public virtual DbSet<TblBorrow> TblBorrows { get; set; } = null!;
        public virtual DbSet<TblBorrowReturnDetail> TblBorrowReturnDetails { get; set; } = null!;
        public virtual DbSet<TblCategory> TblCategories { get; set; } = null!;
        public virtual DbSet<TblLibrarian> TblLibrarians { get; set; } = null!;
        public virtual DbSet<TblMember> TblMembers { get; set; } = null!;
        public virtual DbSet<TblReturn> TblReturns { get; set; } = null!;
        public virtual DbSet<TblRole> TblRoles { get; set; } = null!;
        public virtual DbSet<TblUser> TblUsers { get; set; } = null!;

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
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
                entity.HasKey(e => e.Isbn)
                    .HasName("PK_tblBookInfo");

                entity.ToTable("tblBook");

                entity.Property(e => e.Isbn)
                    .HasMaxLength(6)
                    .IsUnicode(false)
                    .HasColumnName("ISBN");

                entity.Property(e => e.Author).HasMaxLength(255);

                entity.Property(e => e.BookIdprefix)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasColumnName("BookIDPrefix");

                entity.Property(e => e.Description).HasMaxLength(255);

                entity.Property(e => e.Title).HasMaxLength(255);
            });

            modelBuilder.Entity<TblBookDetail>(entity =>
            {
                entity.HasKey(e => e.BookId)
                    .HasName("PK__tblBook__C220CF9C6067927C");

                entity.ToTable("tblBookDetail");

                entity.Property(e => e.BookId)
                    .HasMaxLength(7)
                    .IsUnicode(false)
                    .HasColumnName("BookID");

                entity.Property(e => e.Isbn)
                    .HasMaxLength(6)
                    .IsUnicode(false)
                    .HasColumnName("ISBN");

                entity.HasOne(d => d.IsbnNavigation)
                    .WithMany(p => p.TblBookDetails)
                    .HasForeignKey(d => d.Isbn)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_tblBook_tblBookInfo");
            });

            modelBuilder.Entity<TblBorrow>(entity =>
            {
                entity.HasKey(e => e.BorrowId);

                entity.ToTable("tblBorrow");

                entity.Property(e => e.BorrowId).HasColumnName("BorrowID");

                entity.Property(e => e.BorrowDay).HasColumnType("datetime");

                entity.Property(e => e.LibrarianId)
                    .HasMaxLength(8)
                    .IsUnicode(false)
                    .HasColumnName("LibrarianID");

                entity.Property(e => e.MemberId)
                    .HasMaxLength(8)
                    .IsUnicode(false)
                    .HasColumnName("MemberID");

                entity.HasOne(d => d.Librarian)
                    .WithMany(p => p.TblBorrows)
                    .HasForeignKey(d => d.LibrarianId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_tblBorrow_tblLibrarian1");

                entity.HasOne(d => d.Member)
                    .WithMany(p => p.TblBorrows)
                    .HasForeignKey(d => d.MemberId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_tblBorrow_tblMember1");
            });

            modelBuilder.Entity<TblBorrowReturnDetail>(entity =>
            {
                entity.HasKey(e => new { e.BorrowId, e.BookId })
                    .HasName("PK__tblBooki__35AAE1F800ED2242");

                entity.ToTable("tblBorrowReturnDetail");

                entity.Property(e => e.BorrowId).HasColumnName("BorrowID");

                entity.Property(e => e.BookId)
                    .HasMaxLength(7)
                    .IsUnicode(false)
                    .HasColumnName("BookID");

                entity.Property(e => e.ExpiredDay).HasColumnType("datetime");

                entity.Property(e => e.FineAmount).HasMaxLength(255);

                entity.Property(e => e.FineReason).HasMaxLength(255);

                entity.Property(e => e.ReturnId).HasColumnName("ReturnID");

                entity.HasOne(d => d.Book)
                    .WithMany(p => p.TblBorrowReturnDetails)
                    .HasForeignKey(d => d.BookId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_tblBorrow_tblBookDetail");

                entity.HasOne(d => d.Borrow)
                    .WithMany(p => p.TblBorrowReturnDetails)
                    .HasForeignKey(d => d.BorrowId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_tblBorrowDetail_tblBorrow");

                entity.HasOne(d => d.Return)
                    .WithMany(p => p.TblBorrowReturnDetails)
                    .HasForeignKey(d => d.ReturnId)
                    .HasConstraintName("FK_tblBorrowReturnDetail_tblReturn");
            });

            modelBuilder.Entity<TblCategory>(entity =>
            {
                entity.HasKey(e => e.CategoryId)
                    .HasName("PK__tblCateg__6DB28136FE86000C");

                entity.ToTable("tblCategory");

                entity.Property(e => e.CategoryId).HasColumnName("CategoryID");

                entity.Property(e => e.CategoryName).HasMaxLength(255);

                entity.HasMany(d => d.Isbns)
                    .WithMany(p => p.Categories)
                    .UsingEntity<Dictionary<string, object>>(
                        "TblBookCategory",
                        l => l.HasOne<TblBook>().WithMany().HasForeignKey("Isbn").OnDelete(DeleteBehavior.ClientSetNull).HasConstraintName("FK_tblBookCategory_tblBook"),
                        r => r.HasOne<TblCategory>().WithMany().HasForeignKey("CategoryId").OnDelete(DeleteBehavior.ClientSetNull).HasConstraintName("FK_tblBookCategory_tblCategory"),
                        j =>
                        {
                            j.HasKey("CategoryId", "Isbn");

                            j.ToTable("tblBookCategory");

                            j.IndexerProperty<int>("CategoryId").HasColumnName("CategoryID");

                            j.IndexerProperty<string>("Isbn").HasMaxLength(6).IsUnicode(false).HasColumnName("ISBN");
                        });
            });

            modelBuilder.Entity<TblLibrarian>(entity =>
            {
                entity.HasKey(e => e.LibrarianId);

                entity.ToTable("tblLibrarian");

                entity.HasIndex(e => e.Username, "UQ_LibrarianUsername")
                    .IsUnique();

                entity.Property(e => e.LibrarianId)
                    .HasMaxLength(8)
                    .IsUnicode(false)
                    .HasColumnName("LibrarianID");

                entity.Property(e => e.Username)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.HasOne(d => d.UsernameNavigation)
                    .WithOne(p => p.TblLibrarian)
                    .HasForeignKey<TblLibrarian>(d => d.Username)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_tblLibrarian_tblUser");
            });

            modelBuilder.Entity<TblMember>(entity =>
            {
                entity.HasKey(e => e.MemberId);

                entity.ToTable("tblMember");

                entity.HasIndex(e => e.Username, "UQ_MemberUsername")
                    .IsUnique();

                entity.Property(e => e.MemberId)
                    .HasMaxLength(8)
                    .IsUnicode(false)
                    .HasColumnName("MemberID");

                entity.Property(e => e.Username)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.HasOne(d => d.UsernameNavigation)
                    .WithOne(p => p.TblMember)
                    .HasForeignKey<TblMember>(d => d.Username)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_tblMember_tblUser");
            });

            modelBuilder.Entity<TblReturn>(entity =>
            {
                entity.HasKey(e => e.ReturnId)
                    .HasName("PK_tblReturn_1");

                entity.ToTable("tblReturn");

                entity.Property(e => e.ReturnId).HasColumnName("ReturnID");

                entity.Property(e => e.LibrarianId)
                    .HasMaxLength(8)
                    .IsUnicode(false)
                    .HasColumnName("LibrarianID");

                entity.Property(e => e.MemberId)
                    .HasMaxLength(8)
                    .IsUnicode(false)
                    .HasColumnName("MemberID");

                entity.Property(e => e.ReturnDay).HasColumnType("datetime");

                entity.HasOne(d => d.Librarian)
                    .WithMany(p => p.TblReturns)
                    .HasForeignKey(d => d.LibrarianId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_tblReturn_tblLibrarian1");

                entity.HasOne(d => d.Member)
                    .WithMany(p => p.TblReturns)
                    .HasForeignKey(d => d.MemberId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_tblReturn_tblMember");
            });

            modelBuilder.Entity<TblRole>(entity =>
            {
                entity.HasKey(e => e.RoleId)
                    .HasName("PK__tblRole__D80BB0931347DF2B");

                entity.ToTable("tblRole");

                entity.Property(e => e.RoleId)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("RoleID");

                entity.Property(e => e.RoleName)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TblUser>(entity =>
            {
                entity.HasKey(e => e.Username)
                    .HasName("PK__tblUser__206A9DF84FA32B01");

                entity.ToTable("tblUser");

                entity.HasIndex(e => e.Username, "Unique_UserName")
                    .IsUnique();

                entity.Property(e => e.Username)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.DoB).HasColumnType("datetime");

                entity.Property(e => e.FirstName).HasMaxLength(20);

                entity.Property(e => e.Gender).HasMaxLength(6);

                entity.Property(e => e.LastName).HasMaxLength(20);

                entity.Property(e => e.Password)
                    .HasMaxLength(12)
                    .IsUnicode(false);

                entity.Property(e => e.Phone)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.RoleId).HasColumnName("RoleID");

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
