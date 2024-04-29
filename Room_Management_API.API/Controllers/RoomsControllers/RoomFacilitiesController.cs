using Microsoft.AspNetCore.Mvc;
using Room_Management_API.Application.RoomsApp.RoomFacilitiesDomain.IRoomFacilities;
using Room_Management_API.Application.Helper.ViewModels.RoomsVMs;
using Room_Management_API.Application.Helper.DTOs.RoomsDTOs;

namespace Room_Management_API.API.Controllers.RoomsControllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RoomFacilitiesController(
        IRoomFacilitiesService roomFacilitiesService
    ) : ControllerBase
    {
        private readonly IRoomFacilitiesService _roomFacilitiesService = roomFacilitiesService;

        [HttpGet("/api/RoomFacilities/pkId/{pkId}")]
        public ActionResult<RoomFacilitiesResultVM> Get(Guid pkId)
        {
            try {
                var result = _roomFacilitiesService.GetRoomFacilitiesByPkId(pkId);

                return StatusCode(200, result);
            } catch (Exception ex) {
                if (ex is KeyNotFoundException) return StatusCode(404, ex.Message);

                return StatusCode(500, ex.Message);
            }
        }

        [HttpGet("/api/RoomFacilities/name/{name}")]
        public ActionResult<RoomFacilitiesResultVM> Get(string name)
        {
            try {
                var result = _roomFacilitiesService.GetRoomFacilitiesByName(name);

                return StatusCode(200, result);
            } catch (Exception ex) {
                if (ex is KeyNotFoundException) return StatusCode(404, ex.Message);

                return StatusCode(500, ex.Message);
            }
        }

        [HttpGet]
        public ActionResult<List<RoomFacilitiesResultVM>> Get()
        {
            try {
                var result = _roomFacilitiesService.GetAllRoomFacilities();

                return StatusCode(200, result);
            } catch (Exception ex) {
                return StatusCode(500, ex.Message);
            }
        }

        [HttpPost]
        public ActionResult<RoomFacilitiesResultVM> Post(RoomFacilitiesInputVM roomFacilitiesInputVM)
        {
            try {
                var result = _roomFacilitiesService.CreateRoomFacilities(roomFacilitiesInputVM);

                return StatusCode(200, result);
            } catch (Exception ex) {
                return StatusCode(500, ex.Message);
            }
        }

        [HttpPut]
        public ActionResult<RoomFacilitiesResultVM> Put(RoomFacilitiesUpdateDTO updateDTO)
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
        public ActionResult<RoomFacilitiesResultVM> Delete(Guid pkId)
        {
            try {
                var result = _roomFacilitiesService.DeleteRoomFacilitiesByPkId(pkId);

                return StatusCode(200, result);
            } catch (Exception ex) {
                if (ex is KeyNotFoundException) return StatusCode(404, ex.Message);

                return StatusCode(500, ex.Message);
            }
        }
    }
}
