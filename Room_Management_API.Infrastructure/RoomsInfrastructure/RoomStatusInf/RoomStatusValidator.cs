using Room_Management_API.Application.Helper.Exceptions;
using Room_Management_API.Application.Helper.Validators.RoomsValidators;
using Room_Management_API.Application.Helper.ViewModels.RoomsVMs;

namespace Room_Management_API.Infrastructure.RoomsInfrastructure.RoomStatusInf
{
    public class RoomStatusValidator(
        RoomsDbContext roomManagementDbContext
    ) : IRoomStatusValidator
    {
        private readonly RoomsDbContext _roomManagementDbContext = roomManagementDbContext;

        public bool ValidateAddRoomStatus(AddRoomStatusVM inputVM)
        {
            try {
                // Status Name Duplicate
                if (_roomManagementDbContext.ROOM_STATUS.Where(s => s.StatusName.ToLower() == inputVM.StatusName.ToLower()).FirstOrDefault() != null) {
                    throw new DuplicateDataException("Room status already exist");
                }
            } catch (Exception) {
                throw;
            }
            return true;
        }
    }
}