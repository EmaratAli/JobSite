using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace JobSite.Model.JobSeeker.ViewModel
{
    class JobSeekerVM
    {
        public int ID { get; set; }

        /// <summary>
        /// Personal Information
        /// </summary>

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


        [Required, Display(Name = "Gender")]
        public int GenderID { get; set; }

        [Required, Display(Name = "Religion")]
        public int ReligionID { get; set; }

        [Required, Display(Name = "Marital Status")]
        public int MaritalStatusID { get; set; }

        [Required, Display(Name = "Nationality")]
        public int NationalityID { get; set; }
        [Display(Name = "Present Address")]
        public string PresentAddress { get; set; }

        [Display(Name = "Permanent Address")]
        public string PermanentAddress { get; set; }

        /// <summary>
        /// Carrer Information
        /// </summary>

        public string Objective { get; set; }

        [Column(TypeName = "MONEY"), DataType(DataType.Currency), Display(Name = "Present Salary")]
        public decimal PresentSalary { get; set; }

        [Column(TypeName = "MONEY"), DataType(DataType.Currency), Display(Name = "Expected Salary")]
        public decimal ExpectedSalary { get; set; }

        [Display(Name = "Looking for (Job Level)")]
        public int JobLevelID { get; set; }

        [Display(Name = "Available for (Job Nature)")]

        public int JobNatureID { get; set; }

        [Required, Display(Name = "Preferred Job Categories")]
        public int JobCategoryId { get; set; }

        [Required, Display(Name = "Preferred Job Location")]
        public int DistrictID { get; set; }


        [Display(Name = "Carrer Summary")]
        public string CarrerSummary { get; set; }

        [Display(Name = "Special Qualification")]
        public string SpecialQualification { get; set; }

        [Display(Name = "Keywords")]
        public string Keywords { get; set; }

        /// <summary>
        /// Education
        /// </summary>

        [Required, Display(Name = "Concentration/Major/Group")]
        public string Group { get; set; }

        [Required, Display(Name = "Institute Name")]
        public string EducationalInstitute { get; set; }

        [Required, Display(Name = "Result(GPA)")]
        public decimal Result { get; set; }

        [Required, Display(Name = "Scale")]
        public decimal Scale { get; set; }

        [Required, Display(Name = "Passing Year")]
        public int PassingYear { get; set; }

        [Display(Name = "Duration (Years)")]
        public string Duration { get; set; }


        /// <summary>
        /// Training
        /// </summary>

        [Required]
        public string Title { get; set; }
        public string TopicCovered { get; set; }

        [Required]
        public string Institute { get; set; }
        public string Location { get; set; }

        [Required]
        public int Country { get; set; }

        [Required]
        public int Year { get; set; }

        [Required]
        public string TrainingDuration { get; set; }


        /// <summary>
        /// Professional Qualification
        /// </summary>

        [Required]
        public string Certification { get; set; }

        [Required]
        public string ProfessionalQualificationInstitute { get; set; }
        public string ProfessionalQualificationLocation { get; set; }

        [Required]
        public DateTime ProfessionalQualificationStartPeriod { get; set; }

        [Required]
        public DateTime ProfessionalQualificationEndPeriod { get; set; }


        /// <summary>
        /// Experience
        /// </summary>

        public string CompanyName { get; set; }
        public string Designation { get; set; }
        public string Department { get; set; }
        public string Responsibilities { get; set; }
        public string CompanyLocation { get; set; }

        [Required]
        public DateTime ExperienceStartPeriod { get; set; }

        [Required]
        public DateTime ExperienceEndPeriod { get; set; }


        /// <summary>
        /// Job Seeker Skill
        /// </summary>

        public int JobSeekerSkill { get; set; }


        /// <summary>
        /// Language Proficiency
        /// </summary>
        public string LanguageName { get; set; }
        public int Reading { get; set; }
        public int Writing { get; set; }
        public int Speaking { get; set; }


        /// <summary>
        /// Reference
        /// </summary>
        public string Name { get; set; }
        public string ReferenceDesignation { get; set; }
        public string Mobile { get; set; }
        public string ReferenceEmail { get; set; }
        public string Relation { get; set; }
        public string Organization { get; set; }
        public string Address { get; set; }

        /// <summary>
        /// Photo
        /// </summary>
        public byte[] Picture { get; set; }


    }
}
