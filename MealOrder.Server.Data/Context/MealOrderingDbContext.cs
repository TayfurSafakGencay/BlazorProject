using MealOrder.Server.Data.Models;
using Microsoft.EntityFrameworkCore;

namespace MealOrder.Server.Data.Context
{
  public class MealOrderingDbContext : DbContext
  {
    public MealOrderingDbContext(DbContextOptions<MealOrderingDbContext> options) : base(options){}
    
    public virtual DbSet<User> Users { get; set; }
    public virtual DbSet<Order> Orders { get; set; }
    public virtual DbSet<OrderItem> orderItems { get; set; }
    public virtual DbSet<Supplier> Suppliers { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
      modelBuilder.HasDefaultSchema("public");
      
      modelBuilder.Entity<User>(entity =>
      {
        entity.ToTable("user", "public");

        entity.HasKey(i => i.Id).HasName("pk_user_id");

        entity.Property(i => i.Id).HasColumnName("id").HasColumnType("uuid").HasDefaultValueSql("UUID_GENERATE_V4()").IsRequired();
        entity.Property(i => i.FirstName).HasColumnName("first_name").HasColumnType("character varying").HasMaxLength(100);
        entity.Property(i => i.LastName).HasColumnName("last_name").HasColumnType("character varying").HasMaxLength(100);
        entity.Property(i => i.EMailAddress).HasColumnName("email_address").HasColumnType("character varying").HasMaxLength(100);

        entity.Property(i => i.CreateDate).HasColumnName("create_date").HasColumnType("timestamp without time zone").HasDefaultValueSql("NOW()");

        entity.Property(i => i.IsActive).HasColumnName("isactive").HasColumnType("boolean").HasDefaultValueSql("true");
      });
      
      modelBuilder.Entity<Supplier>(entity =>
      {
        entity.HasKey(i => i.Id).HasName("pk_supplier_id");
        
        entity.ToTable("suppliers", "public");
        
        entity.Property(i => i.Id).HasColumnName("id").HasColumnType("uuid").HasDefaultValueSql("UUID_GENERATE_V4()").IsRequired();
        entity.Property(i => i.IsActive).HasColumnName("isactive").HasColumnType("boolean").HasDefaultValueSql("true");
        entity.Property(i => i.Name).HasColumnName("name").HasColumnType("character varying").HasMaxLength(100);
        entity.Property(i => i.CreateDate).HasColumnName("create_date").HasColumnType("timestamp without time zone").HasDefaultValueSql("NOW()");
        
        entity.Property(i => i.WebURL).HasColumnName("web_url").HasColumnType("character varying").HasMaxLength(500);
      });
      modelBuilder.Entity<Order>(entity =>
      {
        entity.HasKey(i => i.Id).HasName("pk_order_id");
        
        entity.ToTable("orders", "public");
        
        entity.Property(i => i.Id).HasColumnName("id").HasColumnType("uuid").HasDefaultValueSql("UUID_GENERATE_V4()").IsRequired();
        entity.Property(i => i.Name).HasColumnName("name").HasColumnType("character varying").HasMaxLength(100);
        entity.Property(i => i.Description).HasColumnName("description").HasColumnType("character varying").HasMaxLength(1000);
        
        entity.Property(i => i.CreateDate).HasColumnName("create_date").HasColumnType("timestamp without time zone").HasDefaultValueSql("NOW()");
        entity.Property(i => i.CreateUserId).HasColumnName("created_user_id").HasColumnType("uuid");
        entity.Property(i => i.SupplierId).HasColumnName("supplier_id").HasColumnType("uuid").HasDefaultValueSql("UUID_GENERATE_V4()").IsRequired();

        entity.Property(i => i.ExpireDate).HasColumnName("expire_date").HasColumnType("timestamp without time zone").IsRequired();

        entity.HasOne(d => d.CreateUser)
          .WithMany(p => p.Orders)
          .HasForeignKey(d => d.CreateUserId)
          .HasConstraintName("fk_user_order_id")
          .OnDelete(DeleteBehavior.Cascade);
        
        entity.HasOne(d => d.Supplier)
          .WithMany(p => p.Orders)
          .HasForeignKey(d => d.SupplierId)
          .HasConstraintName("fk_supplier_order_id")
          .OnDelete(DeleteBehavior.Cascade);
      });

      modelBuilder.Entity<OrderItem>(entity =>
      {
        entity.HasKey(i => i.Id).HasName("pk_orderItem_id");

        entity.ToTable("order_items", "public");
        
        entity.Property(i => i.Id).HasColumnName("id").HasColumnType("uuid").HasDefaultValueSql("UUID_GENERATE_V4()").IsRequired();
        entity.Property(i => i.Description).HasColumnName("description").HasColumnType("character varying").HasMaxLength(1000);
        entity.Property(i => i.CreateDate).HasColumnName("create_date").HasColumnType("timestamp without time zone").HasDefaultValueSql("NOW()");
        entity.Property(i => i.CreatedUserId).HasColumnName("created_user_id").HasColumnType("uuid");
        entity.Property(i => i.OrderId).HasColumnName("order_id").HasColumnType("uuid");
        
        entity.HasOne(d => d.Order)
          .WithMany(p => p.OrderItems)
          .HasForeignKey(d => d.OrderId)
          .HasConstraintName("fk_orderitems_order_id")
          .OnDelete(DeleteBehavior.Cascade);
        
        entity.HasOne(d => d.CreatedUser)
          .WithMany(p => p.CreatedOrderItems)
          .HasForeignKey(d => d.CreatedUserId)
          .HasConstraintName("fk_orderitems_user_id")
          .OnDelete(DeleteBehavior.Cascade);
      });
      base.OnModelCreating(modelBuilder);
    }
  }
}