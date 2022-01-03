using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using web_deploy_1.Models;

namespace web_deploy_1.Controllers
{
    public class CustomerController : Controller
    {
        // GET: Customer
        public ActionResult Index()
        {
            Customer cust1 = new Customer { cust_id = 2, cust_name = "Essam Nasser" };
            Customer cust2 = new Customer { cust_id = 12, cust_name = "Nibrass Mahdi" };
            Customer cust3 = new Customer { cust_id = 126, cust_name = "Jafer Essam Nasser" };
            Customer cust4 = new Customer { cust_id = 127, cust_name = "Aya Essam Nasser" };
            Customer cust5 = new Customer { cust_id = 128, cust_name = "Moh Essam Nasser" };


            List<Customer> Customers = new List<Customer>();
            Customers.Add(cust1); Customers.Add(cust2); Customers.Add(cust3);
            Customers.Add(cust4); Customers.Add(cust5);

            var vewresult = new ViewResult();

            return View(Customers);
        }
    }
}