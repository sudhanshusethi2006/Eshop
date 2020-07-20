using Microsoft.AspNetCore.Hosting;
using System.IO;
using System.Linq;
using System.Text.Json.Serialization;
using Newtonsoft.Json;
using System.Collections.Generic;
using EshopApp.Data.Entities;

namespace EshopApp.Data
{
    public class EshopSeeder
    {
        private readonly EshopContext _eshopContext;
        private readonly IHostingEnvironment _hostingEnvironment;

        public EshopSeeder(EshopContext eshopContext, IHostingEnvironment hostingEnvironment)
        {
            _eshopContext = eshopContext;
            _hostingEnvironment = hostingEnvironment;
        }

        public void Seed()
        {
            _eshopContext.Database.EnsureCreated();
            if(_eshopContext.Products.Any())
            {
                var filePath = Path.Combine(_hostingEnvironment.ContentRootPath + "Data/art.json");
                var json = File.ReadAllText(filePath);
                var products = JsonConvert.DeserializeObject<IEnumerable<Product>>(json);
                _eshopContext.Products.AddRange(products);

                var order = _eshopContext.order.Where(o => o.Id == 1).FirstOrDefault();

                if(order!=null)
                {
                    order.Items = new List<OrderItem>();
                    {
                        new OrderItem()
                        {
                            Product = products.First(),
                            Quantity = 5,
                            UnitPrice = products.First().Price
                        };
                    }

                }
            }
        }
    }
}
