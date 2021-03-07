using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Cool.Models;
using Cool.ViewModels;
namespace Cool.Controllers
{
    public class MoviesController : Controller
    {
        // GET: Movies/Index
        public ActionResult Index()
        {
            //var movie = new Movie() { Name = "Shrek!"  };

            //var customers = new List<Customer>
            //{
            //    new Customer { Name = "Customer 1" },
            //    new Customer { Name = "Customer 2" }
            //};

            //var viewModel = new RandomMovieViewModel
            //{
            //    Movie = movie,
            //    Customers = customers
            //};

            var movies = new List<Movie>
            {
                new Movie { Name = "Ice age" },
                new Movie { Name = "Titanic" },
                new Movie { Name = "Nemo" }
            };
            return View(movies);
        }



  
    


        //public ActionResult Edit(int id)
        //{
        //    return Content("id=" + id);
        //}




        ////attrinute route
        //[Route("movies/released/{year}/{month}")]
        //public ActionResult ByReleaseDate(int year, int month)
        //{
        //    return Content(year + "/" + month);
        //}






        //[Route("movies/genres/{genre}/{year}")]
        //public ActionResult Genre(string genre, int year)
        //{
        //    return Content(genre + "/" + year);
        //}





        //[Route("movies/{names}/{territory}/{area}")]
        //public ActionResult Name(string names, string territory, string area)
        //{
        //    return Content(names + "/" + territory + "/" + area);
        //}
    }
}