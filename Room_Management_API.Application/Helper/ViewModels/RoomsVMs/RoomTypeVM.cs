using Room_Management_API.Application.Helper.DTOs.RoomsDTOs;

namespace Room_Management_API.Application.Helper.ViewModels.RoomsVMs
{
    public class RoomTypeInputVM
    {
        public RoomTypeInputDTO Data { get; set; } = new RoomTypeInputDTO();
    }
    public class RoomTypeResultVM 
    {
        public List<RoomTypeResultDTO> Data { get; set; } = [];
    }
}