using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.UI.WebControls;
using Vidly.Models;
using Vidly.ViewModels;


namespace Vidly.Controllers
{
    public class MoviesController : Controller
    {
        // GET: Movies/Random

        //It comes as "ActionResult" by default, but it is a good practice to use ViewResult (Specially for testing) 
        public ActionResult Random()
        {
            var movie = new Models.Movie();
            movie.Name = "Shrek";
            return View(movie);
            /*
             * return Content("HelloWorld");
             * return HttpNotFound();
             * return new EmptyResult();
             * return RedirectToAction("Index", "Home", new { page = 1, sortBy = "name"});
            */
        }

        //mvcaction4 + tab
        public ActionResult Edit(int mid)
        {
            return Content("id= " + mid);
        }

        //Create a method with nullable int to get parameters by default 
        public ActionResult Index(int? pageIndex, String sortBy)
        {
            if (!pageIndex.HasValue)
                pageIndex = 1;
            if (String.IsNullOrWhiteSpace(sortBy))
                sortBy = "Name";

            return Content(String.Format("pageIndex={0} & sortBy={1}", pageIndex, sortBy));
            //return Content($"pageIndex={pageIndex} & sortBy={sortBy}");
        }


        /*
         * You don't need to memorize all the attributes
         * Go to Google and Search: ASP.NET MVC Attribute Route Constraints
         * This route comes from RouteConfig
         *    route.MapMvcAttributeRoutesBBB
         */

        [Route("movies/released/{year}/{month:regex(\\d{2}):range(1,12)}")]
        public ActionResult ByReleaseDate(int year, byte month)
        {
            return Content(year + "/" + month);
        }


        /*
         * Elements from the ViewModels & Customer class & RandomView
         */
        public ActionResult RandomView()
        {
            var movie = new Movie();
            var customers = new List<Customer>
            {
                new Customer{Name = "Customer 1"},
                new Customer{Name = "Customer 2"},
            };

            var viewModel = new RandomMovieViewModel
            {
                Movie = movie,
                Customers = customers
            };
            return View(viewModel);
        }
    }
}