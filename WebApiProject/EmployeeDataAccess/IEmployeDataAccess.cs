using System;
using System.Collections.Generic;
using System.Text;
using EmployeeEntities.Custom;
using EmployeeEntities.Entities;

namespace EmployeeDO
{
    public interface IEmployeDataAccess
    {
        List<Employee> GetEmployees();
        int AddEmployee(Employee model);
        int DeleteEmployee(int id);
       List<LoginDetails> GetUsers();
    }
}
