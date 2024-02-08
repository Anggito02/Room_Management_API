using Room_Management_API.Domain.Rooms;
using Room_Management_API.Application.RoomsApp.RoomTypeDomain.IRoomType;
using Room_Management_API.Application.Helper.DTOs.RoomsDTOs;

namespace Room_Management_API.Infrastructure.RoomsInfrastructure.RoomTypeInf
{
    public class RoomTypeRepository(
            RoomsDbContext roomManagementDbContext
        ) : IRoomTypeRepository
    {
        private readonly RoomsDbContext _roomManagementDbContext = roomManagementDbContext;

        public RoomType CreateRoomType(RoomTypeInputDTO inputDTO)
        {
            try {
                RoomType roomType = new()
                {
                    Id = Guid.NewGuid(),
                    TypeName = inputDTO.TypeName,
                    CreatedAt = DateTime.UtcNow
                };
                
                _roomManagementDbContext.ROOM_TYPE.Add(roomType);
                _roomManagementDbContext.SaveChanges();

                return roomType;
            } catch (Exception ex) {
                throw new Exception(ex.Message);
            }
        }

        public List<RoomType> GetAllRoomTypes()
        {
            return _roomManagementDbContext.ROOM_TYPE.ToList();
        }

        public RoomType? GetRoomTypeByPkId(Guid id)
        {
            throw new NotImplementedException();
        }

        public List<RoomType>? GetRoomTypeByTypeName(string typeName)
        {
            throw new NotImplementedException();
        }
    }
}
