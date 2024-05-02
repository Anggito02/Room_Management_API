using Room_Management_API.Application.Helper.ViewModels.RoomsVMs;

namespace Room_Management_API.Application.Helper.Validators.RoomsValidators
{
    public interface IRoomTypeValidator
    {
        bool ValidateAddRoomType(AddRoomTypeVM inputVM);
    }
}