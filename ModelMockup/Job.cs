using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModelMockup
{
    public class Job
    {
        public Guid Id { get; set; }
        public int MyProperty { get; set; }
        public Company Company { get; set; }
        public Guid CompanyId { get; set; }
        public string Location { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public DateTime StartTime { get; set; }
        public DateTime EndTime { get; set; }
        public decimal HourlyRate { get; set; }
        public decimal OvertimeRate { get; set; }
        public List<Employee> Employees { get; set; }
        public string Description { get; set; }

    }
}
