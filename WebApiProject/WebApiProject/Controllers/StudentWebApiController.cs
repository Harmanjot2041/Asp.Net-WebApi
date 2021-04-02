using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using EmployeeBO;
using EmployeeEntities.Entities;
using Microsoft.AspNetCore.Authorization;

namespace WebApiProject.Controllers
{
    [ApiController]
    [Route("[controller]/[action]")]
    public class StudentWebApiController : ControllerBase
    {
        private readonly IEmployeeComponent _employeeComponent;
        
        public StudentWebApiController(IEmployeeComponent employeeComponent)
        {
            _employeeComponent = employeeComponent;
        }
        
        [HttpGet]
        [Authorize(Roles ="Admin")]
        public IActionResult GetEmployee()
        {
            var EmployeeList = _employeeComponent.GetEmployees();
            return Ok(EmployeeList);
        }
        [HttpPost]
        public IActionResult AddEmployee(Employee  model)
        {
            var result = _employeeComponent.AddEmployee(model);
            if(result > 0)
                return Ok("Employee Added Succesfully..");
            
            return Ok("Employee Not Added Succesfully..");

        }
        [HttpDelete]
        public IActionResult DeleteEmployee(int Id)
        {
            var result = _employeeComponent.DeleteEmployee(Id);
            if (result > 0) 
                return Ok("Employee Deleted Successfully..");
            return Ok("Employee Not Deleted Succesfully..");
        }

        
    }
}