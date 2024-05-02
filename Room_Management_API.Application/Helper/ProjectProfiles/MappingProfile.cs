using AutoMapper;

using Room_Management_API.Domain.Rooms;
using Room_Management_API.Application.Helper.DTOs.RoomsDTOs;
using Room_Management_API.Application.Helper.ViewModels.RoomsVMs;

namespace Room_Management_API.Application.Helper.ProjectProfiles
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<AddRoomTypeVM, AddRoomTypeDTO>();
            CreateMap<RoomType, GetRoomTypeDTO>();
            CreateMap<AddRoomTypeDTO, RoomType>();

            CreateMap<AddRoomStatusVM, AddRoomStatusDTO>();
            CreateMap<RoomStatus, GetRoomStatusDTO>();
            CreateMap<AddRoomStatusDTO, RoomStatus>();
        }
    }
}
