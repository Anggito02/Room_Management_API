using Room_Management_API.Domain.Rooms;
using Room_Management_API.Application.RoomsApp.RoomStatusDomain.IRoomStatus;

namespace Room_Management_API.Infrastructure.RoomsInfrastructure.RoomStatusInf
{
    public class RoomStatusRepository(
            RoomsDbContext roomManagementDbContext
        ) : IRoomStatusRepository
    {
        private readonly RoomsDbContext _roomManagementDbContext = roomManagementDbContext;

        public RoomStatus CreateRoomStatus(RoomStatus roomStatus)
        {
            _roomManagementDbContext.ROOM_STATUS.Add(roomStatus);
            _roomManagementDbContext.SaveChanges();

            return roomStatus;
        }

        public List<RoomStatus> GetAllRoomStatus()
        {
            return _roomManagementDbContext.ROOM_STATUS.ToList();
        }

        public RoomStatus? GetRoomStatusById(Guid id)
        {
            return _roomManagementDbContext.ROOM_STATUS.Find(id);
        }

        public List<RoomStatus> GetRoomStatusByName(string name)
        {
            return _roomManagementDbContext.ROOM_STATUS.Where(t => t.StatusName == name).ToList();
        }

        public RoomStatus UpdateRoomStatus(RoomStatus roomStatus)
        {
            return _roomManagementDbContext.ROOM_STATUS.Update(roomStatus).Entity;
        }

        public bool DeleteRoomStatusById(Guid id)
        {
            return _roomManagementDbContext.ROOM_STATUS.Remove(new RoomStatus { Id = id }).Entity != null;
        }

        public bool DeleteRoomStatusByName(string name)
        {
            return _roomManagementDbContext.ROOM_STATUS.Remove(new RoomStatus { StatusName = name }).Entity != null;
        }
    }
}
