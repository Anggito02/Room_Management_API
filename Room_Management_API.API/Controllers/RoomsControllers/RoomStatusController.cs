using Microsoft.AspNetCore.Mvc;

using Room_Management_API.Application.RoomsApp.RoomStatusDomain.IRoomStatus;
using Room_Management_API.Domain.Rooms;

namespace Room_Management_API.API.Controllers.RoomsControllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RoomStatusController(
        IRoomStatusService roomStatusService
    ) : ControllerBase
    {
        private readonly IRoomStatusService _roomStatusService = roomStatusService;

        [HttpGet]
        public ActionResult<List<RoomStatus>> Get()
        {
            return Ok(_roomStatusService.GetAllRoomStatus());
        }

        [HttpPost]
        public ActionResult<RoomStatus> Post([FromBody] RoomStatus roomStatus)
        {
            return Ok(_roomStatusService.CreateRoomStatus(roomStatus));
        }
    }
}
