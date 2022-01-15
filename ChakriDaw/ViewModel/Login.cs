using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ChakriDaw.ViewModel
{
    public class Login
    {
        [Required(ErrorMessage = "Email can't be empty")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Password can't be empty")]
        [MaxLength(50, ErrorMessage = "Password length can't be more than 50")]
        [MinLength(8, ErrorMessage = "Password length can't be less than 8")]
        public string Password { get; set; }
    }
}