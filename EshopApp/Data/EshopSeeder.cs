using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace EshopApp.Data
{
    public class EshopSeeder
    {
        private readonly EshopContext _eshopContext;

        public EshopSeeder(EshopContext eshopContext)
        {
            _eshopContext = eshopContext;
        }

        public void Seed()
        {
            _eshopContext.Database.EnsureCreated();
            if(_eshopContext.Products.Any())
            {

            }
        }
    }
}
