using JobSite.Model.Common;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace JobSite.Model.JobSeeker
{
    [Table("TrainingInformation")]
    public class Training
    {
        [Key]
        public int TrainingID { get; set; }

        [Required]
        public string Title { get; set; }
        public string TopicCovered { get; set; }

        [Required]
        public string Institute { get; set; }
        public string Location { get; set; }

        [Required]
        [ForeignKey("Country")]
        public int CountryID { get; set; }

        [Required]
        public string Year { get; set; }

        [Required]
        public string Duration { get; set; }

        [Required]
        [ForeignKey("PersonalInformation")]
        public int PersonalInformationID { get; set; }


        public virtual ICollection<JobSeekerTraining> JobSeekerTrainings { get; set; }
        public virtual Country Country { get; set; }
        public virtual PersonalInformation PersonalInformation { get; set; }
    }
}
