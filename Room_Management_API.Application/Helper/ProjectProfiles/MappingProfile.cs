using AutoMapper;
using Room_Management_API.Application.Helper.DTOs.RoomsDTOs;
using Room_Management_API.Domain.Rooms;

namespace Room_Management_API.Application.Helper.ProjectProfiles
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<RoomType, RoomTypeResultDTO>();
        }
    }
}
