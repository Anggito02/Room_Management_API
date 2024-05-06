using Room_Management_API.Application.Helper.ViewModels.RoomsVMs;

namespace Room_Management_API.Application.RoomsApp.RoomFacilitiesDomain.IRoomFacilities
{
    public interface IRoomFacilitiesService
    {
        GetRoomFacilitiesVM CreateRoomFacilities(AddRoomFacilitiesVM inputVM);
        List<GetRoomFacilitiesVM> GetAllRoomFacilities(FilterRoomFacilitiesVM filterVM);
        GetRoomFacilitiesVM? GetRoomFacilitiesByPkId(Guid id);
        GetRoomFacilitiesVM UpdateRoomFacilities(UpdateRoomFacilitiesVM updateDTO);
        GetRoomFacilitiesVM DeleteRoomFacilitiesByPkId(Guid id);
    }
}