using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace EmployeeEntities.Entities
{
    public partial class Employee
    {
        public long EmployeeId { get; set; }
        public string EmployeeName { get; set; }
        public string EmployeeEmail { get; set; }
        public long Salary { get; set; }
        public int EmployeeAge { get; set; }
        public string City { get; set; }
        public bool IsAlive { get; set; }
        public bool? IsFresher { get; set; }
    }
}
