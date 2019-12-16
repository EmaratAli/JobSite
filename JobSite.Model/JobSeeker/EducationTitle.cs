using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace JobSite.Model.JobSeeker
{
    public class EducationTitle
    {
        public int ID { get; set; }
        [Required, Display(Name = "Exam/Degree Title")]
        public string DegreeTitle { get; set; }

        [Required, Display(Name = "Education Level")]
        [ForeignKey("EducationLevel")]
        public int EducationLevelID { get; set; }

        public virtual EducationLevel EducationLevel { get; set; }
        public virtual ICollection<Education> Educations { get; set; }
    }
}
