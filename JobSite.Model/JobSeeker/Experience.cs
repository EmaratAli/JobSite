using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace JobSite.Model.JobSeeker
{
    public class Experience
    {
        public int ID { get; set; }
        public string CompanyName { get; set; }
        public string Designation { get; set; }
        public string Department { get; set; }
        public string Responsibilities { get; set; }
        public string CompanyLocation { get; set; }

        [Required]
        public DateTime StartPeriod { get; set; }

        [Required]
        public DateTime EndPeriod { get; set; }

        [ForeignKey("PersonalInformation")]
        public int PersonalInformationID { get; set; }

        public virtual PersonalInformation PersonalInformation { get; set; }


    }
}
