using Room_Management_API.Application.Helper.DTOs.RoomsDTOs;
using Room_Management_API.Domain.Rooms;

namespace Room_Management_API.Application.RoomsApp.RoomFacilitiesDomain.IRoomFacilities
{
    public interface IRoomFacilitiesRepository
    {
        RoomFacilities CreateRoomFacilities(RoomFacilitiesInputDTO inputDTO);
        List<RoomFacilities> GetAllRoomFacilities();
        RoomFacilities GetRoomFacilitiesByPkId(int pkId);
        RoomFacilities GetRoomFacilitiesByName(string name);
        bool IsRoomFacilitiesAvailable(string name);
        RoomFacilities UpdateRoomFacilities(RoomFacilitiesUpdateDTO updateDTO);
        bool DeleteRoomFacilitiesByPkId(int pkId);
    }
}