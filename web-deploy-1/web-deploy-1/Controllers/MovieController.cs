using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using web_deploy_1.Models;

namespace web_deploy_1.Controllers
{
    public class MovieController : Controller
    {
        // GET: Movie
        public ActionResult Index()

        {
            Movie mov1 = new Movie { mov_id = 12, mov_title = "Star War" };
            Movie mov2 = new Movie { mov_id = 13, mov_title = "Star War1" };
            Movie mov3 = new Movie { mov_id = 14, mov_title = "Star War2" };

            var Movies = new List<Movie>();
            Movies.Add(mov1); Movies.Add(mov2); Movies.Add(mov3);

            var vewresult = new ViewResult();

            //ViewBag.Movies = Movies;
            //ViewData["Movies"] = Movies;
            return View(Movies);
        }
    }
}