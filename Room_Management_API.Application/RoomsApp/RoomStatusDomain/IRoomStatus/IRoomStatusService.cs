using Room_Management_API.Application.Helper.ViewModels.RoomsVMs;

namespace Room_Management_API.Application.RoomsApp.RoomStatusDomain.IRoomStatus
{
    public interface IRoomStatusService
    {
        GetRoomStatusVM CreateRoomStatus(AddRoomStatusVM inputVM);
        GetRoomStatusVM GetAllRoomStatus();
        GetRoomStatusVM? GetRoomStatusByPkId(Guid id);
        GetRoomStatusVM? GetRoomStatusByStatusName(string statusName);
    }
}