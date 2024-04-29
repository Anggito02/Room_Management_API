using Microsoft.EntityFrameworkCore;
using AutoMapper;

using Room_Management_API.Application.RoomsApp.RoomFacilitiesDomain.IRoomFacilities;
using Room_Management_API.Domain.Rooms;
using Room_Management_API.Application.Helper.DTOs.RoomsDTOs;

namespace Room_Management_API.Infrastructure.RoomsInfrastructure.RoomFacilitiesInf
{
    public class RoomFacilitiesRepository
    (

    ) : IRoomFacilitiesRepository
    {
        public RoomFacilities CreateRoomFacilities(RoomFacilitiesInputDTO inputDTO)
        {
            throw new NotImplementedException();
        }

        public bool DeleteRoomFacilitiesByPkId(int pkId)
        {
            throw new NotImplementedException();
        }

        public List<RoomFacilities> GetAllRoomFacilities()
        {
            throw new NotImplementedException();
        }

        public RoomFacilities GetRoomFacilitiesByName(string name)
        {
            throw new NotImplementedException();
        }

        public RoomFacilities GetRoomFacilitiesByPkId(int pkId)
        {
            throw new NotImplementedException();
        }

        public bool IsRoomFacilitiesAvailable(string name)
        {
            throw new NotImplementedException();
        }

        public RoomFacilities UpdateRoomFacilities(RoomFacilitiesUpdateDTO updateDTO)
        {
            throw new NotImplementedException();
        }
    }
}