using System;
using System.Linq;
using EshopApp.Data;
using EshopApp.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace EshopApp.Controllers
{
    public class AppController : Controller
    {
    //    private readonly IMailService _mailService;
        private readonly EshopContext _eshopContext; 

        public AppController(EshopContext eshopContext)
        {

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
            var results = _eshopContext.Products
                .OrderBy(p => p.Category)
                .ToList();

            //or

            var results2 = from p in _eshopContext.Products orderby p.Category select p;
            return View(results);
        }
    }
}