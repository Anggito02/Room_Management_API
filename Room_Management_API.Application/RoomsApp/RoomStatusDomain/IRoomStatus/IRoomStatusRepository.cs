using Room_Management_API.Domain.Rooms;

namespace Room_Management_API.Application.RoomsApp.RoomStatusDomain.IRoomStatus
{
    public interface IRoomStatusRepository
    {
        RoomStatus CreateRoomStatus(RoomStatus roomStatus);
        List<RoomStatus> GetAllRoomStatus();
        RoomStatus? GetRoomStatusById(Guid id);
        List<RoomStatus>? GetRoomStatusByName(string name);
        RoomStatus UpdateRoomStatus(RoomStatus roomStatus);
        bool DeleteRoomStatusById(Guid id);
        bool DeleteRoomStatusByName(string name);
    }
}