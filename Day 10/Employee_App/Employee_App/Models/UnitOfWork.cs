using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Employee_App.Models
{
    public class UnitOfWork : IUnitOfWork

    {
        private readonly CompanyContext companyContext;
        private readonly IRepository<Department> departmentRepository;

        private readonly IRepository<Employee> employeeRepository;

        public UnitOfWork(CompanyContext companyContext)
        {
            this.companyContext = companyContext;
            departmentRepository = new GenericRepository<Department>(this.companyContext);
            employeeRepository = new GenericRepository<Employee>(this.companyContext);
        }

        public IRepository<Department> DepartmentRepository { get { return departmentRepository; } }
        public IRepository<Employee> EmployeeRepository { get { return employeeRepository; } }
        public void Dispose()
        {
            companyContext.Dispose();
        }


        public async Task<int> CommitAsync()
        {
            return await companyContext.SaveChangesAsync();
        }
        
    }
}
