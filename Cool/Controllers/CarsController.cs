using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Cool.Models;
using Cool.ViewModels;

namespace Cool.Controllers
{
    public class CarsController : Controller
    {
        // GET: Cars/Random
        public ActionResult Random()
        {
            var car = new Car() { Name = "Benz"};

            var rent = new List<Rent>
            {
                new Rent { Name = "Suman" },
                new Rent { Name = "Raiz" }
            };

            var viewModel2 = new RandomCarViewModel
            {
                Car = car,
                Rent = rent

            };

            return View(viewModel2);
        }
    }
}