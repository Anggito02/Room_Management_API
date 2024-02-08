using Microsoft.AspNetCore.Mvc;
using Room_Management_API.Application.Helper.ViewModels.RoomsVMs;
using Room_Management_API.Application.RoomsApp.RoomTypeDomain.IRoomType;

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
        public ActionResult<List<RoomTypeResultVM>> Get()
        {   
            try {
                var result = _roomTypeService.GetAllRoomTypes();

                return StatusCode(200, result);
            } 
            catch (Exception ex) {
                return StatusCode(500, ex.Message);
            }
        }

        [HttpPost]
        public ActionResult<RoomTypeResultVM> Post([FromBody] RoomTypeInputVM roomTypeInputVM)
        {
            try {
                var result = _roomTypeService.CreateRoomType(roomTypeInputVM);

                return StatusCode(200, result);
            } 
            catch (Exception ex) {
                return StatusCode(500, ex.Message);
            }
        }
    }
}
