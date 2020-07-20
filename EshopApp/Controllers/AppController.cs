using System;
using System.Linq;
using EshopApp.Data;
using EshopApp.Data.Entities;
using EshopApp.Data.Repositories;
using EshopApp.services;
using EshopApp.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace EshopApp.Controllers
{
    public class AppController : Controller
    {
    //    private readonly IMailService _mailService;
        private readonly EshopContext _eshopContext;
        private readonly IOrderResposity _orderRepository;
        private IMailService _mailService;

        public AppController(IMailService mailService, EshopContext eshopContext , IOrderResposity orderResposity)
        {

            _mailService = mailService;
            _eshopContext = eshopContext;
            _orderRepository = orderResposity;

        }
        // GET
        public IActionResult Index()
        {
            // throw new InvalidOperationException();
            
            return View();
        }

       // [HttpGet("contact")]
        public IActionResult Contact()
        {
            ViewBag.Title = "Contact Us";
          //  _mailService.SendMessage("ssethi2019@gmail.com", "hello contact page", "body of my email");
            ViewBag.UserMessage = "Email sent";
           // throw new InvalidOperationException("Bad Contact");
            return View();
        }

        [HttpPost]
        public IActionResult Contact(ContactViewModel model)
        {
            if(ModelState.IsValid)
            {
                
              
            }
            else
            {
              //          _eshopContext.Posts.Add(model);
                _eshopContext.SaveChanges();
            }

            return View();
        }

         
        public IActionResult About()
        {
                ViewBag.Title = "About us";
            return View();
        }


        public IActionResult Shop()
        {
            var model = _orderRepository.GetAllOrders();
            var results = _eshopContext.order
                .OrderBy(p => p.OrderNumber)
                .ToList();

            //or

            var results2 = from p in _eshopContext.Products orderby p.Category select p;
            return View(results);
        }

        public IActionResult CreateOrder(Order order)
        {
            if(ModelState.IsValid)
            {
                Order newOrder = _orderRepository.Add(order);
            }

            return View();
        }

        public IActionResult ViewOrder(int? id)
        {
            OrdersViewModel ordersViewModel = new OrdersViewModel();

            Order order = _orderRepository.GetOrder(id ?? 1);

            return View(order);
        }
    }
}