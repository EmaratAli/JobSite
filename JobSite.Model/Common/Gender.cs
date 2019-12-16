using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;
using JobSite.Model.JobSeeker;
using JobSite.Model.Employer;
using JobSite.Model.Employer.PostedJob;

namespace JobSite.Model.Common
{
    [Table("Gender")]
    public class Gender
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ID { get; set; }

        [Required]
        public string Name { get; set; }

        public virtual ICollection<PersonalInformation> PersonalInformations { get; set; }

        public virtual ICollection<RequiredGender>  RequiredGenders { get; set; }
    }
}
