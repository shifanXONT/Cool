using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Cool.Models;
using Cool.ViewModels;

namespace Cool.Controllers
{
    public class HousesController : Controller
    {
        // GET: Houses/Random
        public ActionResult Random()
        {
            var house = new House() { Name = "Villa" };
            var buyers = new List<Buyer>
            {
                new Buyer { Name = "Sunil" },
                new Buyer {Name = "Lal" }
            };

            var viewModel = new RandomHouseViewModel
            {
                House = house,
                Buyers = buyers
            };

            return View(viewModel);
        }
    }
}