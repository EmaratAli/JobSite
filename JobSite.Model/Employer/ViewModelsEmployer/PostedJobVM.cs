using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace JobSite.Model.Employer.ViewModelsEmployer
{
    class PostedJobVM
    {
        public int ID { get; set; }

        [Required, Display(Name = "Company Id")]
        public int CompanyDetailsId { get; set; }

        /// <summary>
        /// Job Information
        /// </summary>
        [Required, Display(Name = "Service Type")]
        public string ServiceType { get; set; }

        [Required, Display(Name = "Job Title")]
        public string JobTitle { get; set; }

        [Required, Display(Name = "No Of Vacancy")]
        public int NoOfVacancy { get; set; }

        [Required, Display(Name = "Job Category")]
        public int JobCategoryId { get; set; }

        [Required, Display(Name = "Employment Status")]
        public int EmploymentStatusId { get; set; }

        [Required, Display(Name = "Application Dead Line")]
        public DateTime ApplicationDeadLine { get; set; }

        [Required, Display(Name = "Resume Option")]
        public string ResumeOption { get; set; }

        [Required, Display(Name = "Special Instruction")]
        public string SpecialInstruction { get; set; }

        [Required]
        public bool Photograph { get; set; }

        [Required, Display(Name = "Job Level")]
        public int JobLevelId { get; set; }

        [Required, Display(Name = "Job Context")]
        public string JobContext { get; set; }

        [Required, Display(Name = "Job Responsibility")]
        public string JobResponsibility { get; set; }

        [Required, Display(Name = "Job Location")]
        public string JobLocation { get; set; }

        [Required]
        public decimal Salary { get; set; }

        [Required]
        public decimal Bonus { get; set; }

        /// <summary>
        /// Requirement
        /// </summary>

        [Required, Display(Name = "Degree Level")]
        public int DegreeLevelId { get; set; }
       
        [Required, Display(Name = "Degree Name")]
        public int DegreeNameId { get; set; }

        [Required]
        public string Major { get; set; }

        [Required, Display(Name = "Other Educational Qualification")]
        public string OtherEducationalQualification { get; set; }

        [Required]
        public string Training { get; set; }

        [Required, Display(Name = "Professional Certification")]
        public string ProfessionalCertification { get; set; }

        [Required, Display(Name = "Minimum Years")]
        public int MinimumYears { get; set; }

        [Required, Display(Name = "Maximum Years")]
        public int MaximumYears { get; set; }

        [Required, Display(Name = "Fresher Allowed")]
        public bool FresherAllowed { get; set; }

        [Required, Display(Name = "Area Of Experience")]
        public string AreaOfExperience { get; set; }

        [Required, Display(Name = "Area Of Business")]
        public string AreaOfBusiness { get; set; }

        [Required, Display(Name = "Skill")]
        public int SkillId { get; set; }
        [Required, Display(Name = "Additional Requirements")]
        public string AdditionalRequirements { get; set; }

        [Required, Display(Name = "Gender")]
        public int GenderId { get; set; }

        [Required, Display(Name = "Minimum Age")]
        public int MinimumAge { get; set; }

        [Required, Display(Name = "Maximum Age")]
        public int MaximumAge { get; set; }
    }
}
