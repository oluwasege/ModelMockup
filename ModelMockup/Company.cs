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
        public List<Department> Departments { get; set; }
        public Guid DepartmentId { get; set; }
        public JobRole Jobrole { get; set; }
        public Guid JobRoleId { get; set; }
        public bool IsActive { get; set; }
        public List<Employee> Employees { get; set; }

    }
    public class Department
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public Company Company { get; set; }
        public Guid CompanyId { get; set; }

    }
    public class JobRole
    {
        public Guid Id { get; set; }
        public string Name { get; set; }

    }

}
