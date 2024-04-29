namespace Room_Management_API.Domain.Users
{
    public class EmployeeStatus
    {
        public Guid Id { get; set; }
        public required string StatusName { get; set; }

        // Navigation Properties
        public required ICollection<Users> Users { get; set; } 
    }
}