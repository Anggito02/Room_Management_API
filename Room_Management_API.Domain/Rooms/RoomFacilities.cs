namespace Room_Management_API.Domain.Rooms
{
    public class RoomFacilities : BaseModel
    {
        public required string Name { get; set; }
        public required string Description { get; set; }
        public bool IsAvailable { get; set; }

        // Navigation Properties
        public required IList<RoomFacility> RoomFacility { get; set; } 
    }
}