using Room_Management_API.Application.Helper.Exceptions;
using Room_Management_API.Application.Helper.Validators.RoomsValidators;
using Room_Management_API.Application.Helper.ViewModels.RoomsVMs;

namespace Room_Management_API.Infrastructure.RoomsInfrastructure.RoomTypeInf
{
    public class RoomTypeValidator(
        RoomsDbContext roomManagementDbContext
    ) : IRoomTypeValidator
    {
        private readonly RoomsDbContext _roomManagementDbContext = roomManagementDbContext;

        public bool ValidateAddRoomType(AddRoomTypeVM inputVM) {
            try {
                // Type Name Duplicate
                if(_roomManagementDbContext.ROOM_TYPE.Where(t => t.TypeName.ToLower() == inputVM.TypeName.ToLower()).FirstOrDefault() != null) {
                    throw new DuplicateDataException("Room type already exist");
                }
            } catch (Exception) {
                throw;
            }
            return true;
        }
    }
}