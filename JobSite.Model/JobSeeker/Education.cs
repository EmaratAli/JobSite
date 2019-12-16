using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace JobSite.Model.JobSeeker
{
    public class Education
    {
        public int ID { get; set; }

        [Required, Display(Name = "Exam/Degree Title")]
        [ForeignKey("EducationTitle")]
        public int EducationTitleID { get; set; }

        [Required, Display(Name = "Concentration/Major/Group")]
        public string Group { get; set; }

        [Required, Display(Name = "Institute Name")]
        public string Institute { get; set; }

        [Required, Display(Name = "Result(GPA)")]
        public decimal Result { get; set; }

        [Required, Display(Name = "Scale")]
        public decimal Scale { get; set; }

        [Required, Display(Name = "Passing Year")]
        public int PassingYear { get; set; }

        [Display(Name = "Duration (Years)")]
        public string Duration { get; set; }

        [Required, Display(Name = "Personal Information")]
        [ForeignKey("PersonalInformation")]
        public int PersonalInformationID { get; set; }

        public virtual EducationTitle EducationTitle { get; set; }
        public virtual PersonalInformation PersonalInformation { get; set; }

    }
}
