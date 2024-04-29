namespace Room_Management_API.Domain.Rooms
{
    public class RoomMedias : BaseModel
    { 
        public required string Path { get; set; }
        public required string AltText { get; set; }
        public int Width { get; set; }
        public int Height { get; set; }
        public int Size { get; set; }
        public enum Extension { JPG, PNG, JPEG, GIF }
        public required string Description { get; set; }

        // Navigation Properties
        public required IList<RoomMedia> RoomMedia { get; set; } 
    }
}