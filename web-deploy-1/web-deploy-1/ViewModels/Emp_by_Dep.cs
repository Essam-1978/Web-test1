using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using web_deploy_1.Models;

namespace web_deploy_1.ViewModels
{
    public class Emp_by_Dep
    {
        public Dep department { get; set; }
        public List<Employee> Employees { get; set; }
    }
}