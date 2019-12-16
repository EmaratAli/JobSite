using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace JobSite.Model.JobSeeker
{
    [Table("ProfessionalCertification")]
    public class ProfessionalCertification
    {
        [Key]
        public int ID { get; set; }

        [Required]
        public string Certification { get; set; }

        [Required]
        public string Institute { get; set; }
        public string Location { get; set; }

        [Required]
        public DateTime StartPeriod { get; set; }

        [Required]
        public DateTime EndPeriod { get; set; }

        [ForeignKey("PersonalInformation")]
        public int PersonalInformationID { get; set; }

        public virtual PersonalInformation PersonalInformation { get; set; }

        public virtual ICollection<JobSeekerProfessionalCertificate> JobSeekerProfessionalCertificates { get; set; }

    }
}
