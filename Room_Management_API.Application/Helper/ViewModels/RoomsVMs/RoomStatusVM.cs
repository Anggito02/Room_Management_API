using Room_Management_API.Application.Helper.DTOs.RoomsDTOs;

namespace Room_Management_API.Application.Helper.ViewModels.RoomsVMs
{
    public class RoomStatusInputVM
    {
        public RoomStatusInputDTO Data { get; set; } = new RoomStatusInputDTO();
    }

    public class RoomStatusResultVM
    {
        public List<RoomStatusResultDTO> Data { get; set; } = new List<RoomStatusResultDTO>();
    }
}