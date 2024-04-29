namespace Room_Management_API.Domain.Users
{
    public class Users
    {
        public Guid Id { get; set; }
        public required string Email { get; set; }
        public required string Password { get; set; }
        public required string IdentityNumber { get; set; }
        public required string FirstName { get; set; }
        public required string LastName { get; set; }
        public required string PhoneNumber { get; set; }
        public required string Address { get; set; }
        public enum Gender { MALE, FEMALE };
        public required string Photo { get; set; }
        public required string CreatedAt { get; set; }
        public required string UpdatedAt { get; set; }
        public required string DeletedAt { get; set; }

        // Foreign Key
        public Guid RoleId { get; set; }
        public Guid DepartmentId { get; set; }
        public Guid StatusId { get; set; }

        public required Roles Role { get; set; } 
        public required Departments Department { get; set; } 
        public required EmployeeStatus Status { get; set; } 
    }
}