namespace Room_Management_API.Domain.Rooms
{
    public class Rooms : BaseModel
    {
        public required string RoomName { get; set; }
        public required string RoomNumber { get; set; }
        public decimal RoomArea { get; set; }
        public int Capacity { get; set; }
        public bool IsAvailable { get; set; }
        public required string Description { get; set; }
        
        // Foreign Key
        public Guid RoomTypeId { get; set; }
        public Guid RoomStatusId { get; set; }

        // Navigation Properties
        public required RoomType RoomType { get; set; } 
        public required RoomStatus RoomStatus { get; set; } 
        public required IList<RoomFacility> RoomFacility { get; set; } 
        public required IList<RoomMedia> RoomMedia { get; set; } 
    }
}