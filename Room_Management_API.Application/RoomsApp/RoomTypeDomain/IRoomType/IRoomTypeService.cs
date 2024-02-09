using Room_Management_API.Application.Helper.ViewModels.RoomsVMs;

namespace Room_Management_API.Application.RoomsApp.RoomTypeDomain.IRoomType
{
    public interface IRoomTypeService
    {
        RoomTypeResultVM CreateRoomType(RoomTypeInputVM inputVM);
        RoomTypeResultVM GetAllRoomTypes();
        RoomTypeResultVM? GetRoomTypeByPkId(Guid id);
        RoomTypeResultVM? GetRoomTypeByTypeName(string typeName);
    }
}