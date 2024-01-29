using Room_Management_API.Domain.Rooms;
using Room_Management_API.Application.RoomsApp.RoomTypeDomain.IRoomType;

namespace Room_Management_API.Infrastructure.RoomsInfrastructure.RoomTypeDomain
{
    public class RoomTypeRepository : IRoomTypeRepository
    {
        public static List<RoomType> Rooms = [
            new RoomType { Id=Guid.NewGuid(), TypeName="Single"},
            new RoomType { Id=Guid.NewGuid(), TypeName="Double"}
        ];

        public RoomType CreateRoomType(RoomType roomType)
        {
            throw new NotImplementedException();
        }

        public List<RoomType> GetAllRoomTypes()
        {
            return Rooms;
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
