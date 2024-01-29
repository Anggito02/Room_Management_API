namespace Room_Management_API.Domain.Rooms
{
    public class RoomMedia
    {
        public Guid Id { get; set; }
        public int Amount { get; set; }

        // Foreign Key
        public Guid RoomId { get; set; }
        public Guid FacilityId { get; set; }
        public Rooms Room { get; set; } = null!;
        public RoomFacilities RoomFacilities { get; set; } = null!;
    }
}