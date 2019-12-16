using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace JobSite.Model.Common
{
    public class JobCategoryType
    {
        public int JobCategoryTypeId { get; set; }
        [Required, Display(Name = "Job Category")]
        public int JobCategoryTypeName { get; set; }

        public ICollection<JobCategory> JobCategories { get; set; }
    }
}
