using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MovieDB.Controllers
{
    public class HomeController : Controller
    {
        //
        // GET: /Home/

        public ActionResult Index()
        {
            return View();
        }

        public ActionResult SearchResult()
        {
            MovieDB.Models.Movies.Movie movie = new Models.Movies.Movie();
            movie.Plot = "hey what's up my friend!";
            return View(movie);
        }

        public ActionResult SingleReview()
        {
            return View();
        }

    }
}
