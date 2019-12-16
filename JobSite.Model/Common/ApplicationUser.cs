using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Authorization;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;
using Microsoft.AspNetCore.Identity;
using JobSite.Model.JobSeeker;

namespace JobSite.Model.Common
{
    public class ApplicationUser : IdentityUser
    {
        [Display(Name = "Token")]
        public string Token { get; set; }

        public virtual PersonalInformation PersonalInformation { get; set; }
    }
}
