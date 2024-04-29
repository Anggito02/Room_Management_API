using Room_Management_API.Application.Helper.DTOs.RoomsDTOs;
using Room_Management_API.Application.Helper.ViewModels.RoomsVMs;

namespace Room_Management_API.Application.RoomsApp.RoomFacilitiesDomain.IRoomFacilities
{
    public interface IRoomFacilitiesService
    {
        RoomFacilitiesResultVM CreateRoomFacilities(RoomFacilitiesInputVM inputVM);
        RoomFacilitiesResultVM GetAllRoomFacilities();
        RoomFacilitiesResultVM? GetRoomFacilitiesByPkId(Guid id);
        RoomFacilitiesResultVM GetRoomFacilitiesByName(string name);
        RoomFacilitiesResultVM UpdateRoomFacilities(RoomFacilitiesUpdateDTO updateDTO);
        bool DeleteRoomFacilitiesByPkId(Guid id);
        bool IsRoomFacilitiesAvailable(int id);
    }
}