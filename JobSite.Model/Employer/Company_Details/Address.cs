using JobSite.Model.Common;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace JobSite.Model.Employer.Company_Details
{
    public class Address
    {
        [Required, Display(Name = "Address Id")]
        public int AddressId { get; set; }

        [Required, Display(Name = "Thana Id")]
        [ForeignKey("Thana")]
        public int ThanaId { get; set; }

        [Required, Display(Name = "Company Address")]
        public string CompanyAddress { get; set; }

        [Required, Display(Name = "Company Details Id")]
        [ForeignKey("CompanyDetails")]
        public int CompanyDetailsId { get; set; }

        public virtual CompanyDetails CompanyDetails { get; set; }
        public virtual Thana Thana { get; set; }

    }
}