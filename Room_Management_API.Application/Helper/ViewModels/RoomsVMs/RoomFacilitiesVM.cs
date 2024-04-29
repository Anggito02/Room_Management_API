using Room_Management_API.Application.Helper.DTOs.RoomsDTOs;

namespace Room_Management_API.Application.Helper.ViewModels.RoomsVMs
{
    public class RoomFacilitiesInputVM
    {
        public required RoomFacilitiesInputDTO Data { get; set;}
    }

    public class RoomFacilitiesResultVM
    {
        public List<RoomFacilitiesResultDTO> Data { get; set;}= new List<RoomFacilitiesResultDTO>();
    }
}