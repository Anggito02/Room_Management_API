namespace Room_Management_API.Domain
{
    public class Departments
    {
        public Guid Id { get; set; }
        public string DepartmentName { get; set; } = string.Empty;

        //Navigation Properties
        public ICollection<Users> Users { get; set; } = null!;
    }
}