namespace Room_Management_API.Domain.Rooms
{
    public class RoomMedias
    {
        public Guid Id { get; set; }    
        public string Path { get; set; } = string.Empty;
        public string AltText { get; set; } = string.Empty;
        public int Width { get; set; }
        public int Height { get; set; }
        public int Size { get; set; }
        public enum Extension { JPG, PNG, JPEG, GIF }
        public string Description { get; set; } = string.Empty;
        public string CreatedAt { get; set; } = string.Empty;
        public string UpdatedAt { get; set; } = string.Empty;
        public string DeletedAt { get; set; } = string.Empty;

        // Navigation Properties
        public IList<RoomMedia> RoomMedia { get; set; } = null!;
    }
}