namespace Room_Management_API.Domain.Users
{
    public class Users
    {
        public Guid Id { get; set; }
        public string Email { get; set; } = string.Empty;
        public string Password { get; set; } = string.Empty;
        public string IdentityNumber { get; set; } = string.Empty;
        public string FirstName { get; set; } = string.Empty;
        public string LastName { get; set; } = string.Empty;
        public string PhoneNumber { get; set; } = string.Empty;
        public string Address { get; set; } = string.Empty;
        public enum Gender { MALE, FEMALE };
        public string Photo { get; set; } = string.Empty;
        public string CreatedAt { get; set; } = string.Empty;
        public string UpdatedAt { get; set; } = string.Empty;
        public string DeletedAt { get; set; } = string.Empty;

        // Foreign Key
        public Guid RoleId { get; set; }
        public Guid DepartmentId { get; set; }
        public Guid StatusId { get; set; }

        public Roles Role { get; set; } = null!;
        public Departments Department { get; set; } = null!;
        public EmployeeStatus Status { get; set; } = null!;
    }
}