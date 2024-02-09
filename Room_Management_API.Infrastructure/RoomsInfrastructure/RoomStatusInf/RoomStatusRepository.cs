using Room_Management_API.Domain.Rooms;
using Room_Management_API.Application.RoomsApp.RoomStatusDomain.IRoomStatus;
using Room_Management_API.Application.Helper.DTOs.RoomsDTOs;
using Microsoft.EntityFrameworkCore;

namespace Room_Management_API.Infrastructure.RoomsInfrastructure.RoomStatusInf
{
    public class RoomStatusRepository(
            RoomsDbContext roomManagementDbContext
        ) : IRoomStatusRepository
    {
        private readonly RoomsDbContext _roomManagementDbContext = roomManagementDbContext;

        public RoomStatus CreateRoomStatus(RoomStatusInputDTO inputDTO)
        {
            throw new NotImplementedException();
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
