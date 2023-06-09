using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CE.Application.DTOs.DtoForCreation
{
    public class AddressDtoForCreation
    {
        [Required(ErrorMessage = "Building number is required")]
        [MaxLength(5, ErrorMessage = "Building number must be at most 5 characters")]
        public string? BuildingNumber { get; set; }

        [Required(ErrorMessage = "Street Name is required")]
        [MaxLength(50, ErrorMessage = "Street name must be at most 50 characters")]
        public string? StreetName { get; set; }

        [Required(ErrorMessage = "State is required")]
        [MaxLength(25, ErrorMessage = "State must be at most 25 characters")]
        public string? State { get; set; }

        [MaxLength(50, ErrorMessage = "Country must be at most 50 characters")]
        public string? Country { get; set; }
    }
}
