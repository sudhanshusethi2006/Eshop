using EshopApp.Data.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EshopApp.Data.Repositories
{
    public class MockOrderRepository : IOrderResposity
    {

        private List<Order> _OrdersList;
        public MockOrderRepository()
        {
            _OrdersList = new List<Order>()
            {
                new Order {Id=1, isComplete=false,OrderDate= DateTime.UtcNow, Price=67, OrderNumber="123" }
            };
        }

        public Order Delete(int id)
        {
            Order order = _OrdersList.FirstOrDefault(e => e.Id == id);
            if(order!=null)
            {

                _OrdersList.Remove(order);
            }
            return order;
        }

        public Order Update(Order order)
        {
            Order _order = _OrdersList.FirstOrDefault(e => e.Id == order.Id);
            if(_order!=null)
            {
                _order.OrderDate = order.OrderDate;
                _order.OrderNumber = order.OrderNumber;
            }

            return order;
        }
        public IEnumerable<Order> GetAllOrders()
        {
            return _OrdersList;
        }

        public Order GetOrder(int OrderId)
        {
            return _OrdersList.FirstOrDefault(e => e.Id == OrderId);
        }


        public Order Add(Order order)
        {
            order.Id = _OrdersList.Max(e => e.Id) + 1;
            _OrdersList.Add(order);
            return order;
        }

    }
}
