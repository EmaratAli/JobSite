using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;
using JobSite.Model.Employer.PostedJob;
using JobSite.Model.JobSeeker;

namespace JobSite.Model.Common
{
    [Table("JobLevel")]
    public class JobLevel   //entry,mid,top
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int JobLevelId { get; set; }

        [Required]
        public string JobLevelName { get; set; }

        public virtual ICollection<CareerInformation> CareerInformations { get; set; }
        public virtual ICollection<RequiredJobLevel> RequiredJobLevels { get; set; }
    }
}
