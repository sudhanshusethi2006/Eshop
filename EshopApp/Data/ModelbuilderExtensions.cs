using EshopApp.Data.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EshopApp.Data
{
    public static class ModelbuilderExtensions
    {
        public static void seed(this ModelBuilder modelBuilder)
        {
            _ = modelBuilder.Entity<Order>()
.HasData(new Order
{
    Id = 1,
    OrderDate = DateTime.UtcNow,
    OrderNumber = "12345",
    Price = 99.23M,
    isComplete = false

}
,
new Order
{
    Id = 2,
    OrderDate = DateTime.UtcNow,
    OrderNumber = "12346",
    Price = 120.98M,
    isComplete = true

},

new Order
{
    Id = 3,
    OrderDate = DateTime.UtcNow,
    OrderNumber = "12347",
    Price = 150.00M,
    isComplete = false

}
);

        }
    }
}
