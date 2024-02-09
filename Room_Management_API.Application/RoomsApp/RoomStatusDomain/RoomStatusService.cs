using AutoMapper;

using Room_Management_API.Application.RoomsApp.RoomStatusDomain.IRoomStatus;
using Room_Management_API.Application.Helper.ViewModels.RoomsVMs;
using Room_Management_API.Application.Helper.DTOs.RoomsDTOs;

namespace Room_Management_API.Application.RoomsApp.RoomStatusDomain
{
    public class RoomStatusService(
        IRoomStatusRepository roomStatusRepository,
        IMapper mapper
        ) : IRoomStatusService
    {
        private readonly IRoomStatusRepository _roomStatusRepository = roomStatusRepository;
        private readonly IMapper _mapper = mapper;

        public RoomStatusResultVM CreateRoomStatus(RoomStatusInputVM inputVM)
        {
            throw new NotImplementedException();
        }

        public RoomStatusResultVM GetAllRoomStatus()
        {
            try {
                var entity = _roomStatusRepository.GetAllRoomStatus();
                var resultVM = new RoomStatusResultVM();

                foreach (var e in entity)
                {
                    resultVM.Data.Add(_mapper.Map<RoomStatusResultDTO>(e));
                }

                return resultVM;
            } catch (Exception) {
                throw;
            }
        }

        public RoomStatusResultVM? GetRoomStatusByPkId(Guid id)
        {
            try {
                var entity = _roomStatusRepository.GetRoomStatusByPkId(id) ?? throw new KeyNotFoundException("Room status not found");
                var resultVM = new RoomStatusResultVM();

                resultVM.Data.Add(_mapper.Map<RoomStatusResultDTO>(entity));

                return resultVM;
            } catch (Exception) {
                throw;
            }
        }

        public RoomStatusResultVM? GetRoomStatusByStatusName(string statusName)
        {
            try {
                statusName = '%' + statusName.Replace("-", " ") + "%";

                var entity = _roomStatusRepository.GetRoomStatusByStatusName(statusName) ?? throw new KeyNotFoundException("Room status not found");

                var resultVM = new RoomStatusResultVM();

                foreach (var e in entity)
                {
                    resultVM.Data.Add(_mapper.Map<RoomStatusResultDTO>(e));
                }

                return resultVM;
            } catch (Exception) {
                throw;
            }
        }
    }
}