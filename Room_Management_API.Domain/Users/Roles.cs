namespace Room_Management_API.Domain.Users
{
    public class Roles
    {
        public Guid Id { get; set; }
        public string RoleName { get; set; } = string.Empty;

        // Navigation Properties
        public ICollection<Users> Users { get; set; } = null!;
    }
}