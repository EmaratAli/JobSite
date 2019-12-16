using JobSite.Model.Employer.Company_Details;
using JobSite.Model.Employer.PostedJob;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace JobSite.Model.Employer.ViewModelsEmployer
{
    public class CompanyDetailsVm
    {
        public int ID { get; set; }

        [Required, Display(Name = "Company Name")]
        public string CompanyName { get; set; }

        [Required, Display(Name = "User Name")]
        public string UserName { get; set; }

        [Required]
        [DataType(DataType.Password)]
        public string Password { get; set; }

        [Required, Display(Name = "Country Id")]
        public int CountryId { get; set; }

        [Required, Display(Name = "District Id")]
        public int DistrictId { get; set; }

        [Required, Display(Name = "Thana Id")]
        public int ThanaId { get; set; }

        [Required, Display(Name = "Company Address")]
        public string CompanyAddress { get; set; }

        [Required, Display(Name = "Industry Type Id")]
        public int IndustryTypeId { get; set; }

        [Required, Display(Name = "Business Description")]
        public string BusinessDescription { get; set; }

        [Required, Display(Name = "License No")]
        public string LicenseNo { get; set; }
                     
        [Required]
        [DataType(DataType.Url)]
        public string WebSite { get; set; }

        [Required, Display(Name = "Person Name")]
        public string PersonName { get; set; }

        [Required]
        public string Designation { get; set; }

        [Required]
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }

        [Required]
        public int Phone { get; set; }
    }
}
