using Microsoft.AspNetCore.Mvc;
using Room_Management_API.Application.Helper.ViewModels.RoomsVMs;
using Room_Management_API.Application.RoomsApp.RoomStatusDomain.IRoomStatus;

namespace Room_Management_API.API.Controllers.RoomsControllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RoomStatusController(
        IRoomStatusService roomStatusService
    ) : ControllerBase
    {
        private readonly IRoomStatusService _roomStatusService = roomStatusService;

        [HttpGet("/api/RoomStatus/pkId/{pkId}")]
        public ActionResult<GetRoomStatusVM> Get(Guid pkId)
        {
            try {
                var result = _roomStatusService.GetRoomStatusByPkId(pkId);

                return StatusCode(200, result);
            } catch (Exception ex) {
                return StatusCode(500, ex.Message);
            }
        }

        [HttpGet("/api/RoomStatus/statusName/{statusName}")]
        public ActionResult<GetRoomStatusVM> Get(string statusName)
        {
            try {
                var result = _roomStatusService.GetRoomStatusByStatusName(statusName);

                return StatusCode(200, result);
            } catch (Exception ex) {
                return StatusCode(500, ex.Message);
            }
        }

        [HttpGet]
        public ActionResult<List<GetRoomStatusVM>> Get()
        {
            try {
                var result = _roomStatusService.GetAllRoomStatus();

                return StatusCode(200, result);
            } catch (Exception ex) {
                return StatusCode(500, ex.Message);
            }
        }

        [HttpPost]
        public ActionResult<GetRoomStatusVM> Post(AddRoomStatusVM roomStatusInputVM)
        {
            try {
                var result = _roomStatusService.CreateRoomStatus(roomStatusInputVM);

                return StatusCode(200, result);
            } catch (Exception ex) {
                return StatusCode(500, ex.Message);
            }
        }
    }
}
