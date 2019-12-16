using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace JobSite.Model.ViewModel
{
    public class Registration
    {
        [Required, MaxLength(256)]
        public string UserName { get; set; }

        [Required]
        public string Password { get; set; }

        [Required, MaxLength(256)]
        public string Email { get; set; }

        [Required]
        public string PhoneNumber { get; set; }
    }
}
