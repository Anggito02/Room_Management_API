using Room_Management_API.Application.Helper.DTOs.RoomsDTOs;

namespace Room_Management_API.Application.Helper.ViewModels.RoomsVMs
{
    public class RoomTypeInputVM
    {
        public required RoomTypeInputDTO Data { get; set; }
    }
    public class RoomTypeResultVM 
    {
        public List<RoomTypeResultDTO> Data { get; set; } = new List<RoomTypeResultDTO>();
    }
}