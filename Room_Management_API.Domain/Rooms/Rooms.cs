namespace Room_Management_API.Domain.Rooms
{
    public class Rooms
    {
        public Guid Id { get; set; }
        public string RoomName { get; set; } = string.Empty;
        public string RoomNumber { get; set; } = string.Empty;
        public double RoomArea { get; set; }
        public int Capacity { get; set; }
        public bool IsAvailable { get; set; }
        public string Description { get; set; } = string.Empty;
        public string CreatedAt { get; set; } = string.Empty;
        public string UpdatedAt { get; set; } = string.Empty;
        public string DeletedAt { get; set; } = string.Empty;
        
        // Foreign Key
        public Guid RoomTypeId { get; set; }
        public Guid RoomStatusId { get; set; }

        // Navigation Properties
        public RoomType RoomType { get; set; } = null!;
        public RoomStatus RoomStatus { get; set; } = null!;
        public IList<RoomFacility> RoomFacility { get; set; } = null!;
    }
}