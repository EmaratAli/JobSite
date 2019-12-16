using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace JobSite.Model.Employer.PostedJob
{
    public class RequiredExperience
    {
        [Required, Display(Name = "Experience Id")]
        public int ExperienceId { get; set; }

        [Required, Display(Name = "Minimum Years")]
        public int MinimumYears { get; set; }

        [Required, Display(Name = "Maximum Years")]
        public int MaximumYears { get; set; }

        [Required, Display(Name = "Fresher Allowed")]
        public bool FresherAllowed { get; set; }

        [Required, Display(Name = "Area Of Experience")]
        public string AreaOfExperience { get; set; }

        [Required, Display(Name = "Area Of Business")]
        public string AreaOfBusiness { get; set; }

        [Required, Display(Name = "Requirement Id")]
        [ForeignKey("Requirement")]
        public int RequirementId { get; set; }


        public virtual Requirement Requirement { get; set; }

    }
}