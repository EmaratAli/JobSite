using JobSite.Model.Common;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace JobSite.Model.JobSeeker
{
    public class PreferredJobCategory
    {
        public int ID { get; set; }

        [ForeignKey("JobCategory")]
        [Required, Display(Name = "Job Category")]
        public int JobCategoryId { get; set; }

        [ForeignKey("PersonalInformation")]
        [Required, Display(Name = "Personal Information")]
        public int PersonalInformationID { get; set; }

        public virtual PersonalInformation PersonalInformation { get; set; }
        public virtual JobCategory JobCategory { get; set; }
    }
}
