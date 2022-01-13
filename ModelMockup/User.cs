using System;

namespace ModelMockup
{
    public class User
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string FirstName { get; set; }
        public string UserName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string  PhoneNumber { get; set; }
        public bool IsActive { get; set; }
        public DateTime DateJoined { get; set; }
        public UserType UserType { get; set; }
       // public Guid RoleId { get; set; }
       // public Role Role { get; set; }
    }

    public enum Gender
    {
        Male,Female
    }

    public enum Status
    {
        Active,Inactive
    }

    public class Role
    {
        public Guid Id { get; set; }
        public UserType UserType { get; set; }
        public RoleType RoleType { get; set; }
        public Guid RoleTypeId { get; set; }

    }
    public enum UserType
    {
        SuperAdmin,Admin,Employee
    }
    public class RoleType
    {
        public Guid Id { get; set; }
    }
}
