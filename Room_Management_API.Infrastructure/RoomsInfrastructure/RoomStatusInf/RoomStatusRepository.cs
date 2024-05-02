using Microsoft.EntityFrameworkCore;
using AutoMapper;

using Room_Management_API.Domain.Rooms;
using Room_Management_API.Application.RoomsApp.RoomStatusDomain.IRoomStatus;
using Room_Management_API.Application.Helper.DTOs.RoomsDTOs;

namespace Room_Management_API.Infrastructure.RoomsInfrastructure.RoomStatusInf
{
    public class RoomStatusRepository(
            RoomsDbContext roomManagementDbContext,
            IMapper mapper
        ) : IRoomStatusRepository
    {
        private readonly RoomsDbContext _roomManagementDbContext = roomManagementDbContext;
        private readonly IMapper _mapper = mapper;

        public RoomStatus CreateRoomStatus(AddRoomStatusDTO inputDTO)
        {
            try {
                var roomStatus = _mapper.Map<RoomStatus>(inputDTO);

                roomStatus.Id = Guid.NewGuid();
                roomStatus.CreatedAt = DateTime.UtcNow;

                _roomManagementDbContext.ROOM_STATUS.Add(roomStatus);
                _roomManagementDbContext.SaveChanges();

                return roomStatus;
            } catch (Exception) {
                throw;
            }
        }

        public List<RoomStatus> GetAllRoomStatus()
        {
            try {
                return _roomManagementDbContext.ROOM_STATUS.ToList();
            } catch (Exception) {
                throw;
            }
        }

        public RoomStatus? GetRoomStatusByPkId(Guid id)
        {
            try {
                return _roomManagementDbContext.ROOM_STATUS.Find(id);
            } catch (Exception) {
                throw;
            }
        }

        public List<RoomStatus>? GetRoomStatusByStatusName(string statusName)
        {
            try {
                return _roomManagementDbContext.ROOM_STATUS.Where(t => EF.Functions.ILike(t.StatusName, statusName)).ToList();
            } catch (Exception) {
                throw;
            }
        }
    }
}
