using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace JobSite.Model.Employer.PostedJob
{
    public class DegreeLevel
    {
        [Required, Display(Name = "Degree Level Id")]
        public int DegreeLevelId { get; set; }

        [Required, Display(Name = "Degree Level Name")]
        public string DegreeLevelName { get; set; }

        public ICollection<DegreeName> DegreeNames { get; set; }

    }
}