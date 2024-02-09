namespace Room_Management_API.Application.Helper.DTOs.RoomsDTOs
{
    public class RoomStatusDTO
    {
        public string StatusName { get; set; } = string.Empty;
    }

    public class RoomStatusInputDTO : RoomStatusDTO
    {

    }

    public class RoomStatusResultDTO : RoomStatusDTO
    {
        public Guid Id { get; set; }
        public DateTime CreatedAt { get; set; }
    }
}