namespace Room_Management_API.Domain.Rooms
{
    public class RoomFacility
    {
        public Guid Id { get; set; }
        public int Amount { get; set; }

        // Foreign Key
        public Guid RoomId { get; set; }
        public Guid RoomFacilitiesId { get; set; }
    }
}