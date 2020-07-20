using EshopApp.Data.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EshopApp.Data.Repositories
{
    public class SQLOrderRepository : IOrderResposity
    {
        EshopContext _eshopContext;
        public SQLOrderRepository(EshopContext eshopContext)
        {
            _eshopContext = eshopContext;
        }
        public Order Delete(int id)
        {
            Order order = _eshopContext.order.Find(id);
            if(order!=null)
            {
                _eshopContext.order.Remove(order);
                _eshopContext.SaveChanges();
            }

            return order;

        }

        public IEnumerable<Order> GetAllOrders()
        {
            return _eshopContext.order;
        }

        public Order GetOrder(int OrderId)
        {
            return _eshopContext.order.Find(OrderId);
        }

        public Order Update(Order orderChanges)
        {
            var order = _eshopContext.order.Attach(orderChanges);
            order.State = Microsoft.EntityFrameworkCore.EntityState.Modified;
            _eshopContext.SaveChanges();
            return orderChanges;
        }

        public Order Add(Order order)
        {
            _eshopContext.order.Add(order);
            _eshopContext.SaveChanges();
            return order;
        }
    }
}
