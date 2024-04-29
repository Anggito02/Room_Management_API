namespace Room_Management_API.Domain.Users
{
    public class Roles
    {
        public Guid Id { get; set; }
        public required string RoleName { get; set; }

        // Navigation Properties
        public required ICollection<Users> Users { get; set; } 
    }
}