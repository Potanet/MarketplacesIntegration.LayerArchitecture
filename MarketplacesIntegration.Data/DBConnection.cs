using MarketplacesIntegration.Shared.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarketplacesIntegration.Data
{
    public partial class DBConnection : DbContext
    {
        public DBConnection()
        {
        }

        public DBConnection(DbContextOptions<DBConnection> options)
            : base(options)
        {
        }

        public virtual DbSet<AbleToInvoice> AbleToInvoices { get; set; } = null!;
        public virtual DbSet<ApiLog> ApiLogs { get; set; } = null!;
        public virtual DbSet<ApiLogin> ApiLogins { get; set; } = null!;
        public virtual DbSet<Shared.Models.Attribute> Attributes { get; set; } = null!;
        public virtual DbSet<Category> Categories { get; set; } = null!;
        public virtual DbSet<Image> Images { get; set; } = null!;
        public virtual DbSet<InvoiceHistory> InvoiceHistories { get; set; } = null!;
        public virtual DbSet<Log> Logs { get; set; } = null!;
        public virtual DbSet<MarketPlace> MarketPlaces { get; set; } = null!;
        public virtual DbSet<MarketPlaceLog> MarketPlaceLogs { get; set; } = null!;
        public virtual DbSet<MarketPlaceOrderStatus> MarketPlaceOrderStatuses { get; set; } = null!;
        public virtual DbSet<MarketPlaceProduct> MarketPlaceProducts { get; set; } = null!;
        public virtual DbSet<MarketPlacesCategory> MarketPlacesCategories { get; set; } = null!;
        public virtual DbSet<OperationType> OperationTypes { get; set; } = null!;
        public virtual DbSet<Order> Orders { get; set; } = null!;
        public virtual DbSet<OrderLine> OrderLines { get; set; } = null!;
        public virtual DbSet<OrderStatus> OrderStatuses { get; set; } = null!;
        public virtual DbSet<OrderStatusHistory> OrderStatusHistories { get; set; } = null!;
        public virtual DbSet<Price> Prices { get; set; } = null!;
        public virtual DbSet<Product> Products { get; set; } = null!;
        public virtual DbSet<User> Users { get; set; } = null!;
        public virtual DbSet<XfaturaAccount> XfaturaAccounts { get; set; } = null!;

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer("Server=db.kurumsaldns.net;database=PosalesMarketplace;user=usrPMarketplace;password=Za(2xFL*^f!;");
            }
        }

        //Scaffold-DbContext "Server=db.kurumsaldns.net;database=PosalesMarketplace;user=usrPMarketplace;password=Za(2xFL*^f!;" Microsoft.EntityFrameworkCore.SqlServer -v -o Models -context "DBConection"

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<AbleToInvoice>(entity =>
            {
                entity.ToTable("AbleToInvoice");

                entity.HasOne(d => d.ApiLogin)
                    .WithMany(p => p.AbleToInvoices)
                    .HasForeignKey(d => d.ApiLoginId)
                    .HasConstraintName("FK_AbleToInvoice_ApiLogin");

                entity.HasOne(d => d.MarketPlace)
                    .WithMany(p => p.AbleToInvoices)
                    .HasForeignKey(d => d.MarketPlaceId)
                    .HasConstraintName("FK_AbleToInvoice_MarketPlace");

                entity.HasOne(d => d.OrderStatus)
                    .WithMany(p => p.AbleToInvoices)
                    .HasForeignKey(d => d.OrderStatusId)
                    .HasConstraintName("FK_AbleToInvoice_OrderStatus");
            });

            modelBuilder.Entity<ApiLog>(entity =>
            {
                entity.ToTable("ApiLog");

                entity.Property(e => e.Id)
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.EndDateTime).HasColumnType("datetime");

                entity.Property(e => e.Json).HasColumnType("text");

                entity.Property(e => e.SaveDate).HasColumnType("datetime");

                entity.Property(e => e.StartDateTime).HasColumnType("datetime");

                entity.HasOne(d => d.ApiLogin)
                    .WithMany(p => p.ApiLogs)
                    .HasForeignKey(d => d.ApiLoginId)
                    .HasConstraintName("FK_ApiLog_ApiLogin");
            });

            modelBuilder.Entity<ApiLogin>(entity =>
            {
                entity.ToTable("ApiLogin");

                entity.Property(e => e.AppKey).IsUnicode(false);

                entity.Property(e => e.AppName).IsUnicode(false);

                entity.Property(e => e.AppSecretKey).IsUnicode(false);

                entity.Property(e => e.MerchantId).IsUnicode(false);

                entity.Property(e => e.Password).IsUnicode(false);

                entity.Property(e => e.SupplierId).IsUnicode(false);

                entity.Property(e => e.Username).IsUnicode(false);

                entity.HasOne(d => d.MaeketPlace)
                    .WithMany(p => p.ApiLogins)
                    .HasForeignKey(d => d.MaeketPlaceId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ApiLogin_MarketPlace");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.ApiLogins)
                    .HasForeignKey(d => d.UserId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ApiLogin_User");
            });

            modelBuilder.Entity<Shared.Models.Attribute>(entity =>
            {
                entity.HasOne(d => d.MarketPlace)
                    .WithMany(p => p.Attributes)
                    .HasForeignKey(d => d.MarketPlaceId)
                    .HasConstraintName("FK_Attributes_MarketPlace");

                entity.HasOne(d => d.Product)
                    .WithMany(p => p.Attributes)
                    .HasForeignKey(d => d.ProductId)
                    .HasConstraintName("FK_Attributes_Products");
            });

            modelBuilder.Entity<Category>(entity =>
            {
                entity.ToTable("Category");
            });

            modelBuilder.Entity<Image>(entity =>
            {
                entity.HasOne(d => d.Product)
                    .WithMany(p => p.Images)
                    .HasForeignKey(d => d.ProductId)
                    .HasConstraintName("FK_Images_Products");
            });

            modelBuilder.Entity<InvoiceHistory>(entity =>
            {
                entity.ToTable("InvoiceHistory");

                entity.Property(e => e.Json).HasColumnName("json");

                entity.Property(e => e.Message).HasColumnName("message");

                entity.Property(e => e.OrderId)
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.SaveDate).HasColumnType("datetime");

                entity.Property(e => e.Value).HasColumnName("value");

                entity.HasOne(d => d.Order)
                    .WithMany(p => p.InvoiceHistories)
                    .HasForeignKey(d => d.OrderId)
                    .HasConstraintName("FK_InvoiceHistory_Order");
            });

            modelBuilder.Entity<Log>(entity =>
            {
                entity.ToTable("Log");

                entity.Property(e => e.DateTime).HasColumnType("datetime");

                entity.Property(e => e.Ip).HasMaxLength(16);

                entity.Property(e => e.RequestTallMessage).HasColumnType("text");

                entity.Property(e => e.ResponseTallMessage).HasColumnType("text");

                entity.Property(e => e.ShortMessage).HasMaxLength(250);
            });

            modelBuilder.Entity<MarketPlace>(entity =>
            {
                entity.ToTable("MarketPlace");

                entity.Property(e => e.Name).HasMaxLength(50);
            });

            modelBuilder.Entity<MarketPlaceLog>(entity =>
            {
                entity.ToTable("MarketPlaceLog");

                entity.Property(e => e.DateTime).HasColumnType("datetime");

                entity.HasOne(d => d.OperationType)
                    .WithMany(p => p.MarketPlaceLogs)
                    .HasForeignKey(d => d.OperationTypeId)
                    .HasConstraintName("FK_MarketPlaceLog_OperationType");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.MarketPlaceLogs)
                    .HasForeignKey(d => d.UserId)
                    .HasConstraintName("FK_MarketPlaceLog_User");
            });

            modelBuilder.Entity<MarketPlaceOrderStatus>(entity =>
            {
                entity.ToTable("MarketPlaceOrderStatus");

                entity.Property(e => e.Status).HasMaxLength(250);

                entity.Property(e => e.StatusCode).HasMaxLength(250);

                entity.HasOne(d => d.MarketPlace)
                    .WithMany(p => p.MarketPlaceOrderStatuses)
                    .HasForeignKey(d => d.MarketPlaceId)
                    .HasConstraintName("FK_MarketPlaceOrderStatus_MarketPlace");

                entity.HasOne(d => d.OrderStatus)
                    .WithMany(p => p.MarketPlaceOrderStatuses)
                    .HasForeignKey(d => d.OrderStatusId)
                    .HasConstraintName("FK_MarketPlaceOrderStatus_OrderStatus");
            });

            modelBuilder.Entity<MarketPlaceProduct>(entity =>
            {
                entity.ToTable("MarketPlaceProduct");

                entity.HasOne(d => d.MarketPlace)
                    .WithMany(p => p.MarketPlaceProducts)
                    .HasForeignKey(d => d.MarketPlaceId)
                    .HasConstraintName("FK_MarketPlaceProduct_MarketPlace");

                entity.HasOne(d => d.Product)
                    .WithMany(p => p.MarketPlaceProducts)
                    .HasForeignKey(d => d.ProductId)
                    .HasConstraintName("FK_MarketPlaceProduct_Products");
            });

            modelBuilder.Entity<MarketPlacesCategory>(entity =>
            {
                entity.ToTable("MarketPlacesCategory");

                entity.HasOne(d => d.Categori)
                    .WithMany(p => p.MarketPlacesCategories)
                    .HasForeignKey(d => d.CategoriId)
                    .HasConstraintName("FK_MarketPlacesCategory_Category");

                entity.HasOne(d => d.MarketPalce)
                    .WithMany(p => p.MarketPlacesCategories)
                    .HasForeignKey(d => d.MarketPalceId)
                    .HasConstraintName("FK_MarketPlacesCategory_MarketPlace");
            });

            modelBuilder.Entity<OperationType>(entity =>
            {
                entity.ToTable("OperationType");
            });

            modelBuilder.Entity<Order>(entity =>
            {
                entity.ToTable("Order");

                entity.Property(e => e.Id)
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.ApiId).IsUnicode(false);

                entity.Property(e => e.City).IsUnicode(false);

                entity.Property(e => e.CreatDate).HasColumnType("datetime");

                entity.Property(e => e.Email).IsUnicode(false);

                entity.Property(e => e.InvoiceNo).IsUnicode(false);

                entity.Property(e => e.MarketPlaceOrderId).IsUnicode(false);

                entity.Property(e => e.Note1).IsUnicode(false);

                entity.Property(e => e.OrderDate).HasColumnType("datetime");

                entity.Property(e => e.OrderNumber).IsUnicode(false);

                entity.Property(e => e.Status).IsUnicode(false);

                entity.Property(e => e.StreetName).IsUnicode(false);

                entity.Property(e => e.TaxOffice).IsUnicode(false);

                entity.Property(e => e.TcknVn)
                    .IsUnicode(false)
                    .HasColumnName("TCKN_VN");

                entity.Property(e => e.Title).IsUnicode(false);

                entity.Property(e => e.Town).IsUnicode(false);
            });

            modelBuilder.Entity<OrderLine>(entity =>
            {
                entity.Property(e => e.MarketPlaceOrderId)
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.OrderId)
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.ProductCode).IsUnicode(false);

                entity.Property(e => e.ProductName).IsUnicode(false);

                entity.Property(e => e.Status)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Unit).IsUnicode(false);

                entity.Property(e => e.UnitCode).IsUnicode(false);

                entity.HasOne(d => d.MarketPlaceOrderStatus)
                    .WithMany(p => p.OrderLines)
                    .HasForeignKey(d => d.MarketPlaceOrderStatusId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_OrderLines_MarketPlaceOrderStatus");

                entity.HasOne(d => d.Order)
                    .WithMany(p => p.OrderLines)
                    .HasForeignKey(d => d.OrderId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_OrderLines_Order");
            });

            modelBuilder.Entity<OrderStatus>(entity =>
            {
                entity.ToTable("OrderStatus");

                entity.Property(e => e.Status)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<OrderStatusHistory>(entity =>
            {
                entity.ToTable("OrderStatusHistory");

                entity.Property(e => e.SaveDate).HasColumnType("datetime");

                entity.HasOne(d => d.MarketPlaceOrderStatus)
                    .WithMany(p => p.OrderStatusHistories)
                    .HasForeignKey(d => d.MarketPlaceOrderStatusId)
                    .HasConstraintName("FK_OrderStatusHistory_MarketPlaceOrderStatus");

                entity.HasOne(d => d.OrderLines)
                    .WithMany(p => p.OrderStatusHistories)
                    .HasForeignKey(d => d.OrderLinesId)
                    .HasConstraintName("FK_OrderStatusHistory_OrderLines");
            });

            modelBuilder.Entity<Price>(entity =>
            {
                entity.Property(e => e.DateTime).HasColumnType("datetime");

                entity.Property(e => e.Price1).HasColumnName("Price");

                entity.HasOne(d => d.Product)
                    .WithMany(p => p.Prices)
                    .HasForeignKey(d => d.ProductId)
                    .HasConstraintName("FK_Prices_Products1");
            });

            modelBuilder.Entity<Product>(entity =>
            {
                entity.HasOne(d => d.Category)
                    .WithMany(p => p.Products)
                    .HasForeignKey(d => d.CategoryId)
                    .HasConstraintName("FK_Products_Category");
            });

            modelBuilder.Entity<User>(entity =>
            {
                entity.ToTable("User");

                entity.Property(e => e.Email).IsUnicode(false);

                entity.Property(e => e.Tel)
                    .HasMaxLength(15)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<XfaturaAccount>(entity =>
            {
                entity.ToTable("XfaturaAccount");

                entity.Property(e => e.Password).HasMaxLength(250);

                entity.Property(e => e.Tenant).HasMaxLength(250);

                entity.Property(e => e.UserName).HasMaxLength(250);

                entity.HasOne(d => d.User)
                    .WithMany(p => p.XfaturaAccounts)
                    .HasForeignKey(d => d.UserId)
                    .HasConstraintName("FK_XfaturaAccount_User");
            });
        }
    }
}
