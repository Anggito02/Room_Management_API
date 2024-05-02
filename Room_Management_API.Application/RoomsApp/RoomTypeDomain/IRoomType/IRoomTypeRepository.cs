using Room_Management_API.Application.Helper.DTOs.RoomsDTOs;
using Room_Management_API.Domain.Rooms;

namespace Room_Management_API.Application.RoomsApp.RoomTypeDomain.IRoomType
{
    public interface IRoomTypeRepository
    {
        RoomType CreateRoomType(AddRoomTypeDTO inputDTO);
        List<RoomType> GetAllRoomTypes();
        RoomType? GetRoomTypeByPkId(Guid id);
        List<RoomType>? GetRoomTypeByTypeName(string typeName);
    }
}