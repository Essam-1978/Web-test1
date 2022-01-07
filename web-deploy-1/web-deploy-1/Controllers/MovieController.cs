using System;
using System.Collections.Generic;
using System.Linq;
using System.Data.Entity;
using System.Web;
using System.Web.Mvc;
using web_deploy_1.Models;

namespace web_deploy_1.Controllers
{
    public class MovieController : Controller

    {

        //Database initialization
        ApplicationDbContext Dbase = new ApplicationDbContext();



        // GET: Movie
        public ActionResult Index()

        {
            Movie mov1 = new Movie { Id = 12, Title = "Star War" };
            Movie mov2 = new Movie { Id = 13, Title = "Star War1" };
            Movie mov3 = new Movie { Id = 14, Title = "Star War2" };

            var Movies = new List<Movie>();
            Movies.Add(mov1); Movies.Add(mov2); Movies.Add(mov3);

            var vewresult = new ViewResult();

            //ViewBag.Movies = Movies;
            //ViewData["Movies"] = Movies;
            return View(Movies);
        }




        public ActionResult Index2()
        {
            var Movies = Dbase.Movies.Include(p => p.Genre).ToList();
            return View(Movies);

        }


        //Action for add form
        public ActionResult new_movie()
        {

            return View();
        }


        public ActionResult Details(int id)
        {
            var Movie = Dbase.Movies.Include(p => p.Genre).SingleOrDefault(p => p.Id == id);

            return View(Movie);
        }


    }
}