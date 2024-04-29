namespace Room_Management_API.Application.Helper.DTOs.RoomsDTOs
{
    public class RoomFacilitiesDTO
    {
        public required string Name { get; set; }
        public required string Description { get; set; }
        public bool IsAvailable { get; set; }
    }
    
    public class RoomFacilitiesInputDTO : RoomFacilitiesDTO
    {

    }

    public class RoomFacilitiesResultDTO : RoomFacilitiesDTO
    {
        public Guid Id { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
        public DateTime DeletedAt { get; set; }
    }

    public class RoomFacilitiesUpdateDTO : RoomFacilitiesDTO
    {
        public Guid Id { get; set; }
    }
}