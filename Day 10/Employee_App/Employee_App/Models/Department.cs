using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Employee_App.Models
{
    public class Department
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int TotalEmployees { get; set; }

        public virtual ICollection<Employee> Employees { get; set; }
    }
}
