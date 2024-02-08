using Room_Management_API.Domain.Rooms;
using Room_Management_API.Application.RoomsApp.RoomStatusDomain.IRoomStatus;

namespace Room_Management_API.Application.RoomsApp.RoomStatusDomain
{
    public class RoomStatusService(
        IRoomStatusRepository roomStatusRepository
        ) : IRoomStatusService
    {
        private readonly IRoomStatusRepository _roomStatusRepository = roomStatusRepository;

        public RoomStatus CreateRoomStatus(RoomStatus roomStatus)
        {
            return _roomStatusRepository.CreateRoomStatus(roomStatus);
        }

        public List<RoomStatus> GetAllRoomStatus()
        {
            return _roomStatusRepository.GetAllRoomStatus();
        }

        public RoomStatus? GetRoomStatusByPkId(Guid id)
        {
            throw new NotImplementedException();
        }

        public List<RoomStatus>? GetRoomStatusByName(string name)
        {
            throw new NotImplementedException();
        }

        public RoomStatus UpdateRoomStatus(RoomStatus roomStatus)
        {
            throw new NotImplementedException();
        }

        public bool DeleteRoomStatusByPkId(Guid id)
        {
            throw new NotImplementedException();
        }

        public bool DeleteRoomStatusByName(string name)
        {
            throw new NotImplementedException();
        }
    }
}