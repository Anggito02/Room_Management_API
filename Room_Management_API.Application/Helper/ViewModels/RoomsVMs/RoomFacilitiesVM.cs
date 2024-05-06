using System.ComponentModel.DataAnnotations;
using Room_Management_API.Application.Helper.DTOs.RoomsDTOs;

namespace Room_Management_API.Application.Helper.ViewModels.RoomsVMs
{
    public class AddRoomFacilitiesVM
    {
        [Required(ErrorMessage = "Facilities Name is required")]
        [StringLength(100, MinimumLength = 3, ErrorMessage = "Facilities Name must be between 3 and 100 characters")]
        public required string Name { get; set; }

        [Required(ErrorMessage = "Facilities Description is required")]
        [StringLength(400, MinimumLength = 3, ErrorMessage = "Facilities Description must be between 3 and 400 characters")]
        public required string Description { get; set; }
    }

    public class FilterRoomFacilitiesVM
    {
        public string Name { get; set; } = string.Empty;
        public bool IsAvailable { get; set; } = true;
    }

    public class UpdateRoomFacilitiesVM
    {
        [Required(ErrorMessage = "Room Facilities Id is required")]
        public required Guid Id { get; set; }

        [Required(ErrorMessage = "Facilities Name is required")]
        [StringLength(100, MinimumLength = 3, ErrorMessage = "Facilities Name must be between 3 and 100 characters")]
        public string Name { get; set; } = string.Empty;

        [Required(ErrorMessage = "Facilities Description is required")]
        [StringLength(400, MinimumLength = 3, ErrorMessage = "Facilities Description must be between 3 and 400 characters")]
        public string Description { get; set; } = string.Empty;
        public bool IsAvailable { get; set; }
    }

    public class GetRoomFacilitiesVM
    {
        public List<GetRoomFacilitiesDTO> Data { get; set; } = new List<GetRoomFacilitiesDTO>();
        public int StatusCode { get; set; }
        public string Message { get; set; } = string.Empty;
    }
}