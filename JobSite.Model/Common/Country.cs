using JobSite.Model.JobSeeker;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace JobSite.Model.Common
{
    public class Country
    {
        public int CountryId { get; set; }
        public string CountryName { get; set; }

        public ICollection<District> Districts { get; set; }
        public ICollection<Training> Trainings { get; set; }


    }
}