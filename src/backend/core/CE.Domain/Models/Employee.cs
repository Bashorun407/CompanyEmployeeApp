using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CE.Domain.Models
{
    public class Employee
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage ="First name is required")]
        [MaxLength(50,ErrorMessage ="First name must be at most 50 characters")]
        public string? FirstName { get; set; }

        [Required(ErrorMessage ="Last name is required")]
        [MaxLength(50,ErrorMessage ="Last name must be at most 50 characters")]
        public string? LastName { get; set; }

        [ForeignKey(nameof(Company))]
        public int? CompanyId { get; set; }

        [ForeignKey(nameof(Address))]
        public int? AddressId { get; set; }

        public char Gender { get; set; }

        public DateTime DateOfBirth { get; set; }

        public DateTime DateJoined { get; set; }= DateTime.UtcNow;

        public DateTime DateLeft { get; set; }

        //Navigational properties here
        public Company? Company { get; set; }
        public Address? Address { get; set; }
    }
}
