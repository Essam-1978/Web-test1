using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Business.Helpers;
using DataAccess;

namespace Business.Operations
{
    public class Employee_Operations : IEmp
    {


        essamDatabaseEntities1 Dbase = new essamDatabaseEntities1();

        


        public int CreateNew(Employee emp)
        {

            Dbase.Employees.Add(emp);
            int row = Dbase.SaveChanges();
            return row;


        }

        public int DeleteEmp(Employee emp)
        {

            Employee ee = Dbase.Employees.Find(emp.Id);
            Dbase.Employees.Remove(ee);
            return Dbase.SaveChanges();


        }

        public List<Employee> GetAllEmployees()
        {
            return Dbase.Employees.ToList();

        }

        public List<Employee> SearchByName(string name)
        {

            var emps = from emp in Dbase.Employees where emp.Name.Contains(name)
                       select emp
                       ;
            return emps.ToList();
     


        }

        public int UpdateEmp(Employee emp)
        {

            Employee ee = Dbase.Employees.Find(emp.Id);
            ee.Name = emp.Name;
            return Dbase.SaveChanges();

        }
    }
}
