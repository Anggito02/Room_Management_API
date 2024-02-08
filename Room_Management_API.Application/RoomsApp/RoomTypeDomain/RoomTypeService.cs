using Room_Management_API.Domain.Rooms;
using Room_Management_API.Application.RoomsApp.RoomTypeDomain.IRoomType;
using Room_Management_API.Application.Helper.ViewModels.RoomsVMs;
using Room_Management_API.Application.Helper.DTOs.RoomsDTOs;
using AutoMapper;

namespace Room_Management_API.Application.RoomsApp.RoomTypeDomain
{
    public class RoomTypeService(
        IRoomTypeRepository roomTypeRepository,
        IMapper mapper
        ) : IRoomTypeService
    {
        private readonly IRoomTypeRepository _roomTypeRepository = roomTypeRepository;
        private readonly IMapper _mapper = mapper;

        public RoomTypeResultVM CreateRoomType(RoomTypeInputVM roomTypeInputVM)
        {
            throw new NotImplementedException();
        }

        public RoomTypeResultVM GetAllRoomTypes()
        {
            var entity = _roomTypeRepository.GetAllRoomTypes();
            var resultVM = new RoomTypeResultVM();

            foreach (var e in entity)
            {
                resultVM.Data.Add(_mapper.Map<RoomTypeResultDTO>(e));
            }

            return resultVM;
        }

        public RoomTypeResultVM? GetRoomTypeById(Guid id)
        {
            throw new NotImplementedException();
        }

        public RoomTypeResultVM? GetRoomTypeByTypeName(string typeName)
        {
            throw new NotImplementedException();
        }
    }
}