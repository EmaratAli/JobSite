using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace JobSite.Model.Employer.PostedJob
{
    public class DegreeName
    {

        [Required, Display(Name = "Degree Name Id")]
        public int DegreeNameId { get; set; }

        [Required]
        public string Degree { get; set; }

        [Required, Display(Name = "Degree Level Id")]
        [ForeignKey("DegreeLevel")]
        public int DegreeLevelId { get; set; }

        public virtual DegreeLevel DegreeLevel { get; set; }

        public ICollection<Degree> Degrees { get; set; }

    }
}