using CE.Domain.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CE.Application.DTOs
{
    public class CompanyDto
    {
        public int Id { get; set; }

        public string? CompanyName { get; set; }

        public int? AddressId { get; set; }

        public string? RCNumber { get; set; }

        public string? ContactNumber { get; set; }

        public string? EmailAddress { get; set; }

    }
}
