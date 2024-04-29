namespace Room_Management_API.Application.Helper.DTOs.RoomsDTOs
{
    public class RoomTypeDTO
    {
        public required string TypeName { get; set; }
    }

    public class RoomTypeInputDTO : RoomTypeDTO
    {
        
    }

    public class RoomTypeResultDTO : RoomTypeDTO
    {
        public Guid Id { get; set; }
        public DateTime CreatedAt { get; set; }
    }
}