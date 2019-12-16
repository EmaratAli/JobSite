using JobSite.Model.Employer.PostedJob;
using JobSite.Model.JobSeeker;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace JobSite.Model.Common
{
    public class JobCategory
    {
        public int JobCategoryId { get; set; }
        [Required, Display(Name = "Job Category Name")]
        public string JobCategoryName { get; set; }
        [Required, Display(Name = "Job Category Type Id")]
        [ForeignKey("JobCategoryType")]
        public int JobCategoryTypeId { get; set; }

        public virtual JobCategoryType JobCategoryType { get; set; }
        public virtual ICollection<JobInformation> JobInformation { get; set; }
        public virtual ICollection<PreferredJobCategory> PreferredJobCategories { get; set; }

    }
}
