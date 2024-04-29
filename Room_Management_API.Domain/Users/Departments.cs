namespace Room_Management_API.Domain.Users
{
    public class Departments
    {
        public Guid Id { get; set; }
        public required string DepartmentName { get; set; }

        //Navigation Properties
        public required ICollection<Users> Users { get; set; } 
    }
}