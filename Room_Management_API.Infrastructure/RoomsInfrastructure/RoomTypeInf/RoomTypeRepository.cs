using Room_Management_API.Domain.Rooms;
using Room_Management_API.Application.RoomsApp.RoomTypeDomain.IRoomType;

namespace Room_Management_API.Infrastructure.RoomsInfrastructure.RoomTypeInf
{
    public class RoomTypeRepository(
            RoomsDbContext roomManagementDbContext
        ) : IRoomTypeRepository
    {
        private readonly RoomsDbContext _roomManagementDbContext = roomManagementDbContext;

        public RoomType CreateRoomType(RoomType roomType)
        {
            _roomManagementDbContext.ROOM_TYPE.Add(roomType);
            _roomManagementDbContext.SaveChanges();

            return roomType;
        }

        public List<RoomType> GetAllRoomTypes()
        {
            return _roomManagementDbContext.ROOM_TYPE.ToList();
        }

        public RoomType? GetRoomTypeById(Guid id)
        {
            return _roomManagementDbContext.ROOM_TYPE.Find(id);
        }

        public List<RoomType> GetRoomTypeByName(string name)
        {
            return _roomManagementDbContext.ROOM_TYPE.Where(t => t.TypeName == name).ToList();
        }

        public RoomType UpdateRoomType(RoomType roomType)
        {
            return _roomManagementDbContext.ROOM_TYPE.Update(roomType).Entity;
        }

        public bool DeleteRoomTypeById(Guid id)
        {
            return _roomManagementDbContext.ROOM_TYPE.Remove(new RoomType { Id = id }).Entity != null;
        }

        public bool DeleteRoomTypeByName(string name)
        {
            return _roomManagementDbContext.ROOM_TYPE.Remove(new RoomType { TypeName = name }).Entity != null;
        }
    }
}
