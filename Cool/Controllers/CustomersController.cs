using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Cool.Models;

namespace Cool.Controllers
{
    public class CustomersController : Controller
    {
        // GET: Customers/index
        public ViewResult Index()
        {
            var customers = GetCustomers();
            //var customers = new List<Customer>
            //{
            //    new Customer { Name = "Ashwin", Id = 1 },
            //    new Customer { Name = "Susan", Id = 2 },
            //    new Customer { Name = "Williams", Id = 3 }
            //};

            return View(customers);
        }




        public ActionResult Details(int id)
        {
            var customer = GetCustomers().SingleOrDefault(c => c.Id == id);

            if (customer == null)
                return HttpNotFound();

            return View(customer);
        }





        private List<Customer> GetCustomers()
        {
            return new List<Customer>
            {
                //new Customer { Id = 1, Name = "Shifan" },
                //new Customer { Id = 2, Name = "Harris" },
                //new Customer { Id = 3, Name = "Fariq"}
            };
        }
    }
}