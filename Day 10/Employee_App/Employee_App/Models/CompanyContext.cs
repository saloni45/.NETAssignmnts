using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace Employee_App.Models
{
    public class CompanyContext : DbContext
    {
        public CompanyContext(DbContextOptions options) : base(options)
        {

        }
        public virtual DbSet<Employee> employees { get; set; }
        public virtual DbSet<Department> departments { get; set; }

    }
}
