using JobSite.Model.Common;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace JobSite.Model.Employer.PostedJob
{
    public class Requirement
    {
        [Required, Display(Name = "Requirement Id")]
        public int RequirementId { get; set; }
        
        [Required, Display(Name = "Other Educational Qualification")]
        public string OtherEducationalQualification { get; set; }

        [Required]
        public string Training { get; set; }

        [Required, Display(Name = "Professional Certification")]
        public string ProfessionalCertification { get; set; }

        [Required, Display(Name = "Additional Requirements")]
        public string AdditionalRequirements { get; set; }

        [Required, Display(Name = "Required Person Id")]
        [ForeignKey("RequiredPerson")]
        public int RequiredPersonId { get; set; }

        public virtual RequiredPerson RequiredPerson { get; set; }
        

        public ICollection<Degree> Degrees { get; set; }
        public ICollection<RequiredExperience> RequiredExperiences { get; set; }
        public ICollection<JobInformation> JobInformation { get; set; }
        public ICollection<RequiredSkill> RequiredSkills { get; set; }
    }
}