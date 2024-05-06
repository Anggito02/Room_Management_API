using Room_Management_API.Application.Helper.ViewModels.RoomsVMs;

namespace Room_Management_API.Application.Helper.Validators.RoomsValidators
{
    public interface IRoomFacilitiesValidator
    {
        bool ValidateAddRoomFacilities(AddRoomFacilitiesVM inputVM);

        bool ValidateUpdateRoomFacilities(UpdateRoomFacilitiesVM updateVM);
    }
}