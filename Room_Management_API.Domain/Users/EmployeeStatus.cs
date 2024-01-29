namespace Room_Management_API.Domain.Users
{
    public class EmployeeStatus
    {
        public Guid Id { get; set; }
        public string StatusName { get; set; } = string.Empty;

        // Navigation Properties
        public ICollection<Users> Users { get; set; } = null!;
    }
}