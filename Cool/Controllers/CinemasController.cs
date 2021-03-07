using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Cool.Models;
using Cool.ViewModels;

namespace Cool.Controllers
{
    public class CinemasController : Controller
    {
        // GET: Cinemas
        public ActionResult Index()
        {
            //populate Cinema with data
            var Cinema = new List<Cinema>()
            {
                new Cinema { Name = "Spider Man", Id = 101 },
                new Cinema { Name = "God" },
                new Cinema { Name = "Serial Killer" }
            };

            //populate Ticket with data
            var Ticket = new List<Ticket>
            {
                new Ticket { Name = "Balcony" },
                new Ticket { Name = "ODI"},
                new Ticket { Name = "Luxury" }
            };

            //make object of cinemaviewmodel
            var ViewModel = new CinemaViewModel
            {
                Cinema = Cinema,
                Ticket = Ticket
            };


            return View(ViewModel);
        }
    }
}