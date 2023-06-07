using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CE.Domain.Models
{
    public class Company
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage ="Company name is required")]
        [MaxLength(25, ErrorMessage ="The length must be at most 25 characters")]
        public string? CompanyName { get; set; }

        [ForeignKey(nameof(Address))]
        public int? AddressId { get; set; }

        [Required(ErrorMessage ="RC Number is required")]
        [MaxLength(10,ErrorMessage ="RC Number must be at most 10 characters")]
        public string? RCNumber { get; set; }

        [DataType(DataType.PhoneNumber)]
        public string? ContactNumber { get; set; }

        [DataType(DataType.EmailAddress)]
        public string? EmailAddress { get; set; }

        //Navigational properties here
        public Address? Address { get; set; }
        public ICollection<Employee>? Employees { get; set; }
    }
}
