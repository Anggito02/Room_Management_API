using Room_Management_API.Application.Helper.DTOs.RoomsDTOs;
using Room_Management_API.Domain.Rooms;

namespace Room_Management_API.Application.RoomsApp.RoomFacilitiesDomain.IRoomFacilities
{
    public interface IRoomFacilitiesRepository
    {
        RoomFacilities CreateRoomFacilities(AddRoomFacilitiesDTO inputDTO);
        List<RoomFacilities> GetAllRoomFacilities(FilterRoomFacilitiesDTO filterDTO);
        RoomFacilities? GetRoomFacilitiesByPkId(Guid id);
        RoomFacilities UpdateRoomFacilities(UpdateRoomFacilitiesDTO updateDTO);
        bool DeleteRoomFacilitiesByPkId(Guid pkId);
    }
}