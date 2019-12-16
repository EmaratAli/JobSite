using JobSite.Model.Common;
using JobSite.Model.Employer.Company_Details;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace JobSite.Model.Employer.PostedJob
{
    public class JobInformation
    {
        [Required, Display(Name = "Job Information Id")]
        public int JobInformationId { get; set; }
        [Required, Display(Name = "Company Id")]
        [ForeignKey("CompanyDetails")]
        public int CompanyDetailsId { get; set; }


        [Required, Display(Name = "Service Type")]
        public string ServiceType { get; set; }

        [Required, Display(Name = "Job Title")]
        public string JobTitle { get; set; }

        [Required, Display(Name = "No Of Vacancy")]
        public int NoOfVacancy { get; set; }

        //Functional Catagory  Or Special Skill Category
        [Required, Display(Name = "Job Category")]
        [ForeignKey("JobCategory")]
        public int JobCategoryId { get; set; }

        

        [Required, Display(Name = "Application Dead Line")]
        public DateTime ApplicationDeadLine { get; set; }

        [Required, Display(Name = "Resume Option")]
        public string ResumeOption { get; set; }

        [Required, Display(Name = "Special Instruction")]
        public string SpecialInstruction { get; set; }

        [Required]
        public bool Photograph { get; set; }

        

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

        [Required, Display(Name = "Requirement Id")]
        [ForeignKey("Requirement")]
        public int RequirementId { get; set; }

        public virtual Requirement Requirement { get; set; }
        public virtual CompanyDetails CompanyDetails { get; set; }
        public virtual JobCategory JobCategory { get; set; }
        public ICollection<EmploymentRequiredStatus>  EmploymentRequiredStatuses{ get; set; }
        public ICollection<RequiredJobLevel> RequiredJobLevels{ get; set; }
    }
}