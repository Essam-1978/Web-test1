using DataAccess;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;




namespace Business.Helpers
{
    interface IEmp
    {
        int CreateNew(Employee emp);

        int UpdateEmp(Employee emp);

        int DeleteEmp(Employee emp);

        List<Employee> GetAllEmployees();

        List<Employee> SearchByName(string name);





    }
}
