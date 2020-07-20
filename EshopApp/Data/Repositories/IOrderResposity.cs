using EshopApp.Data.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EshopApp.Data.Repositories
{
    public interface IOrderResposity
    {

        IEnumerable<Order> GetAllOrders();
        Order GetOrder(int OrderId);
        public Order Update(Order order);
        public Order Delete(int id);

        public Order Add(Order order); 
    }
}
