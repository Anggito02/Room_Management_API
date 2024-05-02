namespace Room_Management_API.Application.Helper.DTOs.RoomsDTOs
{
    public class RoomStatusDTO
    {
        public required string StatusName { get; set; }
    }

    public class AddRoomStatusDTO : RoomStatusDTO
    {

    }

    public class GetRoomStatusDTO : RoomStatusDTO
    {
        public Guid Id { get; set; }
        public DateTime CreatedAt { get; set; }
    }
}