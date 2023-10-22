using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.UI.WebControls;
using Vidly.Models;

namespace Vidly.Controllers
{
    public class MoviesController : Controller
    {
        // GET: Movies

        /*
         * ActionResult returns a View
         * It is better practice to call the method as ViewResult 
         */
       // public ActionResult Random() -- ORIGINAL
        public ActionResult Random()
        {
            var movie = new Movie()
            {
                Name = "Shrek!"
            };
            return Content(movie.Name);
        }
    }
}