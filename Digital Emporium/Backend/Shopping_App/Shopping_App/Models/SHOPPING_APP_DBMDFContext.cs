using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

#nullable disable

namespace Shopping_App.Models
{
    public partial class SHOPPING_APP_DBMDFContext : DbContext
    {
        public SHOPPING_APP_DBMDFContext()
        {
        }

        public SHOPPING_APP_DBMDFContext(DbContextOptions<SHOPPING_APP_DBMDFContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Address> AddressTable { get; set; }
        public virtual DbSet<CartItem> CartItemTable { get; set; }
        public virtual DbSet<Category> CategoryTable { get; set; }
        public virtual DbSet<Color> ColorTable { get; set; }
        public virtual DbSet<ColorItem> ColorItemTable { get; set; }
        public virtual DbSet<Customer> CustomerTable { get; set; }
        public virtual DbSet<FeaturedItem> FeaturedItemTable { get; set; }
        public virtual DbSet<Image> ImageTable { get; set; }
        public virtual DbSet<Item> ItemTable { get; set; }
        public virtual DbSet<Order> OrderTable { get; set; }
        public virtual DbSet<OrderItem> OrderItemTable { get; set; }
        public virtual DbSet<Payment> PaymentTable { get; set; }
        public virtual DbSet<PaymentType> PaymentTypeTable { get; set; }
        public virtual DbSet<Review> ReviewTable { get; set; }
        public virtual DbSet<SaleItem> SaleItemTable { get; set; }
        public virtual DbSet<Seller> SellerTable { get; set; }
        public virtual DbSet<UserItem> UserItemTable { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer(@"Data Source=(LocalDB)\MSSQLLocalDB;Initial Catalog=Shopping_App_DB.mdf;Integrated Security=True");

            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("Relational:Collation", "SQL_Latin1_General_CP1_CI_AS");

            modelBuilder.Entity<Address>(entity =>
            {
                entity.ToTable("Address");

                entity.Property(e => e.City).IsUnicode(false);

                entity.Property(e => e.Country).IsUnicode(false);

                entity.Property(e => e.PostalCode).IsUnicode(false);

                entity.Property(e => e.State).IsUnicode(false);

                entity.Property(e => e.StreetAddress).IsUnicode(false);
            });

            modelBuilder.Entity<CartItem>(entity =>
            {
                entity.ToTable("CartItem");

                entity.HasOne(d => d.Customer)
                    .WithMany(p => p.CartItems)
                    .HasForeignKey(d => d.CustomerId)
                    .HasConstraintName("FK_CartItem_Customer");
            });

            modelBuilder.Entity<Category>(entity =>
            {
                entity.ToTable("Category");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Color>(entity =>
            {
                entity.ToTable("Color");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .IsUnicode(false);
            });

            modelBuilder.Entity<ColorItem>(entity =>
            {
                entity.ToTable("ColorItem");

                entity.Property(e => e.Quantity).HasDefaultValueSql("((1))");

                entity.HasOne(d => d.Color)
                    .WithMany(p => p.ColorItems)
                    .HasForeignKey(d => d.ColorId)
                    .HasConstraintName("FK_Item_Color");

                entity.HasOne(d => d.Item)
                    .WithMany(p => p.ColorItems)
                    .HasForeignKey(d => d.ItemId)
                    .HasConstraintName("FK_Item_Item");
            });

            modelBuilder.Entity<Customer>(entity =>
            {
                entity.ToTable("Customer");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.Customers)
                    .HasForeignKey(d => d.UserId)
                    .HasConstraintName("FK_Customer_UserItem");
            });

            modelBuilder.Entity<FeaturedItem>(entity =>
            {
                entity.ToTable("FeaturedItem");

                entity.HasOne(d => d.Item)
                    .WithMany(p => p.FeaturedItems)
                    .HasForeignKey(d => d.ItemId)
                    .HasConstraintName("FK_FeaturedItem_Item");
            });

            modelBuilder.Entity<Image>(entity =>
            {
                entity.ToTable("Image");

                entity.Property(e => e.Path)
                    .IsRequired()
                    .IsUnicode(false);

                entity.HasOne(d => d.Item)
                    .WithMany(p => p.Images)
                    .HasForeignKey(d => d.ItemId)
                    .HasConstraintName("FK_Image_Item");
            });

            modelBuilder.Entity<Item>(entity =>
            {
                entity.ToTable("Item");

                entity.Property(e => e.AverageRating).HasDefaultValueSql("((0))");

                entity.Property(e => e.Description).IsUnicode(false);

                entity.Property(e => e.Manufacturer).IsUnicode(false);

                entity.Property(e => e.Model).IsUnicode(false);

                entity.Property(e => e.Name)
                    .IsRequired()
                    .IsUnicode(false);

                entity.HasOne(d => d.Category)
                    .WithMany(p => p.Items)
                    .HasForeignKey(d => d.CategoryId)
                    .HasConstraintName("FK_Item_Category");

                entity.HasOne(d => d.Seller)
                    .WithMany(p => p.Items)
                    .HasForeignKey(d => d.SellerId)
                    .HasConstraintName("FK_Item_Seller");
            });

            modelBuilder.Entity<Order>(entity =>
            {
                entity.ToTable("Order");

                entity.Property(e => e.DeliveryDateTime).HasColumnType("datetime");

                entity.Property(e => e.OrderDateTime).HasColumnType("datetime");

                entity.Property(e => e.Status)
                    .IsRequired()
                    .IsUnicode(false);

                entity.HasOne(d => d.Customer)
                    .WithMany(p => p.Orders)
                    .HasForeignKey(d => d.CustomerId)
                    .HasConstraintName("FK_Order_Customer");

                entity.HasOne(d => d.DeliveryAddress)
                    .WithMany(p => p.Orders)
                    .HasForeignKey(d => d.DeliveryAddressId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Order_Delivery");
            });

            modelBuilder.Entity<OrderItem>(entity =>
            {
                entity.ToTable("OrderItem");

                entity.HasOne(d => d.Seller)
                    .WithMany(p => p.OrderItems)
                    .HasForeignKey(d => d.SellerId)
                    .HasConstraintName("FK_OrderItem_Seller");
            });

            modelBuilder.Entity<Payment>(entity =>
            {
                entity.ToTable("Payment");

                entity.HasOne(d => d.PaymentType)
                    .WithMany(p => p.Payments)
                    .HasForeignKey(d => d.PaymentTypeId)
                    .HasConstraintName("FK_Payment_PaymentType");
            });

            modelBuilder.Entity<PaymentType>(entity =>
            {
                entity.ToTable("PaymentType");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Review>(entity =>
            {
                entity.ToTable("Review");

                entity.Property(e => e.DateTime).HasColumnType("datetime");

                entity.Property(e => e.Description).IsUnicode(false);

                entity.HasOne(d => d.Customer)
                    .WithMany(p => p.Reviews)
                    .HasForeignKey(d => d.CustomerId)
                    .HasConstraintName("FK_Review_Customer");

                entity.HasOne(d => d.Item)
                    .WithMany(p => p.Reviews)
                    .HasForeignKey(d => d.ItemId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Review_Item");
            });

            modelBuilder.Entity<SaleItem>(entity =>
            {
                entity.ToTable("SaleItem");

                entity.Property(e => e.DiscountPercent).HasDefaultValueSql("((0))");

                entity.HasOne(d => d.Item)
                    .WithMany(p => p.SaleItems)
                    .HasForeignKey(d => d.ItemId)
                    .HasConstraintName("FK_SaleItem_Item");
            });

            modelBuilder.Entity<Seller>(entity =>
            {
                entity.ToTable("Seller");

                entity.HasOne(d => d.PaymentType)
                    .WithMany(p => p.Sellers)
                    .HasForeignKey(d => d.PaymentTypeId)
                    .HasConstraintName("FK_Seller_PaymentType");

                entity.HasOne(d => d.ShopAddress)
                    .WithMany(p => p.Sellers)
                    .HasForeignKey(d => d.ShopAddressId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Seller_Address");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.Sellers)
                    .HasForeignKey(d => d.UserId)
                    .HasConstraintName("FK_Seller_UserItem");
            });

            modelBuilder.Entity<UserItem>(entity =>
            {
                entity.ToTable("UserItem");

                entity.Property(e => e.AddressId).HasColumnName("AddressID");

                entity.Property(e => e.DateOfBirth).HasColumnType("date");

                entity.Property(e => e.Email)
                    .IsRequired()
                    .IsUnicode(false);

                entity.Property(e => e.Name)
                    .IsRequired()
                    .IsUnicode(false);

                entity.Property(e => e.Password)
                    .IsRequired()
                    .IsUnicode(false);

                entity.Property(e => e.Phone).IsUnicode(false);

                entity.HasOne(d => d.Address)
                    .WithMany(p => p.UserItems)
                    .HasForeignKey(d => d.AddressId)
                    .HasConstraintName("FK_Users_Address");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
