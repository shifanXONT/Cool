using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace Cool
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            //attribute route enabling method
            routes.MapMvcAttributeRoutes();

            ////custom route
            //routes.MapRoute(
            //    name: "MoviesByReleaseDate",
            //    url: "movies/released/{year}/{month}",
            //    defaults: new { controller = "Movies", action = "ByReleaseDate" } );

            //routes.MapRoute(
            //     "MoviesByGenre",
            //    "movies/genre/{genre}/{year}",
            //     new { controller = "Movies", action = "Genre" },
            //       //new { year = @"\d{4}" });
            //       new { year = @"2015 | 2016" });



            //routes.MapRoute(
            //    name: "CompanyName",
            //    url: "company/namelist/{names}/{territory}/{area}",
            //    defaults: new { controller = "Books", action = "Name"});

            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional }
            );
        }
    }
}
