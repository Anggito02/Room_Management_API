namespace Room_Management_API.Domain.Rooms
{
    public class Rooms : BaseEntity
    {
        public Guid Id { get; set; }
        public string RoomName { get; set; } = string.Empty;
        public string RoomNumber { get; set; } = string.Empty;
        public decimal RoomArea { get; set; }
        public int Capacity { get; set; }
        public bool IsAvailable { get; set; }
        public string Description { get; set; } = string.Empty;
        
        // Foreign Key
        public Guid RoomTypeId { get; set; }
        public Guid RoomStatusId { get; set; }

        // Navigation Properties
        public RoomType RoomType { get; set; } = null!;
        public RoomStatus RoomStatus { get; set; } = null!;
        public IList<RoomFacility> RoomFacility { get; set; } = null!;
        public IList<RoomMedia> RoomMedia { get; set; } = null!;
    }

    public class BaseEntity {
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
        public DateTime DeletedAt { get; set; }
    }
}