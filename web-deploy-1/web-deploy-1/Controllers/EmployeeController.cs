using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using web_deploy_1.Models;
using web_deploy_1.ViewModels;

namespace web_deploy_1.Controllers
{
    public class EmployeeController : Controller
    {
        // GET: Employee
        public ActionResult Index()
        {
            var essam = new Models.Employee();
            essam.emp_id = 654;
            essam.emp_name = "EssamNasser";

            ViewData["Score"] ="Good";
            return View(essam);
        }

        public ActionResult About()
        {
            //ViewData["MyName"] = "LOLO";
            //ViewData["MyScore"] = 34;


            return View();

        }


        public ActionResult our_service()
        {
            return View();
        }


        public ActionResult return_text()
        {
            return Content("This is just text");
            //return HttpNotFound();
            //return EmptyResult();
            //return RedirectToAction("Action Name","Controller Name",new{page=1,sortBy="Name"});
                
        }
        public ActionResult dummy1()
        {
            return RedirectToAction("return_text", "Employess", new { page = 1, sortBy = "Name" });

        } 
        
        public ActionResult edit_t(int id)
        {
            // use the link http://localhost/Employee/edit_t/5
            return Content("Id id :" + id);
        }

        public ActionResult edit_R(string V)
        {
            //Use http://localhost/Employee/edit_R/essam  ==dont work
            // OR http://localhost/employee/edit_R?V=essam
            return Content(V);
        }


        public ActionResult List_emp(int? pageIndex,string SortName)
        {
            if (!pageIndex.HasValue) { pageIndex = 1; }
            if (String.IsNullOrWhiteSpace(SortName)) { SortName = "name"; }

            return Content(String.Format("PageIndex{0} SortNAme{1}",pageIndex, SortName));
        }



        public ActionResult send_data()
        {
            ViewData["name"] = "Essam Mohamady";
            ViewData["id"] = 232323;
            ViewData["Age"] = 23;

            return View();
        }




        public ActionResult list_employee()
        {
           Employee emp1 = new Employee() {emp_id=2323,emp_name="Essam Nasser" };
            Employee emp2 = new Employee() { emp_id = 232, emp_name = "Nibrass Mahdi" };
            Employee emp3 = new Employee() { emp_id = 4343, emp_name = "Jafer Essam Nasser" };
            Employee emp4 = new Employee() { emp_id = 7623, emp_name = "Aya and Mohammed" };

            var Emps = new List<Employee>();
            Emps.Add(emp1); Emps.Add(emp3); Emps.Add(emp3); Emps.Add(emp4);

            return View(Emps); 
            
        }


        public ActionResult return_emp_obj()
        {

            var M = new Employee() { emp_id = 898, emp_name = "Returne 1 object" };
            
            return View(M);
        }



        public ActionResult return_two_objects()
        {


            Employee emp1 = new Employee() { emp_id = 2323, emp_name = "Essam Nasser" };
            Employee emp2 = new Employee() { emp_id = 232, emp_name = "Nibrass Mahdi" };
            Employee emp3 = new Employee() { emp_id = 4343, emp_name = "Jafer Essam Nasser" };
            Employee emp4 = new Employee() { emp_id = 7623, emp_name = "Aya and Mohammed" };


            var Emps = new List<Employee>();
            Emps.Add(emp1); Emps.Add(emp3); Emps.Add(emp3); Emps.Add(emp4);


            Dep dep1 = new Dep() { dep_id = 12, dep_name = "Information" };


            Emp_by_Dep Obj = new Emp_by_Dep();
            Obj.department = dep1;
            Obj.Employees = Emps;


            return View(Obj);
        }


    }
}