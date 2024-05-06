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
            CreateMap<AddRoomTypeDTO, RoomType>();
            CreateMap<RoomType, GetRoomTypeDTO>();

            CreateMap<AddRoomStatusVM, AddRoomStatusDTO>();
            CreateMap<AddRoomStatusDTO, RoomStatus>();
            CreateMap<RoomStatus, GetRoomStatusDTO>();

            CreateMap<AddRoomFacilitiesVM, AddRoomFacilitiesDTO>();
            CreateMap<AddRoomFacilitiesDTO, RoomFacilities>();
            CreateMap<RoomFacilities, GetRoomFacilitiesDTO>();
            CreateMap<FilterRoomFacilitiesVM, FilterRoomFacilitiesDTO>();
            CreateMap<UpdateRoomFacilitiesVM, UpdateRoomFacilitiesDTO>();
        }
    }
}
