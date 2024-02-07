using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;

using Room_Management_API.Application.RoomsApp.RoomTypeDomain.IRoomType;
using Room_Management_API.Domain.Rooms;

namespace Room_Management_API.API.Controllers.RoomsControllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RoomTypeController(
        IRoomTypeService roomTypeService
        ) : ControllerBase
    {
        private readonly IRoomTypeService _roomTypeService = roomTypeService;

        [HttpGet]
        public ActionResult<List<RoomType>> Get()
        {   
            return Ok(_roomTypeService.GetAllRoomTypes());
        }   

        [HttpPost]
        public ActionResult<RoomType> Post(RoomType roomType)
        {
            return Ok(_roomTypeService.CreateRoomType(roomType));
        }
    }
}
