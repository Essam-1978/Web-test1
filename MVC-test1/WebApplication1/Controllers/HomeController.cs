using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebApplication1.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }



        public string essam()
        {
            return "This is essam1";
        }


        public int essam2()
        {
            return 20;
        }



        public ActionResult passing_info()
        {
            ViewData["Name"] = "LOLO";
            ViewData["Desc"] = "This is test for viewdata dictionary object which is one way of passing variables in MVC";
            ViewBag.Name = "VIEW BAG";
            ViewBag.Desc = "This is the name of ViwBag object";
            ViewBag.No = 334;

            //string gg = "LOLO";

            return View();

        }




        public string essam6(string name)
        {
            return string.Format("Th4 nAme yds" + name); 
        }



        public ActionResult Redirect_link()
        {
            return RedirectPermanent("http://www.google.com");
        }




        /*public ActionResult Get_file()
        {
            return ();
        }
        */
    }
}