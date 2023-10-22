using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MVC_Fundamentals_Exercise.Models;

namespace MVC_Fundamentals_Exercise.Controllers
{
    public class CustomerController : Controller
    {
        
        // GET: Customer
        public ActionResult Index()
        {
            Customer customer = new Customer();
            customer.Name = "James";
            return View(customer);
        }

        public ActionResult Details(int id)
        { 
            List<Customer> customerList = new List<Customer>
            {
                new Customer{Name = "Mary Williams"},
                new Customer{Name = "Oak"}
            };
            var customer = new Customer
            {
                Name = customerList[id].Name
            };

            return View(customer);
        }
    }
}