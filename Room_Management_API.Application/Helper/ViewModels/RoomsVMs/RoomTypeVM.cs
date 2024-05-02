using Room_Management_API.Application.Helper.DTOs.RoomsDTOs;

namespace Room_Management_API.Application.Helper.ViewModels.RoomsVMs
{
    public class RoomTypeInputVM
    {
        public required AddRoomTypeDTO Data { get; set; }
    }
    public class RoomTypeResultVM
    {
        public List<GetRoomTypeDTO> Data { get; set; } = new List<GetRoomTypeDTO>();
        public int StatusCode { get; set; }
        public string Message { get; set; } = string.Empty;
    }
}