using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModelMockup
{
    public class Company
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string PhoneNumber { get; set; }
        public string State { get; set; }
        public string PostalCode { get; set; }
        public string Location { get; set; }
        public Department Department { get; set; }
        public Guid DepartmentId { get; set; }
        public List<JobRoles> Jobroles { get; set; }
        public int MyProperty { get; set; }
        public bool IsActive { get; set; }
        public List<Employee> Employees { get; set; }

    }
    public class Department
    {
        public Guid Id { get; set; }
        public string Name { get; set; }

    }
    public class JobRoles
    {
        public Guid Id { get; set; }
    }

}
