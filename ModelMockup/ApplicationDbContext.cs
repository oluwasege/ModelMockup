using Microsoft.EntityFrameworkCore;

namespace ModelMockup
{
    public class ApplicationDbContext:DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {

        }
        public DbSet<User> Users { get; set; }
        public DbSet<Employee> Employees { get; set; }
        public DbSet<Job> Jobs { get; set; }
        public DbSet<TimeSheet> TimeSheets { get; set; }
        public DbSet<Notification> Notifications { get; set; }
        public DbSet<Company> Companies { get; set; }
        public DbSet<Role> Role { get; set; }
        public DbSet<RoleType> RoleTypes { get; set; }
        public DbSet<Department> Departments { get; set; }
        public DbSet<BankInformation> BankInformations { get; set; }
        public DbSet<NextOfKin> NextOfKins { get; set; }
        public DbSet<Payroll> Payrolls { get; set; }

    }
}
