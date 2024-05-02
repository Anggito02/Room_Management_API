using AutoMapper;

using Room_Management_API.Application.RoomsApp.RoomTypeDomain.IRoomType;
using Room_Management_API.Application.Helper.ViewModels.RoomsVMs;
using Room_Management_API.Application.Helper.DTOs.RoomsDTOs;
using Room_Management_API.Application.Helper.Exceptions;
using Room_Management_API.Application.Helper.Validators.RoomsValidators;

namespace Room_Management_API.Application.RoomsApp.RoomTypeDomain
{
    public class RoomTypeService(
        IRoomTypeValidator roomTypeValidator,
        IRoomTypeRepository roomTypeRepository,
        IMapper mapper
        ) : IRoomTypeService
    {
        private readonly IRoomTypeValidator _roomTypeValidator = roomTypeValidator;
        private readonly IRoomTypeRepository _roomTypeRepository = roomTypeRepository;
        private readonly IMapper _mapper = mapper;

        public GetRoomTypeVM CreateRoomType(AddRoomTypeVM inputVM)
        {
            try {
                _roomTypeValidator.ValidateAddRoomType(inputVM);

                var entity = _roomTypeRepository.CreateRoomType(_mapper.Map<AddRoomTypeDTO>(inputVM));
                
                var resultVM = new GetRoomTypeVM {
                    StatusCode = 200,
                    Message = "Room Type Created Successfully"
                };
                resultVM.Data.Add(_mapper.Map<GetRoomTypeDTO>(entity));
                return resultVM;
            } catch (DuplicateDataException ex) {
                var resultVM = new GetRoomTypeVM {
                    StatusCode = 409,
                    Message = ex.Message
                };
                return resultVM;
            } catch (Exception ex) {
                var resultVM = new GetRoomTypeVM {
                    StatusCode = 500,
                    Message = ex.Message
                };
                return resultVM;
            }
        }

        public GetRoomTypeVM GetAllRoomTypes()
        {
            try {
                var entity = _roomTypeRepository.GetAllRoomTypes();
                var resultVM = new GetRoomTypeVM {
                    StatusCode = 200,
                    Message = "Room Type Retrieved Successfully"
                };

                foreach (var e in entity)
                {
                    resultVM.Data.Add(_mapper.Map<GetRoomTypeDTO>(e));
                }
                return resultVM;
            } catch (Exception ex){
                var resultVM = new GetRoomTypeVM {
                    StatusCode = 500,
                    Message = ex.Message
                };
                return resultVM;
            }
        }

        public GetRoomTypeVM? GetRoomTypeByPkId(Guid id)
        {
            try {
                var entity = _roomTypeRepository.GetRoomTypeByPkId(id) ?? throw new KeyNotFoundException("Room type not found");             

                var resultVM = new GetRoomTypeVM {
                    StatusCode = 200,
                    Message = "Room Type Retrieved Successfully"
                };
                resultVM.Data.Add(_mapper.Map<GetRoomTypeDTO>(entity));

                return resultVM;
            } catch (KeyNotFoundException ex) {
                var resultVM = new GetRoomTypeVM {
                    StatusCode = 404,
                    Message = ex.Message
                };
                return resultVM;
            } catch (Exception ex){
                var resultVM = new GetRoomTypeVM {
                    StatusCode = 500,
                    Message = ex.Message
                };
                return resultVM;
            }
        }

        public GetRoomTypeVM? GetRoomTypeByTypeName(string typeName)
        {
            try {
                var entity = _roomTypeRepository.GetRoomTypeByTypeName(typeName) ?? throw new KeyNotFoundException("Room type not found");

                var resultVM = new GetRoomTypeVM {
                    StatusCode = 200,
                    Message = "Room Type Retrieved Successfully"
                };
                
                foreach (var e in entity) {
                    resultVM.Data.Add(_mapper.Map<GetRoomTypeDTO>(e));
                }

                return resultVM;
            } catch (KeyNotFoundException ex) {
                var resultVM = new GetRoomTypeVM {
                    StatusCode = 404,
                    Message = ex.Message
                };
                return resultVM;
            } catch (Exception ex){
                var resultVM = new GetRoomTypeVM {
                    StatusCode = 500,
                    Message = ex.Message
                };
                return resultVM;
            }
        }
    }
}