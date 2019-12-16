using JobSite.Model.Common;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace JobSite.Model.Employer.PostedJob
{
    public class EmploymentRequiredStatus
    {
        public int EmploymentRequiredStatusId { get; set; }
        [ForeignKey("EmploymentStatus")]
        public int EmploymentStatusId { get; set; }

        [ForeignKey("JobInformation")]
        public int JobInformationId { get; set; }

        public virtual EmploymentStatus EmploymentStatus { get; set; }
        public virtual JobInformation JobInformation { get; set; }

    }
}
