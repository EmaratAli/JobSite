using JobSite.Model.Common;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace JobSite.Model.Employer.PostedJob
{
    public class RequiredPerson
    {
        [Required, Display(Name = "Required Person Id")]
        public int RequiredPersonId { get; set; }

        
        [Required, Display(Name = "Minimum Age")]
        public int MinimumAge { get; set; }

        [Required, Display(Name = "Maximum Age")]
        public int MaximumAge { get; set; }

        public ICollection<Requirement> Requirements { get; set; }
        public ICollection<RequiredGender> RequiredGenders { get; set; }
    }
}