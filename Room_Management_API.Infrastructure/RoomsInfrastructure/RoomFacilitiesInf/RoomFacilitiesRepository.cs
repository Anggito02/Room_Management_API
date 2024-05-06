using Microsoft.EntityFrameworkCore;
using AutoMapper;

using Room_Management_API.Application.RoomsApp.RoomFacilitiesDomain.IRoomFacilities;
using Room_Management_API.Domain.Rooms;
using Room_Management_API.Application.Helper.DTOs.RoomsDTOs;
using System.Reflection;

namespace Room_Management_API.Infrastructure.RoomsInfrastructure.RoomFacilitiesInf
{
    public class RoomFacilitiesRepository
    (
        RoomsDbContext roomManagementDbContext,
        IMapper mapper
    ) : IRoomFacilitiesRepository
    {
        private readonly RoomsDbContext _roomManagementDbContext = roomManagementDbContext;
        private readonly IMapper _mapper = mapper;

        public RoomFacilities CreateRoomFacilities(AddRoomFacilitiesDTO inputDTO)
        {
            try {
                var roomFacilities = _mapper.Map<RoomFacilities>(inputDTO);

                roomFacilities.Id = Guid.NewGuid();
                roomFacilities.CreatedAt = DateTime.UtcNow;
                roomFacilities.UpdatedAt = DateTime.UtcNow;
                roomFacilities.IsDeleted = false;

                _roomManagementDbContext.ROOM_FACILITIES.Add(roomFacilities);
                _roomManagementDbContext.SaveChanges();

                return roomFacilities;
            } catch {
                throw;
            }
        }

        public bool DeleteRoomFacilitiesByPkId(Guid pkId)
        {
            try {
                var roomFacilities = _roomManagementDbContext.ROOM_FACILITIES.Find(pkId) ?? throw new KeyNotFoundException("Room facilities not found");

                roomFacilities.IsDeleted = true;
                roomFacilities.UpdatedAt = DateTime.UtcNow;
                roomFacilities.DeletedAt = DateTime.UtcNow;

                _roomManagementDbContext.ROOM_FACILITIES.Update(roomFacilities);
                _roomManagementDbContext.SaveChanges();

                return true;
            } catch {
                throw;
            }
        }

        public List<RoomFacilities> GetAllRoomFacilities(FilterRoomFacilitiesDTO filterDTO)
        {
            try {
                string nameFilter = "%" + filterDTO.Name + "%";

                return _roomManagementDbContext.ROOM_FACILITIES
                    .Where(s => s.IsAvailable == filterDTO.IsAvailable)
                    .Where(s => EF.Functions.ILike(s.Name, nameFilter))
                    .Where(s => s.IsDeleted == false)
                    .ToList();
            } catch {
                throw;
            }
        }

        public RoomFacilities? GetRoomFacilitiesByPkId(Guid id)
        {
            try {
                return _roomManagementDbContext.ROOM_FACILITIES.Find(id);
            } catch {
                throw;
            }
        }

        public RoomFacilities UpdateRoomFacilities(UpdateRoomFacilitiesDTO updateDTO)
        {
            try {
                var roomFacilities = _roomManagementDbContext.ROOM_FACILITIES.Find(updateDTO.Id) ?? throw new KeyNotFoundException("Room facilities not found");

                roomFacilities.Name = updateDTO.Name;
                roomFacilities.Description = updateDTO.Description;
                roomFacilities.IsAvailable = updateDTO.IsAvailable;
                roomFacilities.UpdatedAt = DateTime.UtcNow;

                _roomManagementDbContext.ROOM_FACILITIES.Update(roomFacilities);
                _roomManagementDbContext.SaveChanges();

                return roomFacilities;
            } catch {
                throw;
            }
        }
    }
}