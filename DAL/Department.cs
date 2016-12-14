using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    [Table("Department")]
    public class Department
    {
        public long Id { get; set; }
        public string Name { get; set; }

        public List<Employee> Employees { get; set; } 
    }
}
