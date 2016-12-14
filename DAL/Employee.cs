using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    [Table("Employee")]
    public class Employee
    {
        public long Id { get; set; }
        public string Name { get; set; }
        public decimal Salary { get; set; }
        public string Gender { get; set; }

        public long DepartmentId { get; set; }

        [ForeignKey("DepartmentId")]
        public Department Department { get; set; }
    }
}
