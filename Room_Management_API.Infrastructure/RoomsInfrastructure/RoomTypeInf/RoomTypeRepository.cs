using Microsoft.EntityFrameworkCore;
using AutoMapper;

using Room_Management_API.Domain.Rooms;
using Room_Management_API.Application.RoomsApp.RoomTypeDomain.IRoomType;
using Room_Management_API.Application.Helper.DTOs.RoomsDTOs;

namespace Room_Management_API.Infrastructure.RoomsInfrastructure.RoomTypeInf
{
    public class RoomTypeRepository(
            RoomsDbContext roomManagementDbContext,
            IMapper mapper
        ) : IRoomTypeRepository
    {
        private readonly RoomsDbContext _roomManagementDbContext = roomManagementDbContext;
        private readonly IMapper _mapper = mapper;

        public RoomType CreateRoomType(AddRoomTypeDTO inputDTO)
        {
            try {
                var roomType = _mapper.Map<RoomType>(inputDTO);

                roomType.Id = Guid.NewGuid();
                roomType.CreatedAt = DateTime.UtcNow;
                
                _roomManagementDbContext.ROOM_TYPE.Add(roomType);
                _roomManagementDbContext.SaveChanges();

                return roomType;
            } catch (Exception) {
                throw;
            }
        }

        public List<RoomType> GetAllRoomTypes()
        {
            try {
                return _roomManagementDbContext.ROOM_TYPE.ToList();
            } catch (Exception) {
                throw;
            }
        }

        public RoomType? GetRoomTypeByPkId(Guid id)
        {
            try {
                return _roomManagementDbContext.ROOM_TYPE.Find(id);
            } catch (Exception) {
                throw;
            }
        }

        public List<RoomType>? GetRoomTypeByTypeName(string typeName)
        {
            try {
                typeName = "%" + typeName.Replace("-", " ") + "%";
                
                return _roomManagementDbContext.ROOM_TYPE.Where(t => EF.Functions.ILike(t.TypeName, typeName)).ToList();
            } catch (Exception) {
                throw;
            }
        }
    }
}
