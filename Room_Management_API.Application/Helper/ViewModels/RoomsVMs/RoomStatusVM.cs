using Room_Management_API.Application.Helper.DTOs.RoomsDTOs;

namespace Room_Management_API.Application.Helper.ViewModels.RoomsVMs
{
    public class RoomStatusInputVM
    {
        public required RoomStatusInputDTO Data { get; set; }
    }

    public class RoomStatusResultVM
    {
        public List<RoomStatusResultDTO> Data { get; set; } = new List<RoomStatusResultDTO>();
    }
}