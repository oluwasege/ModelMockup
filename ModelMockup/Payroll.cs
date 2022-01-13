using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModelMockup
{
    public class Payroll
    {
        public Guid Id { get; set; }
        public DateTime From { get; set; }
        public DateTime To { get; set; }
        public decimal NoOfHours { get; set; }
        public decimal NoOfOvertimeHours { get; set; }
        public decimal AmountOfHours { get; set; }
        public decimal AmountOfOvertime { get; set; }
        public decimal GrossAmount { get; set; }
        public List<Employee> Employees { get; set; }
    }
}
