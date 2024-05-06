namespace Room_Management_API.Application.Helper.DTOs.RoomsDTOs
{
    public class RoomFacilitiesDTO
    {
        public required string Name { get; set; }
        public required string Description { get; set; }
        public required bool IsAvailable { get; set; }
    }
    
    public class AddRoomFacilitiesDTO : RoomFacilitiesDTO
    {

    }

    public class FilterRoomFacilitiesDTO
    {
        public string Name { get; set; } = string.Empty;
        public bool IsAvailable { get; set; } = true;
    }

    public class UpdateRoomFacilitiesDTO
    {
        public required Guid Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;
        public bool IsAvailable { get; set; }
    }

    public class GetRoomFacilitiesDTO : RoomFacilitiesDTO
    {
        public Guid Id { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
        public DateTime DeletedAt { get; set; }
    }
}