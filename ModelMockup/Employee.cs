using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModelMockup
{
    public class Employee
    {
        public User User { get; set; }
        public Guid UserId { get; set; }
        public string EmployeeOfficeID { get; set; }
        public DateTime DateOfBirth { get; set; }
        public string Location { get; set; }
        public Guid Id  { get; set; }
        public BankInformation BankInformation { get; set; }
        public Guid BankInformationId { get; set; }
        public NextOfKin NextOfKin { get; set; }
        public Guid NextOfKinId { get; set; }
        public List<TimeSheet> TimeSheets { get; set; }
        public List<Company> Company { get; set; }
    }
    public class BankInformation
    {
        public Guid Id { get; set; }
        public string AccountName { get; set; }
        public string AccountNumber { get; set; }
        public string BankName { get; set; }
    }
    public class NextOfKin
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public Relationship Relationship { get; set; }
        public Gender Gender { get; set; }
        public string Email { get; set; }
        public string Address { get; set; }
    }

    public enum Relationship
    {
        Brother,Sister,Father,Mother,Child,Other
    }
}
