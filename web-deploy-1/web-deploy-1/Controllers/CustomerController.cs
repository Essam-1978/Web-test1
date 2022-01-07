using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;

using System.Web;
using System.Web.Mvc;
using web_deploy_1.Models;
using web_deploy_1.ViewModels;
using System.Data.Entity;


namespace web_deploy_1.Controllers
{
    public class CustomerController : Controller
    {
        // GET: Customer
        public ActionResult Index()
        {
            Customer cust1 = new Customer { Id = 2, Name = "Essam Nasser" };
            Customer cust2 = new Customer { Id = 12, Name = "Nibrass Mahdi" };
            Customer cust3 = new Customer { Id = 126, Name = "Jafer Essam Nasser" };
            Customer cust4 = new Customer { Id = 127, Name = "Aya Essam Nasser" };
            Customer cust5 = new Customer { Id = 128, Name = "Moh Essam Nasser" };


            List<Customer> Customers = new List<Customer>();
            Customers.Add(cust1); Customers.Add(cust2); Customers.Add(cust3);
            Customers.Add(cust4); Customers.Add(cust5);

           // var vewresult = new ViewResult();

            return View(Customers);
        }


        ApplicationDbContext Dbase = new ApplicationDbContext();



        public ActionResult return_Db_all()
        {
            var customers = Dbase.Customers.Include(p => p.MemberShipType).ToList();
            

            return View(customers);
        }

        public ActionResult return_Db_Single()
        {
            
            var customer = Dbase.Customers.Include(p=>p.MemberShipType).SingleOrDefault(p => p.Id == 2);
            ViewResult M = new ViewResult();
            return View(customer);
        }

        public ActionResult Details_cus(int cust)
        {
            
            var Cust = Dbase.Customers.Include(p=>p.MemberShipType).SingleOrDefault(p => p.Id == cust);
            //Customer Cust = cust;
            //Customer cust = Dbase.Customers.Where(p => p.Id == id).Select(p => p); 
            return View(Cust);
        }


        public ActionResult create_cust_form()
        {

            var membershiptypes = Dbase.MemberShipTypes.ToList();
            var Cut_By_MemberShipType = new Cust_by_MemberShip();

            Cut_By_MemberShipType.MemberShipTypes = membershiptypes;
            Cut_By_MemberShipType.Customer = new Customer();



            return View(Cut_By_MemberShipType);
        }
        
        [HttpPost]
        public ActionResult create_cust(Cust_by_MemberShip cust)
        {

            if (!ModelState.IsValid)
            {
                var viewmodel = new Cust_by_MemberShip();
                viewmodel.Customer = cust.Customer;
                viewmodel.MemberShipTypes = Dbase.MemberShipTypes.ToList();

                
                return View("create_cust_form", viewmodel);
            }

            // check by debugg the http request and response
            // in Chrome and in here (cursor the variable cust)
            Customer yy = cust.Customer;
            Dbase.Customers.Add(yy);
             Dbase.SaveChanges();
            return RedirectToAction("return_Db_all", "Customer");

        }

        public ActionResult delet_cust(int id)
        {
            var cust = Dbase.Customers.SingleOrDefault(p => p.Id == id);
            Dbase.Customers.Remove(cust);
            Dbase.SaveChanges();
            return RedirectToAction("return_Db_all", "Customer");
        }

        public ActionResult edit_cust(int id)
        {

            var Customer = Dbase.Customers.SingleOrDefault(p => p.Id == id);
            if (Customer == null) return HttpNotFound();

            var membershiptypes = Dbase.MemberShipTypes.ToList();
            var Cut_By_MemberShipType = new Cust_by_MemberShip();

            Cut_By_MemberShipType.MemberShipTypes = membershiptypes;
            Cut_By_MemberShipType.Customer = Customer;



            return View("edit_form",Cut_By_MemberShipType);
        }



       public ActionResult update_cust(Cust_by_MemberShip cust2)
        {
            Customer yy = cust2.Customer;
            var cust_to_update = Dbase.Customers.Single(p => p.Id == yy.Id);
            cust_to_update.Name = yy.Name;
            cust_to_update.IsSubscribeToNewsLetter = yy.IsSubscribeToNewsLetter;
            cust_to_update.MemberShipTypeId = yy.MemberShipTypeId;

            //Dbase.Customers.Add(cust_to_update);
            Dbase.SaveChanges();
            return RedirectToAction("return_Db_all", "Customer");

        }



    }
}