using JobSite.Model.JobSeeker;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace JobSite.Model.Common
{
    public class District
    {
        public int DistrictId { get; set; }
        public string DistrictName { get; set; }
        [ForeignKey("Country")]
        public int CountryId { get; set; }

        public ICollection<Thana> Thanas { get; set; }
        public virtual Country Country { get; set; }
        public virtual ICollection<JobSeekerPreferredLocation> JobSeekerPreferredLocations { get; set; }

    }
}