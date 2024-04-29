namespace Room_Management_API.Domain.Rooms
{
    public class RoomStatus
    {
        public Guid Id { get; set; }
        public required string StatusName { get; set; }
        public DateTime CreatedAt { get; set; }

        // Navigation Properties
        public required ICollection<Rooms> Rooms { get; set; } 
    }
}