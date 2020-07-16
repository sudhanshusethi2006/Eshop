using System;
using EshopApp.Data.Entities;
using Microsoft.EntityFrameworkCore;

namespace EshopApp.Data
{
    public class EshopContext : DbContext
    {

        public EshopContext(DbContextOptions<EshopContext> options) : base(options)
        {
            // important 
            //Database.EnsureCreated();
        }
        public DbSet<Product> Products { get; set; }

        public DbSet<Order> order { get; set; }

        // this is another way to connect to database without using the connection string
        //protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        //{
        //    optionsBuilder.UseSqlServer("Server=localhost,1433; Database=EshopDB;User=SA; Password=Canada@007");
        //}


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);


            // here you specify different properties used by models
            //modelBuilder.Entity<Product>()
            //    .Property(p => p.Title)
            //    .HasMaxLength(50);

            // this how you can create an order

            modelBuilder.Entity<Order>()
.HasData(new Order()
{
    Id=1,
    OrderDate=DateTime.UtcNow,
    OrderNumber="12345"

});



        }
    }
}
