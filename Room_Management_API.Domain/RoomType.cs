namespace Room_Management_API.Domain
{
    public class RoomType
    {
        public Guid Id { get; set; }
        public string TypeName { get; set; } = string.Empty;

        // Navigation Properties
        public ICollection<Rooms> Rooms { get; set; } = null!;
    }
}