using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EcommerceWebAsmb.Shared
{
    public class UserRegister
    {
        [Required, EmailAddress]
        public string Email { get; set; } = string.Empty;
        [StringLength(100, MinimumLength = 6)]
        public string Password { get; set; } = string.Empty;
        [Compare("Password", ErrorMessage = "The Password Doesn't match")]
        public string ConfirmPassword { get; set; } = string.Empty; 
    }
}
