using Room_Management_API.Application.Helper.Exceptions;
using Room_Management_API.Application.Helper.Validators.RoomsValidators;
using Room_Management_API.Application.Helper.ViewModels.RoomsVMs;

namespace Room_Management_API.Infrastructure.RoomsInfrastructure.RoomFacilitiesInf
{
    public class RoomFacilitiesValidator(
        RoomsDbContext roomManagementDbContext
    ) : IRoomFacilitiesValidator
    {
        private readonly RoomsDbContext _roomManagementDbContext = roomManagementDbContext;

        public bool ValidateAddRoomFacilities(AddRoomFacilitiesVM inputVM)
        {
            try {
                // Facilities Name Duplicate
                if (_roomManagementDbContext.ROOM_FACILITIES.Where(s => s.Name.ToLower() == inputVM.Name.ToLower()).FirstOrDefault() != null) {
                    throw new DuplicateDataException("Room facilities already exist");
                }
            } catch (Exception) {
                throw;
            }
            return true;
        }

        public bool ValidateUpdateRoomFacilities(UpdateRoomFacilitiesVM updateVM)
        {
            try {
                // Facilities Name Duplicate
                if (_roomManagementDbContext.ROOM_FACILITIES.Where(s => s.Name.ToLower() == updateVM.Name.ToLower()).FirstOrDefault() != null) {
                    throw new DuplicateDataException("Room facilities already exist");
                }
            } catch (Exception) {
                throw;
            }
            return true;
        }
    }
}