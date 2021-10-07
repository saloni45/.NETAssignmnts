using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Employee_App.Models
{
    public interface IUnitOfWork : IDisposable
    {
        IRepository<Department> DepartmentRepository { get; }
        IRepository<Employee> EmployeeRepository { get; }
        Task<int> CommitAsync();
        
   
    }
}
