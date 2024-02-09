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
        public ActionResult<RoomStatusResultVM> Get(Guid pkId)
        {
            try {
                var result = _roomStatusService.GetRoomStatusByPkId(pkId);

                return StatusCode(200, result);
            } catch (Exception ex) {
                if (ex is KeyNotFoundException) return StatusCode(404, ex.Message);

                return StatusCode(500, ex.Message);
            }
        }

        [HttpGet("/api/RoomStatus/statusName/{statusName}")]
        public ActionResult<RoomStatusResultVM> Get(string statusName)
        {
            try {
                var result = _roomStatusService.GetRoomStatusByStatusName(statusName);

                return StatusCode(200, result);
            } catch (Exception ex) {
                if (ex is KeyNotFoundException) return StatusCode(404, ex.Message + " " + statusName);

                return StatusCode(500, ex.Message);
            }
        }

        [HttpGet]
        public ActionResult<List<RoomStatusResultVM>> Get()
        {
            try {
                var result = _roomStatusService.GetAllRoomStatus();

                return StatusCode(200, result);
            } catch (Exception ex) {
                return StatusCode(500, ex.Message);
            }
        }
    }
}
