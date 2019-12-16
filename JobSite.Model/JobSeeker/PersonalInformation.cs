using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;
using JobSite.Model.Common;

namespace JobSite.Model.JobSeeker
{
    [Table("PersonalInformation")]
    public class PersonalInformation
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ID { get; set; }

        [Required, Display(Name = "First Name")]
        public string FirstName { get; set; }

        [Required, Display(Name = "Last Name")]
        public string LastName { get; set; }

        [Required, Display(Name = "Father's Name")]
        public string FatherName { get; set; }

        [Required, Display(Name = "Mother's Name")]
        public string MotherName { get; set; }

        [Required, Column(TypeName = "DATE"), Display(Name = "Date of Birth"), DataType(DataType.Date)]
        public DateTime BirthDate { get; set; }

        [Display(Name = "National ID No")]
        public string NationalIdNo { get; set; }

        [Display(Name = "Passport Number")]
        public string PassportNumber { get; set; }

        [Column(TypeName = "DATE"), Display(Name = "Passport Issue Date"), DataType(DataType.Date)]
        public DateTime PassportIssueDate { get; set; }

        [Required, Display(Name = "Mobile No. 1"), DataType(DataType.PhoneNumber)]
        public string MobileNoOne { get; set; }

        [Display(Name = "Mobile No. 2"), DataType(DataType.PhoneNumber)]
        public string MobileNoTwo { get; set; }

        [Display(Name = "Mobile No. 3"), DataType(DataType.PhoneNumber)]
        public string MobileNoThree { get; set; }

        [Required, DataType(DataType.EmailAddress)]
        public string Email { get; set; }

        [Display(Name = "Alternate Email"), DataType(DataType.EmailAddress)]
        public string AlternateEmail { get; set; }

        [Display(Name = "Present Address")]
        public string PresentAddress { get; set; }

        [Display(Name = "Permanent Address")]
        public string PermanentAddress { get; set; }

        [ForeignKey("Gender")]
        public int GenderID { get; set; }

        [ForeignKey("Religion")]
        public int ReligionID { get; set; }

        [ForeignKey("MaritalStatus")]
        public int MaritalStatusID { get; set; }

        [ForeignKey("Nationality")]
        public int NationalityID { get; set; }

        [ForeignKey("ApplicationUser")]
        public string UserID { get; set; }








        public virtual ApplicationUser ApplicationUser { get; set; }
        public virtual Gender Gender { get; set; }
        public virtual Religion Religion { get; set; }
        public virtual MaritalStatus MaritalStatus { get; set; }
        public virtual Nationality Nationality { get; set; }
        public virtual CareerInformation CareerInformation { get; set; }




        public virtual ICollection<ProfessionalCertification> ProfessionalCertification { get; set; }
        public virtual ICollection<Training> TrainingInformation { get; set; }
        public virtual ICollection<JobSeekerTraining> JobSeekerTrainings { get; set; }
        public virtual ICollection<JobSeekerProfessionalCertificate> JobSeekerProfessionalCertificates { get; set; }
        public virtual ICollection<JobSeekerPreferredLocation> JobSeekerPreferredLocations { get; set; }
        public virtual ICollection<PreferredJobCategory> PreferredJobCategories { get; set; }
        public virtual ICollection<Experience> Experiences { get; set; }
        public virtual ICollection<JobSeekerSkill> JobSeekerSkills { get; set; }
        public virtual ICollection<References> References { get; set; }
        public virtual ICollection<Photo> Photos { get; set; }


    }
}
