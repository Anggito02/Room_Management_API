namespace Room_Management_API.Domain.Rooms
{
    public class RoomMedia
    {
        public Guid Id { get; set; }

        // Foreign Key
        public Guid RoomId { get; set; }
        public Guid RoomMediasId { get; set; }

        // Navigation Property
        public Rooms Room { get; set; } = null!;
        public RoomMedias RoomMedias { get; set; } = null!;
    }
}