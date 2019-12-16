using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;
using JobSite.Model.Common;

namespace JobSite.Model.JobSeeker
{
    [Table("CareerInformation")]
    public class CareerInformation
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ID { get; set; }

        [Required]
        public string Objective { get; set; }

        [Column(TypeName = "MONEY"), DataType(DataType.Currency), Display(Name = "Present Salary")]
        public decimal PresentSalary { get; set; }

        [Column(TypeName = "MONEY"), DataType(DataType.Currency), Display(Name = "Expected Salary")]
        public decimal ExpectedSalary { get; set; }

        

        [ForeignKey("JobLevel")]
        public int JobLevelID { get; set; }

        [ForeignKey("JobNature")]
        public int JobNatureID { get; set; }

        [Display(Name = "Carrer Summary")]
        public string CarrerSummary { get; set; }

        [Display(Name = "Special Qualification")]
        public string SpecialQualification { get; set; }

        [Display(Name = "Keywords")]
        public string Keywords { get; set; }

        [ForeignKey("PersonalInformation")]
        public int PersonalInfoID { get; set; }

        public virtual JobLevel JobLevel { get; set; }
        public virtual JobNature JobNature { get; set; }
        public virtual PersonalInformation PersonalInformation { get; set; }
    }
}
