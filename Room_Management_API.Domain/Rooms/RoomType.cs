namespace Room_Management_API.Domain.Rooms
{
    public class RoomType
    {
        public Guid Id { get; set; }
        public required string TypeName { get; set; }
        public DateTime CreatedAt { get; set; }

        // Navigation Properties
        public required ICollection<Rooms> Rooms { get; set; } 
    }
}