using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Employee_App.Models
{
    public class Employee
    {
        public int id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public int DepartmentId { get; set; }
        public virtual Department Department { get; set; }
    }
}
