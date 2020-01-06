using DreamStream.Models;
using DreamStream.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace DreamStream.Controllers
{
    public class CustomersController : Controller
    {
        // GET: Customers
        public ActionResult Index()
        {
            var customer = new List<Customer>()
            {
                new Customer { Name = "John Smith", Id = 1 },
                new Customer { Name = "Nancy Smith", Id = 2 }
            };
            var viewModel = new CustomerViewModel
            {
                Customer = customer
            };
            return View(viewModel);
        }
    }
}