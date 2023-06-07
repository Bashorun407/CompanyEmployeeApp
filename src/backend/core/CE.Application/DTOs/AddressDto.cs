using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CE.Application.DTOs
{
    public class AddressDto
    {
        public int Id { get; set; }

        public string? BuildingNumber { get; set; }

        public string? StreetName { get; set; }

        public string? State { get; set; }

        public string? Country { get; set; }

    }
}
