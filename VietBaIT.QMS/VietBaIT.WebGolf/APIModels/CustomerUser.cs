using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace VietBaIT.WebGolf.APIModels
{
    public class CustomerUser
    {
      
        [Required]
        public string FullName { get; set; }
        [Required]
        public string PhoneNumber { get; set; }
        public byte Gender { get; set; }
        public DateTime DateOfBirth { get; set; }
        public string AddressDetail { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
    }
}
