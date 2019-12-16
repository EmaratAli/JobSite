using JobSite.Model.Employer.PostedJob;
using System;
using System.Collections.Generic;
using System.Text;

namespace JobSite.Model.Common
{
    public class EmploymentStatus
    {
        public int EmploymentStatusId { get; set; }
        public string StatusType { get; set; }

        public ICollection<EmploymentRequiredStatus> EmploymentRequiredStatuses { get; set; }
    }
}
