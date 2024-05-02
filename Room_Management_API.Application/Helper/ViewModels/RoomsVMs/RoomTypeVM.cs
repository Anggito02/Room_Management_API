using System.ComponentModel.DataAnnotations;
using Room_Management_API.Application.Helper.DTOs.RoomsDTOs;

namespace Room_Management_API.Application.Helper.ViewModels.RoomsVMs
{
    public class AddRoomTypeVM
    {
        [Required(ErrorMessage = "Room Type Name is required")]
        [StringLength(100, MinimumLength = 3, ErrorMessage = "Room Type Name must be between 3 and 100 characters")]
        public required string TypeName { get; set; }
    }
    public class GetRoomTypeVM
    {
        public List<GetRoomTypeDTO> Data { get; set; } = new List<GetRoomTypeDTO>();
        public int StatusCode { get; set; }
        public string Message { get; set; } = string.Empty;
    }
}