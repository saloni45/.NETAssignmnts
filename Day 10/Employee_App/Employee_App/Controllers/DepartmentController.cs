using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Employee_App.Models;

namespace Employee_App.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DepartmentController : ControllerBase , IDisposable
    {
        private readonly IRepository<Department> departmentRepository;
        private readonly IRepository<Employee> employeeRepository;

        public DepartmentController(IRepository<Department> departmentRepository, IRepository<Employee> employeeRepository)
        {
            this.departmentRepository = departmentRepository;
            this.employeeRepository = employeeRepository;
        }

        public void Dispose()
        {
            departmentRepository.Dispose();
            employeeRepository.Dispose();
        }
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Department>>> Get()
        {
            var departments = await departmentRepository.Get(includes: "Employees");
            return Ok(departments);
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<Department>> Get(int id)
        {
            var departments = await departmentRepository.Get(dept => dept.Id==id, "Employees");
            if (departments.Count() == 0)
            {
                return NotFound();
            }
            return Ok(departments.First());
        }

        [HttpPost]
        public async Task<ActionResult> Post([FromBody] Department model) 
        {
            var department = departmentRepository.Add(model);
            await departmentRepository.Commit();
            return CreatedAtAction("Get", new { id = department.Id }, department);
        }

        [HttpPut]
        public async Task<ActionResult> Put([FromBody] Department model) 
        {
            
            var department = departmentRepository.Update(model);
            await departmentRepository.Commit();
            return Ok(department);
        }
        [HttpDelete("{id}")]
        public async Task<ActionResult> Delete(int id)
        {
            var departments = await departmentRepository.Get(obj => obj.Id == id, "Employees");
            if (departments.Count() == 0)
            {
                return NotFound();
            }
            var department = departmentRepository.Delete(departments.First());
            await departmentRepository.Commit();
            return NoContent();
        }
    }
}
