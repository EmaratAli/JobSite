using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace JobSite.Model.Employer.PostedJob
{
    public class Degree
    {
        [Required, Display(Name = "Degree Id")]
        public int DegreeId { get; set; }

        [Required, Display(Name = "Degree Name Id")]
        [ForeignKey("DegreeName")]
        public int DegreeNameId { get; set; }

        [Required]
        public string Major { get; set; }

        [Required, Display(Name = "Requirement Id")]
        [ForeignKey("Requirement")]
        public int RequirementId { get; set; }


        public virtual Requirement Requirement { get; set; }

        public virtual DegreeName DegreeName { get; set; }

    }
}