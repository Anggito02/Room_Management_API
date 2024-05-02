using AutoMapper;

using Room_Management_API.Domain.Rooms;
using Room_Management_API.Application.Helper.DTOs.RoomsDTOs;

namespace Room_Management_API.Application.Helper.ProjectProfiles
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<RoomType, GetRoomTypeDTO>();
            CreateMap<AddRoomTypeDTO, RoomType>();
            CreateMap<RoomStatus, RoomStatusResultDTO>();
            CreateMap<RoomStatusInputDTO, RoomStatus>();
        }
    }
}
