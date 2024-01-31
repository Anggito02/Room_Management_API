namespace Room_Management_API.Domain.Rooms
{
    public class RoomFacilities
    {
        public Guid Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
        public DateTime DeletedAt { get; set; }

        // Navigation Properties
        public IList<RoomFacility> RoomFacility { get; set; } = null!;
    }
}