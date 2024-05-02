using Room_Management_API.Application.Helper.ViewModels.RoomsVMs;

namespace Room_Management_API.Application.RoomsApp.RoomTypeDomain.IRoomType
{
    public interface IRoomTypeService
    {
        GetRoomTypeVM CreateRoomType(AddRoomTypeVM inputVM);
        GetRoomTypeVM GetAllRoomTypes();
        GetRoomTypeVM? GetRoomTypeByPkId(Guid id);
        GetRoomTypeVM? GetRoomTypeByTypeName(string typeName);
    }
}