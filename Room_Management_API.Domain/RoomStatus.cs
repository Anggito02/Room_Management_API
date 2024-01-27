namespace Room_Management_API.Domain
{
    public class RoomStatus
    {
        public Guid Id { get; set; }
        public string StatusName { get; set; } = string.Empty;

        // Navigation Properties
        public ICollection<Rooms> Rooms { get; set; } = null!;
    }
}