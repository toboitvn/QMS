using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace VietBaIT.WebGolf.APIModels
{
    public class UserModelForgotPassword
    {
        [Required]
        public string PhoneNumber { get; set; }
        [Required]
        public string NewPasword { get; set; }
    }
}
