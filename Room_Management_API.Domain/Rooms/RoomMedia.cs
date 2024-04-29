namespace Room_Management_API.Domain.Rooms
{
    public class RoomMedia
    {
        public Guid Id { get; set; }

        // Foreign Key
        public Guid RoomId { get; set; }
        public Guid RoomMediasId { get; set; }

        // Navigation Property
        public required Rooms Room { get; set; } 
        public required RoomMedias RoomMedias { get; set; } 
    }
}