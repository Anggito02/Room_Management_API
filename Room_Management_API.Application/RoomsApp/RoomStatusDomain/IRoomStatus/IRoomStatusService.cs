using Room_Management_API.Application.Helper.ViewModels.RoomsVMs;

namespace Room_Management_API.Application.RoomsApp.RoomStatusDomain.IRoomStatus
{
    public interface IRoomStatusService
    {
        RoomStatusResultVM CreateRoomStatus(RoomStatusInputVM inputVM);
        RoomStatusResultVM GetAllRoomStatus();
        RoomStatusResultVM? GetRoomStatusByPkId(Guid id);
        RoomStatusResultVM? GetRoomStatusByStatusName(string statusName);
    }
}