using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace WebApplication1;

public partial class RestorauntDbContext : DbContext
{
    public RestorauntDbContext()
    {
    }

    public RestorauntDbContext(DbContextOptions<RestorauntDbContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Customer> Customers { get; set; }

    public virtual DbSet<CustomerOrder> CustomerOrders { get; set; }

    public virtual DbSet<Dish> Dishes { get; set; }

    public virtual DbSet<DishType> DishTypes { get; set; }

    public virtual DbSet<Employee> Employees { get; set; }

    public virtual DbSet<EmployeeReport> EmployeeReports { get; set; }

    public virtual DbSet<Inventory> Inventories { get; set; }

    public virtual DbSet<Menue> Menues { get; set; }

    public virtual DbSet<OrderFilling> OrderFillings { get; set; }

    public virtual DbSet<Position> Positions { get; set; }

    public virtual DbSet<Restoraunt> Restoraunts { get; set; }

    public virtual DbSet<SalesReport> SalesReports { get; set; }

    public virtual DbSet<Storage> Storages { get; set; }

    public virtual DbSet<Supplier> Suppliers { get; set; }

    public virtual DbSet<SupplyOrder> SupplyOrders { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see https://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("Server=DESKTOP-D2CTRM6\\SQLEXPRESS; Database=RestorauntDB; Trusted_Connection=True; TrustServerCertificate=True;");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Customer>(entity =>
        {
            entity.Property(e => e.CustomerId)
                .ValueGeneratedNever()
                .HasColumnName("Customer_ID");
            entity.Property(e => e.Email)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Name)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Phone)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Surname)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        modelBuilder.Entity<CustomerOrder>(entity =>
        {
            entity.Property(e => e.CustomerOrderId).ValueGeneratedNever();
            entity.Property(e => e.Bill)
                .HasMaxLength(10)
                .IsFixedLength();
            entity.Property(e => e.CustomersCout)
                .HasMaxLength(10)
                .IsFixedLength();
            entity.Property(e => e.Tips)
                .HasMaxLength(10)
                .IsFixedLength();
        });

        modelBuilder.Entity<Dish>(entity =>
        {
            entity.Property(e => e.DishId).ValueGeneratedNever();
            entity.Property(e => e.DishIngridients)
                .HasMaxLength(10)
                .IsFixedLength();
            entity.Property(e => e.DishName)
                .HasMaxLength(10)
                .IsFixedLength();
        });

        modelBuilder.Entity<DishType>(entity =>
        {
            entity.Property(e => e.DishTypeId).ValueGeneratedNever();
            entity.Property(e => e.TypeName)
                .HasMaxLength(10)
                .IsFixedLength();
        });

        modelBuilder.Entity<Employee>(entity =>
        {
            entity.HasKey(e => e.EmployeesId);

            entity.Property(e => e.EmployeesId).ValueGeneratedNever();
            entity.Property(e => e.Address)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Email)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Name)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Phone)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Surname)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        modelBuilder.Entity<EmployeeReport>(entity =>
        {
            entity.Property(e => e.EmployeeReportId).ValueGeneratedNever();
            entity.Property(e => e.HoursWorked)
                .HasMaxLength(10)
                .IsFixedLength();
            entity.Property(e => e.OrdersHandled)
                .HasMaxLength(10)
                .IsFixedLength();
        });

        modelBuilder.Entity<Inventory>(entity =>
        {
            entity.Property(e => e.InventoryId).ValueGeneratedNever();
            entity.Property(e => e.InventoryCout)
                .HasMaxLength(10)
                .IsFixedLength();
            entity.Property(e => e.InventoryName)
                .HasMaxLength(10)
                .IsFixedLength();
        });

        modelBuilder.Entity<Menue>(entity =>
        {
            entity.HasKey(e => e.MenuId);

            entity.Property(e => e.MenuId).ValueGeneratedNever();
            entity.Property(e => e.Description)
                .HasMaxLength(10)
                .IsFixedLength();
            entity.Property(e => e.Price)
                .HasMaxLength(10)
                .IsFixedLength();
        });

        modelBuilder.Entity<OrderFilling>(entity =>
        {
            entity.Property(e => e.OrderFillingId)
                .HasMaxLength(10)
                .IsFixedLength();
            entity.Property(e => e.ProductCout)
                .HasMaxLength(10)
                .IsFixedLength();
            entity.Property(e => e.ProductName)
                .HasMaxLength(10)
                .IsFixedLength();
            entity.Property(e => e.ProductPrice)
                .HasMaxLength(10)
                .IsFixedLength();
        });

        modelBuilder.Entity<Position>(entity =>
        {
            entity.Property(e => e.PositionId).ValueGeneratedNever();
            entity.Property(e => e.PositionName)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        modelBuilder.Entity<Restoraunt>(entity =>
        {
            entity.Property(e => e.RestorauntId).ValueGeneratedNever();
            entity.Property(e => e.RestorauntAddress)
                .HasMaxLength(10)
                .IsFixedLength();
            entity.Property(e => e.RestorauntDiscription)
                .HasMaxLength(10)
                .IsFixedLength();
            entity.Property(e => e.RestorauntName)
                .HasMaxLength(10)
                .IsFixedLength();
            entity.Property(e => e.RestorauntRating)
                .HasMaxLength(10)
                .IsFixedLength();
            entity.Property(e => e.RestorauntSpeifiction)
                .HasMaxLength(10)
                .IsFixedLength();
        });

        modelBuilder.Entity<SalesReport>(entity =>
        {
            entity.HasNoKey();

            entity.Property(e => e.ReportDate).HasColumnType("datetime");
            entity.Property(e => e.SalesReportId)
                .HasMaxLength(10)
                .IsFixedLength();
            entity.Property(e => e.TotalOrders)
                .HasMaxLength(10)
                .IsFixedLength();
            entity.Property(e => e.TotalRevenue)
                .HasMaxLength(10)
                .IsFixedLength();
        });

        modelBuilder.Entity<Storage>(entity =>
        {
            entity.HasNoKey();

            entity.Property(e => e.ObjectCout)
                .HasMaxLength(10)
                .IsFixedLength();
            entity.Property(e => e.ObjectName)
                .HasMaxLength(10)
                .IsFixedLength();
            entity.Property(e => e.ObjectPrice)
                .HasMaxLength(10)
                .IsFixedLength();
            entity.Property(e => e.ObjectUnit)
                .HasMaxLength(10)
                .IsFixedLength();
            entity.Property(e => e.StorageId)
                .HasMaxLength(10)
                .IsFixedLength();
        });

        modelBuilder.Entity<Supplier>(entity =>
        {
            entity.Property(e => e.SupplierId).ValueGeneratedNever();
            entity.Property(e => e.CompanyName)
                .HasMaxLength(10)
                .IsFixedLength();
            entity.Property(e => e.ContactPerson)
                .HasMaxLength(10)
                .IsFixedLength();
            entity.Property(e => e.Email)
                .HasMaxLength(10)
                .IsFixedLength();
            entity.Property(e => e.Phone)
                .HasMaxLength(10)
                .IsFixedLength();
            entity.Property(e => e.ProductSpecification)
                .HasMaxLength(10)
                .IsFixedLength();
        });

        modelBuilder.Entity<SupplyOrder>(entity =>
        {
            entity.Property(e => e.SupplyOrderId)
                .HasMaxLength(10)
                .IsFixedLength();
            entity.Property(e => e.Bill)
                .HasMaxLength(10)
                .IsFixedLength();
            entity.Property(e => e.DeliveryAddress)
                .HasMaxLength(10)
                .IsFixedLength();
            entity.Property(e => e.OrderName)
                .HasMaxLength(10)
                .IsFixedLength();
            entity.Property(e => e.RestorauntId)
                .HasMaxLength(10)
                .IsFixedLength();
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
