using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Cool.Models;
using Cool.ViewModels;

namespace Cool.Controllers
{
    public class CompanyController : Controller
    {
        // GET: Company
        public ActionResult Index()
        {
            //populate Company name
            var Company = new List<Company>
            {
                new Company { Name = "Apple" },
                new Company { Name =  "Samsung"},
                new Company { Name = "Nokia" }
            };

            //populate Phone names
            var Phone = new List<Phone>
            {
                new Phone { Name = "IPhone 6S" },
                new Phone { Name = "Lumia" },
                 new Phone { Name = "Lumia" }
            };

            //make objet of ComapnyViewModel
            var VM = new CompanyViewModel
            {
                Company = Company,
                Phone = Phone
            };

            return View(VM);
        }
    }
}