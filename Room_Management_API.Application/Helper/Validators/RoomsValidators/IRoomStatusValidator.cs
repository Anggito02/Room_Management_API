using Room_Management_API.Application.Helper.ViewModels.RoomsVMs;

namespace Room_Management_API.Application.Helper.Validators.RoomsValidators
{
    public interface IRoomStatusValidator
    {
        bool ValidateAddRoomStatus(AddRoomStatusVM inputVM);
    }
}