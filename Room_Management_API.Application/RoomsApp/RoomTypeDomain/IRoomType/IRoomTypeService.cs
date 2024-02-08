using Room_Management_API.Application.Helper.DTOs.RoomsDTOs;
using Room_Management_API.Application.Helper.ViewModels.RoomsVMs;
using Room_Management_API.Domain.Rooms;

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