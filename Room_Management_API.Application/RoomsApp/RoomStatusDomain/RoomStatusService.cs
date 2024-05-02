using AutoMapper;

using Room_Management_API.Application.RoomsApp.RoomStatusDomain.IRoomStatus;
using Room_Management_API.Application.Helper.ViewModels.RoomsVMs;
using Room_Management_API.Application.Helper.DTOs.RoomsDTOs;
using Room_Management_API.Application.Helper.Validators.RoomsValidators;
using Room_Management_API.Application.Helper.Exceptions;

namespace Room_Management_API.Application.RoomsApp.RoomStatusDomain
{
    public class RoomStatusService(
        IRoomStatusValidator roomStatusValidator,
        IRoomStatusRepository roomStatusRepository,
        IMapper mapper
        ) : IRoomStatusService
    {
        private readonly IRoomStatusValidator _roomStatusValidator = roomStatusValidator;
        private readonly IRoomStatusRepository _roomStatusRepository = roomStatusRepository;
        private readonly IMapper _mapper = mapper;

        public GetRoomStatusVM CreateRoomStatus(AddRoomStatusVM inputVM)
        {
            try {
                _roomStatusValidator.ValidateAddRoomStatus(inputVM);

                var entity = _roomStatusRepository.CreateRoomStatus(_mapper.Map<AddRoomStatusDTO>(inputVM));

                var resultVM = new GetRoomStatusVM {
                    StatusCode = 200,
                    Message = "Room Status Created Successfully"
                };
                resultVM.Data.Add(_mapper.Map<GetRoomStatusDTO>(entity));

                return resultVM;
            } catch (DuplicateDataException ex) {
                var resultVM = new GetRoomStatusVM {
                    StatusCode = 409,
                    Message = ex.Message
                };
                return resultVM;
            } catch (Exception ex) {
                var resultVM = new GetRoomStatusVM {
                    StatusCode = 500,
                    Message = ex.Message
                };
                return resultVM;
            }
        }

        public GetRoomStatusVM GetAllRoomStatus()
        {
            try {
                var entity = _roomStatusRepository.GetAllRoomStatus();
                var resultVM = new GetRoomStatusVM {
                    StatusCode = 200,
                    Message = "Room Status Retrieved Successfully"
                };

                foreach (var e in entity)
                {
                    resultVM.Data.Add(_mapper.Map<GetRoomStatusDTO>(e));
                }

                return resultVM;
            } catch (Exception ex) {
                var resultVM = new GetRoomStatusVM {
                    StatusCode = 500,
                    Message = ex.Message
                };

                return resultVM;
            }
        }

        public GetRoomStatusVM? GetRoomStatusByPkId(Guid id)
        {
            try {
                var entity = _roomStatusRepository.GetRoomStatusByPkId(id) ?? throw new KeyNotFoundException("Room status not found");
                var resultVM = new GetRoomStatusVM {
                    StatusCode = 200,
                    Message = "Room Status Retrieved Successfully"
                };

                resultVM.Data.Add(_mapper.Map<GetRoomStatusDTO>(entity));

                return resultVM;
            } catch (KeyNotFoundException ex) {
                var resultVM = new GetRoomStatusVM {
                    StatusCode = 404,
                    Message = ex.Message
                };
                return resultVM;
            } catch (Exception ex) {
                var resultVM = new GetRoomStatusVM {
                    StatusCode = 500,
                    Message = ex.Message
                };
                return resultVM;
            }
        }

        public GetRoomStatusVM? GetRoomStatusByStatusName(string statusName)
        {
            try {
                statusName = '%' + statusName.Replace("-", " ") + "%";

                var entity = _roomStatusRepository.GetRoomStatusByStatusName(statusName) ?? throw new KeyNotFoundException("Room status not found");

                var resultVM = new GetRoomStatusVM();

                foreach (var e in entity)
                {
                    resultVM.Data.Add(_mapper.Map<GetRoomStatusDTO>(e));
                }

                return resultVM;
            } catch (KeyNotFoundException ex) {
                var resultVM = new GetRoomStatusVM {
                    StatusCode = 404,
                    Message = ex.Message
                };
                return resultVM;
            } catch (Exception ex) {
                var resultVM = new GetRoomStatusVM {
                    StatusCode = 500,
                    Message = ex.Message
                };
                return resultVM;
            }
        }
    }
}