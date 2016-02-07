using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace SmokeyWebSite.Models
{
    public class ContactViewModel
    {
        [Required]
        [StringLength(255, MinimumLength = 3)]
        public string Name { get; set; }

        [Required]
        [EmailAddress]
        public string EmailAdress { get; set; }

        [Required]
        [Phone]
        public string PhoneNumber { get; set; }

        [Required]
        [StringLength(1000, MinimumLength = 5)]
        public string Message { get; set; }
    }
}