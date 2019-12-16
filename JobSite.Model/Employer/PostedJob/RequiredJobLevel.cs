using JobSite.Model.Common;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace JobSite.Model.Employer.PostedJob
{
    public class RequiredJobLevel
    {
        public int RequiredJobLevelId { get; set; }
        [ForeignKey("JobLevel")]
        public int JobLevelId { get; set; }
        [ForeignKey("JobInformation")]
        public int JobInformationId { get; set; }

        public virtual JobInformation JobInformation { get; set; }
        public virtual JobLevel JobLevel { get; set; }
    }
}
