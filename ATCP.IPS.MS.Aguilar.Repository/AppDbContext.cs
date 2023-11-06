﻿using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;

namespace ATCP.IPS.MS.Aguilar.Repository
{
    public partial class AppDbContext : DbContext, IAppDbContext
    {
        public AppDbContext()
        {
        }

        public AppDbContext(DbContextOptions<AppDbContext> options)
        : base(options)
        {
        }
        public virtual DbSet<Customers> Customers { get; set; }
        public virtual DbSet<Orders> Orders { get; set; }
        public virtual DbSet<Products> Products { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Customers>(entity =>
            {
                entity.HasKey(e => e.CustomerId)
                .HasName("PK_Customer_CustomerID");
                entity.Property(e => e.CustomerId).HasColumnName("CustomerID");
                entity.Property(e => e.Address)
                .IsRequired()
                .HasMaxLength(250);
                entity.Property(e => e.CreatedBy)
                .IsRequired()
                .HasMaxLength(50);
                entity.Property(e => e.CreatedDttm).HasColumnType("datetime");
                entity.Property(e => e.FirstName)
                .IsRequired()
                .HasMaxLength(50);
                entity.Property(e => e.Gender).HasMaxLength(10);
                entity.Property(e => e.LastName).HasMaxLength(50);
                entity.Property(e => e.MiddleName)
                .IsRequired()
                .HasMaxLength(50);
                entity.Property(e => e.UpdatedBy).HasMaxLength(50);
                entity.Property(e => e.UpdatedDttm).HasColumnType("datetime");
            });
            modelBuilder.Entity<Orders>(entity =>
            {
                entity.HasKey(e => e.OrderId)
                .HasName("PK_Orders_OrderID");
                entity.Property(e => e.OrderId).HasColumnName("OrderID");
                entity.Property(e => e.CreatedBy)
                .IsRequired()
                .HasMaxLength(50);
                entity.Property(e => e.CreatedDttm).HasColumnType("datetime");
                entity.Property(e => e.CustomerId).HasColumnName("CustomerID");
                entity.Property(e => e.DeliveryAddress)
                .IsRequired()
                .HasMaxLength(50);
                entity.Property(e => e.ProductId).HasColumnName("ProductID");
                entity.Property(e => e.TotalAmount).HasColumnType("money");
                entity.Property(e => e.UnitPrice).HasColumnType("money");
                entity.Property(e => e.UpdatedBy).HasMaxLength(50);
                entity.Property(e => e.UpdatedDttm).HasColumnType("datetime");
                entity.HasOne(d => d.Customer)
                .WithMany(p => p.Orders)
                .HasForeignKey(d => d.CustomerId)
                .OnDelete(DeleteBehavior.ClientSetNull);
                entity.HasOne(d => d.Product)
                .WithMany(p => p.Orders)
                .HasForeignKey(d => d.ProductId)
                .OnDelete(DeleteBehavior.ClientSetNull);
            });
            modelBuilder.Entity<Products>(entity =>
            {
                entity.HasKey(e => e.ProductId)
                .HasName("PK_Products_ProductID");
                entity.Property(e => e.ProductId).HasColumnName("ProductID");
                entity.Property(e => e.CreatedBy)
                .IsRequired()
                .HasMaxLength(50);
                entity.Property(e => e.CreatedDttm).HasColumnType("datetime");
                entity.Property(e => e.ProductName)
                .IsRequired()
                .HasMaxLength(50);
                entity.Property(e => e.UnitPrice).HasColumnType("money");
                entity.Property(e => e.UpdatedBy).HasMaxLength(50);
                entity.Property(e => e.UpdatedDttm).HasColumnType("datetime");
            });
            OnModelCreatingPartial(modelBuilder);
        }
        public new DbSet<TEntity> Set<TEntity>() where TEntity : class
        {
            return base.Set<TEntity>();
        }
        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);

    }
}
