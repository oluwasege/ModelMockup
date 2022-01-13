using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModelMockup
{
    public class TimeSheet
    {
        public Guid Id { get; set; }
        public Department Department { get; set; }
        public Guid DepartmentId { get; set; }
        public DateTime ClockIn { get; set; }
        public DateTime ClockOut { get; set; }

        public DateTime UpdatedClockIn { get; set; }
        public DateTime UpdatedClockOut { get; set; }
        public DateTime Date { get; set; }
        public Employee Employee { get; set; }
        public Guid EmployeeId { get; set; }
        public int MyProperty { get; set; }
        public string JobTitle { get; set; }
        public DateTime OvertimeHours { get; set; }
        public DateTime HoursSpent { get; set; }
    }
}
