using System.ComponentModel.DataAnnotations;
using Room_Management_API.Application.Helper.DTOs.RoomsDTOs;

namespace Room_Management_API.Application.Helper.ViewModels.RoomsVMs
{
    public class AddRoomStatusVM
    {
        [Required(ErrorMessage = "Room Status Name is required")]
        [StringLength(50, MinimumLength = 3, ErrorMessage = "Room Status Name must be between 3 and 50 characters")]
        public required string StatusName { get; set; }
    }

    public class GetRoomStatusVM
    {
        public List<GetRoomStatusDTO> Data { get; set; } = new List<GetRoomStatusDTO>();
        public int StatusCode { get; set; }
        public string Message { get; set; } = string.Empty;
    }
}