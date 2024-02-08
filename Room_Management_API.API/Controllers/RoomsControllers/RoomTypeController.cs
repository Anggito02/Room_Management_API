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

        [HttpGet("/pkId/{pkId}")]
        public ActionResult<RoomTypeResultVM> Get(Guid pkId)
        {
            try {
                var result = _roomTypeService.GetRoomTypeByPkId(pkId);

                return StatusCode(200, result);
            } catch (Exception ex) {
                return StatusCode(500, ex.Message);
            }
        }

        [HttpGet("/typeName/{typeName}")]
        public ActionResult<RoomTypeResultVM> Get(string typeName)
        {
            try {
                var result = _roomTypeService.GetRoomTypeByTypeName(typeName);

                return StatusCode(200, result);
            } catch (Exception ex) {
                return StatusCode(500, ex.Message);
            }
        }

        [HttpGet]
        public ActionResult<List<RoomTypeResultVM>> Get()
        {   
            try {
                var result = _roomTypeService.GetAllRoomTypes();

                return StatusCode(200, result);
            } catch (Exception ex) {
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
