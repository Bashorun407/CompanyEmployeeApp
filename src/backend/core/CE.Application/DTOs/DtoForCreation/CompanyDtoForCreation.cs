using CE.Domain.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CE.Application.DTOs.DtoForCreation
{
    public class CompanyDtoForCreation
    {
        [Required(ErrorMessage = "Company name is required")]
        [MaxLength(25, ErrorMessage = "The length must be at most 25 characters")]
        public string? CompanyName { get; set; }

        [ForeignKey(nameof(Address))]
        public int? AddressId { get; set; }

        [Required(ErrorMessage = "RC Number is required")]
        [MaxLength(10, ErrorMessage = "RC Number must be at most 10 characters")]
        public string? RCNumber { get; set; }

        [DataType(DataType.PhoneNumber)]
        public string? ContactNumber { get; set; }

        [DataType(DataType.EmailAddress)]
        public string? EmailAddress { get; set; }

    }
}
