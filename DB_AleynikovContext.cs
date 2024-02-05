using System;
using System.Collections.Generic;
using krasotkaa.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace krasotkaa
{
    public partial class DB_AleynikovContext : DbContext
    {
        public DB_AleynikovContext()
        {
        }

        public DB_AleynikovContext(DbContextOptions<DB_AleynikovContext> options)
            : base(options)
        {
        }

        public virtual DbSet<CategoryOfProduct> CategoryOfProducts { get; set; } = null!;
        public virtual DbSet<Manufacture> Manufactures { get; set; } = null!;
        public virtual DbSet<Order> Orders { get; set; } = null!;
        public virtual DbSet<PickPoint> PickPoints { get; set; } = null!;
        public virtual DbSet<Product> Products { get; set; } = null!;
        public virtual DbSet<Provider> Providers { get; set; } = null!;
        public virtual DbSet<Role> Roles { get; set; } = null!;
        public virtual DbSet<StatusOfOrder> StatusOfOrders { get; set; } = null!;
        public virtual DbSet<StatusOfProduct> StatusOfProducts { get; set; } = null!;
        public virtual DbSet<User> Users { get; set; } = null!;

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("Server=LAPTOP-VJAV0JCF;Database=DB_Aleynikov;Trusted_Connection=True;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<CategoryOfProduct>(entity =>
            {
                entity.HasKey(e => e.CategoryId);

                entity.ToTable("CategoryOfProduct");

                entity.Property(e => e.CategoryName).HasMaxLength(100);
            });

            modelBuilder.Entity<Manufacture>(entity =>
            {
                entity.ToTable("Manufacture");

                entity.Property(e => e.ManufactureName).HasMaxLength(100);
            });

            modelBuilder.Entity<Order>(entity =>
            {
                entity.Property(e => e.OrderId).HasColumnName("OrderID");

                entity.Property(e => e.OrderClientFio)
                    .HasMaxLength(300)
                    .HasColumnName("OrderClientFIO");

                entity.Property(e => e.OrderCodeForGet).HasMaxLength(100);

                entity.Property(e => e.OrderComposition).HasMaxLength(100);

                entity.Property(e => e.OrderDate).HasColumnType("datetime");

                entity.Property(e => e.OrderDeliveryDate).HasColumnType("datetime");

                entity.HasOne(d => d.OrderCompositionNavigation)
                    .WithMany(p => p.Orders)
                    .HasForeignKey(d => d.OrderComposition)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Orders_Product");

                entity.HasOne(d => d.OrderPickPointNavigation)
                    .WithMany(p => p.Orders)
                    .HasForeignKey(d => d.OrderPickPoint)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Orders_PickPoints");

                entity.HasOne(d => d.OrderStatusNavigation)
                    .WithMany(p => p.Orders)
                    .HasForeignKey(d => d.OrderStatus)
                    .HasConstraintName("FK_Orders_StatusOfOrder");
            });

            modelBuilder.Entity<PickPoint>(entity =>
            {
                entity.Property(e => e.PickPointCity).HasMaxLength(100);

                entity.Property(e => e.PickPointHouse).HasMaxLength(100);

                entity.Property(e => e.PickPointStreet).HasMaxLength(100);
            });

            modelBuilder.Entity<Product>(entity =>
            {
                entity.HasKey(e => e.ProductArticleNumber)
                    .HasName("PK__Product__2EA7DCD57E6BEF9E");

                entity.ToTable("Product");

                entity.Property(e => e.ProductArticleNumber).HasMaxLength(100);

                entity.Property(e => e.ProductDescription).HasMaxLength(100);

                entity.Property(e => e.ProductMeasurement).HasMaxLength(100);

                entity.Property(e => e.ProductName).HasMaxLength(100);

                entity.Property(e => e.ProductPhoto).HasMaxLength(100);

                entity.HasOne(d => d.ProductCategoryNavigation)
                    .WithMany(p => p.Products)
                    .HasForeignKey(d => d.ProductCategory)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Product_CategoryOfProduct");

                entity.HasOne(d => d.ProductManufacturerNavigation)
                    .WithMany(p => p.Products)
                    .HasForeignKey(d => d.ProductManufacturer)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Product_Manufacture");

                entity.HasOne(d => d.ProductProviderNavigation)
                    .WithMany(p => p.Products)
                    .HasForeignKey(d => d.ProductProvider)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Product_Provider");

                entity.HasOne(d => d.ProductStatusNavigation)
                    .WithMany(p => p.Products)
                    .HasForeignKey(d => d.ProductStatus)
                    .HasConstraintName("FK_Product_StatusOfProduct");
            });

            modelBuilder.Entity<Provider>(entity =>
            {
                entity.ToTable("Provider");

                entity.Property(e => e.ProviderName).HasMaxLength(100);
            });

            modelBuilder.Entity<Role>(entity =>
            {
                entity.ToTable("Role");

                entity.Property(e => e.RoleId).HasColumnName("RoleID");

                entity.Property(e => e.RoleName)
                    .HasMaxLength(100)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<StatusOfOrder>(entity =>
            {
                entity.ToTable("StatusOfOrder");

                entity.Property(e => e.StatusOfOrderId).HasColumnName("StatusOfOrder_Id");

                entity.Property(e => e.StatusOfOrderName)
                    .HasMaxLength(50)
                    .HasColumnName("StatusOfOrder_Name");
            });

            modelBuilder.Entity<StatusOfProduct>(entity =>
            {
                entity.ToTable("StatusOfProduct");

                entity.Property(e => e.StatusOfProductName).HasMaxLength(50);
            });

            modelBuilder.Entity<User>(entity =>
            {
                entity.Property(e => e.UserId).HasColumnName("UserID");

                entity.Property(e => e.UserLogin).HasMaxLength(100);

                entity.Property(e => e.UserName).HasMaxLength(100);

                entity.Property(e => e.UserPassword).HasMaxLength(100);

                entity.Property(e => e.UserPatronymic).HasMaxLength(100);

                entity.Property(e => e.UserSurname).HasMaxLength(100);

                entity.HasOne(d => d.UserRoleNavigation)
                    .WithMany(p => p.Users)
                    .HasForeignKey(d => d.UserRole)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__Users__UserRole__398D8EEE");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
