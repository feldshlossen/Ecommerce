using System;
using System.Collections.Generic;
using System.Text;
using Ecommerce.Core.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.AspNetCore.Mvc.Formatters;
using Microsoft.EntityFrameworkCore;

namespace Ecommerce.Data
{
    public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
    {

        public DbSet<Cart> Carts { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<ProductCategory> ProductCategories { get; set; }


        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }


        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            builder.Entity<Cart>()
                   .HasKey(c => new { c.UserId, c.ProductId });

            builder.Entity<Cart>()
                .HasOne(c => c.User)
                .WithMany(p => p.Carts)
                .HasForeignKey(u => u.UserId);

            builder.Entity<Cart>()
                .HasOne(p => p.Product)
                .WithMany(c => c.Carts)
                .HasForeignKey(p => p.ProductId);


            builder.Entity<ProductCategory>()
                .HasKey(pc => new { pc.ProductId, pc.CategoryId });

            builder.Entity<ProductCategory>()
                .HasOne(p => p.Product)
                .WithMany(b => b.ProductCategories)
                .HasForeignKey(p => p.ProductId);

            builder.Entity<ProductCategory>()
                .HasOne(c => c.Category)
                .WithMany(pc => pc.ProductCategories)
                .HasForeignKey(c => c.CategoryId);


            builder.Entity<Product>()
               .Property(p => p.Price)
               .IsRequired()
               .HasColumnType("decimal(5,2)");



        }
    }
}
