using Room_Management_API.Domain.Rooms;

namespace Room_Management_API.Application.RoomsApp.RoomTypeDomain.IRoomType
{
    public interface IRoomTypeService
    {
        RoomType CreateRoomType(RoomType roomType);
        List<RoomType> GetAllRoomTypes();
        RoomType? GetRoomTypeById(Guid id);
        List<RoomType>? GetRoomTypeByName(string name);
        RoomType UpdateRoomType(RoomType roomType);
        bool DeleteRoomTypeById(Guid id);
        bool DeleteRoomTypeByName(string name);
    }
}