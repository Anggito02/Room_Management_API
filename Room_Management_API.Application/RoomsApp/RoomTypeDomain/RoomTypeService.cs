using Room_Management_API.Domain.Rooms;
using Room_Management_API.Application.RoomsApp.RoomTypeDomain.IRoomType;

namespace Room_Management_API.Application.RoomsApp.RoomTypeDomain
{
    public class RoomTypeService(
        IRoomTypeRepository roomTypeRepository
        ) : IRoomTypeService
    {
        private readonly IRoomTypeRepository _roomTypeRepository = roomTypeRepository;

        public RoomType CreateRoomType(RoomType roomType)
        {
            throw new NotImplementedException();
        }

        public List<RoomType> GetAllRoomTypes()
        {
            return _roomTypeRepository.GetAllRoomTypes();
        }

        public RoomType GetRoomTypeById(Guid id)
        {
            throw new NotImplementedException();
        }

        public List<RoomType> GetRoomTypeByName(string name)
        {
            throw new NotImplementedException();
        }

        public RoomType UpdateRoomType(RoomType roomType)
        {
            throw new NotImplementedException();
        }

        public bool DeleteRoomTypeById(Guid id)
        {
            throw new NotImplementedException();
        }

        public bool DeleteRoomTypeByName(string name)
        {
            throw new NotImplementedException();
        }
    }
}