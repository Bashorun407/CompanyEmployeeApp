using CE.Domain.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CE.Application.DTOs.DtoForDisplay
{
    public class EmployeeDtoForUpdate
    {
        public int Id { get; set; }

        public string? FirstName { get; set; }

        public string? LastName { get; set; }

        public int? CompanyId { get; set; }

        public int? AddressId { get; set; }

        public char Gender { get; set; }

        public DateTime DateOfBirth { get; set; }

        public DateTime DateJoined { get; set; } 

        public DateTime DateLeft { get; set; }

    }
}
