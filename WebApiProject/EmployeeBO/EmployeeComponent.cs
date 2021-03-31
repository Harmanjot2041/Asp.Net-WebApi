using System;
using System.Collections.Generic;
using System.Text;
using EmployeeDO;
using EmployeeEntities.Entities;

namespace EmployeeBO
{
    public class EmployeeComponent:IEmployeeComponent
    {
        private readonly IEmployeDataAccess _employeeDataAccess;
        public EmployeeComponent(IEmployeDataAccess employeeDataAccess)
        {
            _employeeDataAccess = employeeDataAccess;
        }

        public int AddEmployee(Employee model)
        {
            return _employeeDataAccess.AddEmployee(model);
        }

        public int DeleteEmployee(int id)
        {
            return _employeeDataAccess.DeleteEmployee(id);
        }

        public List<Employee> GetEmployees()
        {
            return _employeeDataAccess.GetEmployees();
        }

    }
}
