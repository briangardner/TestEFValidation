using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace TestEFValidation.DAL
{
    public sealed class UserMetadata
    {
        [Required]
        [MinLength(3)]
        public string FirstName { get; set; }

        [Required]
        [MinLength(3)]
        public string LastName { get; set; }
    }

    [MetadataType(typeof(UserMetadata))]
    public partial class User
    {
        public string ConfirmPassword { get; set; }
    }
}