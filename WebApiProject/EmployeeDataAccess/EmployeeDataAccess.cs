using EmployeeEntities.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EmployeeDO
{
    public class EmployeeDataAccess:IEmployeDataAccess
    {
        private readonly EmployeeDbContext _employeeDbContext;
        public EmployeeDataAccess(EmployeeDbContext employeeDbContext)
        {
            _employeeDbContext = employeeDbContext;
        }

        public int AddEmployee(Employee model)
        {
            _employeeDbContext.Employee.Add(model);
            return _employeeDbContext.SaveChanges();

        }

        public int DeleteEmployee(int id)
        {
            Employee temp = _employeeDbContext.Employee.FirstOrDefault(Employees => Employees.EmployeeId== id);
            _employeeDbContext.Employee.Remove(temp);
            return _employeeDbContext.SaveChanges();
        }

        public List<Employee> GetEmployees()
        {
            return _employeeDbContext.Employee.ToList();
        }
    }
}
