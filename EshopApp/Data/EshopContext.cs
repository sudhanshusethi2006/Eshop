using System;
using EshopApp.Data.Entities;
using Microsoft.EntityFrameworkCore;

namespace EshopApp.Data
{
    public class EshopContext : DbContext
    {
        public EshopContext()
        {

        }

        public EshopContext(DbContextOptions<EshopContext> options): base(options)
        {

        }
        public DbSet<Product> Products { get; set; }

        public DbSet<Order> order { get; set; }


        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=localhost,1433; Database=EshopDB;User=SA; Password=Canada@007");
        }
    }   
}
