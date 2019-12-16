using JobSite.Model.Employer.PostedJob;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace JobSite.Model.Employer.Company_Details
{
    public class CompanyDetails
    {
        [Required, Display(Name = "Company Details Id")]
        public int CompanyDetailsId { get; set; }

        [Required, Display(Name = "Company Name")]
        public string CompanyName { get; set; }

        [Required, Display(Name = "User Name")]
        public string UserName { get; set; }

        [Required]
        [DataType(DataType.Password)]
        public string Password { get; set; }



        [Required, Display(Name = "Business Description")]
        public string BusinessDescription { get; set; }

        [Required, Display(Name = "License No")]
        public string LicenseNo { get; set; }

        [Required]
        [DataType(DataType.Url)]
        public string WebSite { get; set; }
        //FK
        public ICollection<Address> Addresses { get; set; }
        public ICollection<Contact> Contacts { get; set; }
        public ICollection<JobInformation> JobInformation { get; set; }
        public ICollection<IndustryTypeDetails> IndustryTypeDetails  { get; set; }

    }
}