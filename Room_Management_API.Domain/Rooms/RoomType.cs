namespace Room_Management_API.Domain.Rooms
{
    public class RoomType
    {
        public Guid Id { get; set; }
        public string TypeName { get; set; } = string.Empty;
        public DateTime CreatedAt { get; set; }

        // Navigation Properties
        public ICollection<Rooms> Rooms { get; set; } = null!;
    }
}