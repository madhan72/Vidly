using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Vidly.Models;

namespace Vidly.Controllers
{
    public class CustomersController : Controller
    {
        // GET: Customers
        public ActionResult Index()
        {
            var customers = new List<Customer>
            {
                new Customer { Name="abc 1"},
                new Customer { Name="mkas 2"},
                new Customer { Name="abc 3"},
                new Customer { Name="abc 4"},
                new Customer { Name="abc 5"}
            };

            return View(customers);
        }
    }
}