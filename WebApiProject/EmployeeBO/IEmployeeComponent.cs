using EmployeeEntities.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace EmployeeBO
{
    public interface IEmployeeComponent
    {
        List<Employee> GetEmployees();
        int AddEmployee(Employee model);
        int DeleteEmployee(int id);

        List<LoginDetails> GetUsers();
    }
}
