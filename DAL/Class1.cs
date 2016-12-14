using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class DataRepository
    {
        public List<Department> GetDepartments()
        {
            EmployeeContext context = new EmployeeContext();
            return context.Departments.Include("Employees").ToList();
        }
    }


}
