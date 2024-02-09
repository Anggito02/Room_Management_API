using AutoMapper;

using Room_Management_API.Application.RoomsApp.RoomTypeDomain.IRoomType;
using Room_Management_API.Application.Helper.ViewModels.RoomsVMs;
using Room_Management_API.Application.Helper.DTOs.RoomsDTOs;

namespace Room_Management_API.Application.RoomsApp.RoomTypeDomain
{
    public class RoomTypeService(
        IRoomTypeRepository roomTypeRepository,
        IMapper mapper
        ) : IRoomTypeService
    {
        private readonly IRoomTypeRepository _roomTypeRepository = roomTypeRepository;
        private readonly IMapper _mapper = mapper;

        public RoomTypeResultVM CreateRoomType(RoomTypeInputVM inputVM)
        {
            try {
                var entity = _roomTypeRepository.CreateRoomType(inputVM.Data);
                
                var resultVM = new RoomTypeResultVM();
                resultVM.Data.Add(_mapper.Map<RoomTypeResultDTO>(entity));

                return resultVM;
            }
            catch (Exception) {
                throw;
            }
        }

        public RoomTypeResultVM GetAllRoomTypes()
        {
            try {
                var entity = _roomTypeRepository.GetAllRoomTypes();
                var resultVM = new RoomTypeResultVM();

                foreach (var e in entity)
                {
                    resultVM.Data.Add(_mapper.Map<RoomTypeResultDTO>(e));
                }

            return resultVM;
            } catch (Exception){
                throw;
            }
        }

        public RoomTypeResultVM? GetRoomTypeByPkId(Guid id)
        {
            try {
                var entity = _roomTypeRepository.GetRoomTypeByPkId(id) ?? throw new KeyNotFoundException("Room type not found");             

                var resultVM = new RoomTypeResultVM();
                resultVM.Data.Add(_mapper.Map<RoomTypeResultDTO>(entity));

                return resultVM;
            } catch (Exception){
                throw;
            }
        }

        public RoomTypeResultVM? GetRoomTypeByTypeName(string typeName)
        {
            try {
                typeName = "%" + typeName.Replace("-", " ") + "%";

                var entity = _roomTypeRepository.GetRoomTypeByTypeName(typeName) ?? throw new KeyNotFoundException("Room type not found");

                var resultVM = new RoomTypeResultVM();
                
                foreach (var e in entity) {
                    resultVM.Data.Add(_mapper.Map<RoomTypeResultDTO>(e));
                }

                return resultVM;
            } catch (Exception){
                throw;
            }
        }
    }
}