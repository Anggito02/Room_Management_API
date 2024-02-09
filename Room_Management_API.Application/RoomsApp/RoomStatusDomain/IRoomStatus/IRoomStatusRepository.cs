using Room_Management_API.Application.Helper.DTOs.RoomsDTOs;
using Room_Management_API.Domain.Rooms;

namespace Room_Management_API.Application.RoomsApp.RoomStatusDomain.IRoomStatus
{
    public interface IRoomStatusRepository
    {
        RoomStatus CreateRoomStatus(RoomStatusInputDTO inputDTO);
        List<RoomStatus> GetAllRoomStatus();
        RoomStatus? GetRoomStatusByPkId(Guid id);
        List<RoomStatus>? GetRoomStatusByStatusName(string statusName);
    }
}