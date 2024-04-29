using Room_Management_API.Application.Helper.DTOs.RoomsDTOs;
using Room_Management_API.Application.Helper.ViewModels.RoomsVMs;
using Room_Management_API.Application.RoomsApp.RoomFacilitiesDomain.IRoomFacilities;

namespace Room_Management_API.Application.RoomsApp.RoomFacilitiesDomain
{
    public class RoomFacilitiesService : IRoomFacilitiesService
    {
        public RoomFacilitiesResultVM CreateRoomFacilities(RoomFacilitiesInputVM inputVM)
        {
            throw new NotImplementedException();
        }

        public bool DeleteRoomFacilitiesByPkId(Guid id)
        {
            throw new NotImplementedException();
        }

        public RoomFacilitiesResultVM GetAllRoomFacilities()
        {
            throw new NotImplementedException();
        }

        public RoomFacilitiesResultVM GetRoomFacilitiesByName(string name)
        {
            throw new NotImplementedException();
        }

        public RoomFacilitiesResultVM? GetRoomFacilitiesByPkId(Guid id)
        {
            throw new NotImplementedException();
        }

        public bool IsRoomFacilitiesAvailable(int id)
        {
            throw new NotImplementedException();
        }

        public RoomFacilitiesResultVM UpdateRoomFacilities(RoomFacilitiesUpdateDTO updateDTO)
        {
            throw new NotImplementedException();
        }
    }
}