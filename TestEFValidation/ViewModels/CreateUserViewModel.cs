using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace TestEFValidation.ViewModels
{
    public class CreateUserViewModel
    {
        [Required]
        [MinLength(3)]
        public string FirstName { get; set; }
        [Required]
        [MinLength(3)]
        public string LastName { get; set; }
        
        [MinLength(6)]
        public string Password { get; set; }
        [Compare("Password")]
        public string ConfirmPassword { get; set; }
    }
}