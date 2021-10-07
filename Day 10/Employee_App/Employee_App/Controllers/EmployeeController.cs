using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Employee_App.Models;
namespace Employee_App.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeeController : ControllerBase, IDisposable

    {
        private readonly IUnitOfWork unitOfWork;

        public EmployeeController(IUnitOfWork unitOfWork)
        {
            this.unitOfWork = unitOfWork;
        }
        [HttpGet]
        public async Task<ActionResult> Get()
        {
            var employees = await unitOfWork.EmployeeRepository.Get();
          
            return Ok(employees);

        }
        [HttpPost]
        public async Task<ActionResult> PostEmployee(Employee model)
        {
            var departments = await unitOfWork.DepartmentRepository.Get(obj => obj.Id == model.DepartmentId);
            if (departments.Count() == 0)
            {
                return NotFound();
            }
            var department = departments.First();
            var employee = new Employee();
            employee.Name = model.Name;
            employee.Email = model.Email;
            employee.DepartmentId = department.Id;

            var dept = unitOfWork.DepartmentRepository.Update(department);
            var emp = unitOfWork.EmployeeRepository.Add(employee);

            await unitOfWork.CommitAsync();
            return Ok(emp);
        }

        public void Dispose()
        {
            unitOfWork.Dispose();
        }
    }
}
