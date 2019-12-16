using JobSite.Model.Common;
using JobSite.Model.Employer;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace JobSite.Model.JobSeeker
{
    [Table("PreferredJobAreas")]
    public class JobSeekerPreferredLocation
    {
        public int ID { get; set; }

        [ForeignKey("PersonalInformation")]
        public int PersonalInformationID { get; set; }

        [ForeignKey("District")]
        public int DistrictID { get; set; }
        public virtual District Districts { get; set; }

        public virtual PersonalInformation PersonalInformations { get; set; }
    }
}
