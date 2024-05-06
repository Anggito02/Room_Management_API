using AutoMapper;
using Room_Management_API.Application.Helper.DTOs.RoomsDTOs;
using Room_Management_API.Application.Helper.Exceptions;
using Room_Management_API.Application.Helper.Validators.RoomsValidators;
using Room_Management_API.Application.Helper.ViewModels.RoomsVMs;
using Room_Management_API.Application.RoomsApp.RoomFacilitiesDomain.IRoomFacilities;

namespace Room_Management_API.Application.RoomsApp.RoomFacilitiesDomain
{
    public class RoomFacilitiesService(
        IRoomFacilitiesValidator roomFacilitiesValidator,
        IRoomFacilitiesRepository roomFacilitiesRepository,
        IMapper mapper
    ) : IRoomFacilitiesService
    {
        private readonly IRoomFacilitiesValidator _roomFacilitiesValidator = roomFacilitiesValidator;
        private readonly IRoomFacilitiesRepository _roomFacilitiesRepository = roomFacilitiesRepository;
        private readonly IMapper _mapper = mapper;

        public GetRoomFacilitiesVM CreateRoomFacilities(AddRoomFacilitiesVM inputVM)
        {
            try {
                _roomFacilitiesValidator.ValidateAddRoomFacilities(inputVM);

                var roomFacilitiesDTO = _mapper.Map<AddRoomFacilitiesDTO>(inputVM);
                roomFacilitiesDTO.IsAvailable = true;

                var entity = _roomFacilitiesRepository.CreateRoomFacilities(roomFacilitiesDTO);

                var resultVM = new GetRoomFacilitiesVM {
                    StatusCode = 200,
                    Message = "Room Facilities Created Successfully"
                };

                resultVM.Data.Add(_mapper.Map<GetRoomFacilitiesDTO>(entity));

                return resultVM;
            } catch (DuplicateDataException ex) {
                var resultVM = new GetRoomFacilitiesVM {
                    StatusCode = 409,
                    Message = ex.Message
                };
                return resultVM;
            } catch (Exception ex) {
                var resultVM = new GetRoomFacilitiesVM {
                    StatusCode = 500,
                    Message = ex.Message
                };
                return resultVM;
            }
        }

        public GetRoomFacilitiesVM DeleteRoomFacilitiesByPkId(Guid id)
        {
            try {
                _roomFacilitiesRepository.DeleteRoomFacilitiesByPkId(id);
                var resultVM = new GetRoomFacilitiesVM {
                    StatusCode = 200,
                    Message = "Room Facilities Deleted Successfully"
                };

                return resultVM;
            } catch (KeyNotFoundException ex) {
                var resultVM = new GetRoomFacilitiesVM {
                    StatusCode = 404,
                    Message = ex.Message
                };
                return resultVM;
            } catch (Exception ex) {
                var resultVM = new GetRoomFacilitiesVM {
                    StatusCode = 500,
                    Message = ex.Message
                };
                return resultVM;
            }
        }

        public List<GetRoomFacilitiesVM> GetAllRoomFacilities(FilterRoomFacilitiesVM filterVM)
        {
            try {
                var entity = _roomFacilitiesRepository.GetAllRoomFacilities(_mapper.Map<FilterRoomFacilitiesDTO>(filterVM));

                var resultVM = new GetRoomFacilitiesVM {
                    StatusCode = 200,
                    Message = "Room Facilities Retrieved Successfully"
                };

                foreach (var e in entity) {
                    resultVM.Data.Add(_mapper.Map<GetRoomFacilitiesDTO>(e));
                }
                return new List<GetRoomFacilitiesVM> { resultVM };
            } catch (Exception ex) {
                var resultVM = new GetRoomFacilitiesVM {
                    StatusCode = 500,
                    Message = ex.Message
                };
                return new List<GetRoomFacilitiesVM> { resultVM };
            }
        }

        public GetRoomFacilitiesVM? GetRoomFacilitiesByPkId(Guid id)
        {
            try {
                var entity = _roomFacilitiesRepository.GetRoomFacilitiesByPkId(id) ?? throw new KeyNotFoundException("Room facilities not found");

                var resultVM = new GetRoomFacilitiesVM {
                    StatusCode = 200,
                    Message = "Room Facilities Retrieved Successfully"
                };

                resultVM.Data.Add(_mapper.Map<GetRoomFacilitiesDTO>(entity));
                return resultVM;
            } catch (KeyNotFoundException ex) {
                var resultVM = new GetRoomFacilitiesVM {
                    StatusCode = 404,
                    Message = ex.Message
                };
                return resultVM;
            } catch (Exception ex) {
                var resultVM = new GetRoomFacilitiesVM {
                    StatusCode = 500,
                    Message = ex.Message
                };
                return resultVM;
            }
        }

        public GetRoomFacilitiesVM UpdateRoomFacilities(UpdateRoomFacilitiesVM updateDTO)
        {
            try {
                _roomFacilitiesValidator.ValidateUpdateRoomFacilities(updateDTO);

                var entity = _roomFacilitiesRepository.UpdateRoomFacilities(_mapper.Map<UpdateRoomFacilitiesDTO>(updateDTO));
                var resultVM = new GetRoomFacilitiesVM {
                    StatusCode = 200,
                    Message = "Room Facilities Updated Successfully"
                };
                resultVM.Data.Add(_mapper.Map<GetRoomFacilitiesDTO>(entity));
                return resultVM;
            } catch (KeyNotFoundException ex) {
                var resultVM = new GetRoomFacilitiesVM {
                    StatusCode = 404,
                    Message = ex.Message
                };
                return resultVM;
            } catch (DuplicateDataException ex) {
                var resultVM = new GetRoomFacilitiesVM {
                    StatusCode = 409,
                    Message = ex.Message
                };
                return resultVM;
            } catch (Exception ex) {
                var resultVM = new GetRoomFacilitiesVM {
                    StatusCode = 500,
                    Message = ex.Message
                };
                return resultVM;
            }
        }
    }
}