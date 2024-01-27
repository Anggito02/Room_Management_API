namespace Room_Management_API.Domain
{
    public class RoomFacilities
    {
        public Guid Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;
        public string CreatedAt { get; set; } = string.Empty;
        public string UpdatedAt { get; set; } = string.Empty;
        public string DeletedAt { get; set; } = string.Empty;

        // Navigation Properties
        public IList<RoomFacility> RoomFacility { get; set; } = null!;
    }
}