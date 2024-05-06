using Microsoft.AspNetCore.Mvc;
using Room_Management_API.Application.RoomsApp.RoomFacilitiesDomain.IRoomFacilities;
using Room_Management_API.Application.Helper.ViewModels.RoomsVMs;

namespace Room_Management_API.API.Controllers.RoomsControllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RoomFacilitiesController(
        IRoomFacilitiesService roomFacilitiesService
    ) : ControllerBase
    {
        private readonly IRoomFacilitiesService _roomFacilitiesService = roomFacilitiesService;

        [HttpPost]
        public ActionResult<GetRoomFacilitiesVM> Post(AddRoomFacilitiesVM roomFacilitiesInputVM)
        {
            try {
                var result = _roomFacilitiesService.CreateRoomFacilities(roomFacilitiesInputVM);

                return StatusCode(200, result);
            } catch (Exception ex) {
                return StatusCode(500, ex.Message);
            }
        }

        [HttpGet("/api/RoomFacilities/pkId/{pkId}")]
        public ActionResult<GetRoomFacilitiesVM> Get(Guid pkId)
        {
            try {
                var result = _roomFacilitiesService.GetRoomFacilitiesByPkId(pkId);

                return StatusCode(200, result);
            } catch (Exception ex) {
                return StatusCode(500, ex.Message);
            }
        }

        [HttpPost("/api/RoomFacilities/filter/")]
        public ActionResult<List<GetRoomFacilitiesVM>> Post(FilterRoomFacilitiesVM roomFacilitiesFilterVM)
        {
            try {
                var result = _roomFacilitiesService.GetAllRoomFacilities(roomFacilitiesFilterVM);

                return StatusCode(200, result);
            } catch (Exception ex) {
                return StatusCode(500, ex.Message);
            }
        }

        [HttpPut]
        public ActionResult<GetRoomFacilitiesVM> Put(UpdateRoomFacilitiesVM updateDTO)
        {
            try {
                var result = _roomFacilitiesService.UpdateRoomFacilities(updateDTO);

                return StatusCode(200, result);
            } catch (Exception ex) {
                if (ex is KeyNotFoundException) return StatusCode(404, ex.Message);

                return StatusCode(500, ex.Message);
            }
        }

        [HttpDelete]
        public ActionResult<GetRoomFacilitiesVM> Delete(Guid pkId)
        {
            try {
                var result = _roomFacilitiesService.DeleteRoomFacilitiesByPkId(pkId);

                return StatusCode(200, result);
            } catch (Exception ex) {
                return StatusCode(500, ex.Message);
            }
        }
    }
}
