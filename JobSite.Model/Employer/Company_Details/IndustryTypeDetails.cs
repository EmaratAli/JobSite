using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace JobSite.Model.Employer.Company_Details
{
    public class IndustryTypeDetails
    {
        public int IndustryTypeDetailsId { get; set; }

        [Required, Display(Name = "Industry Type Id")]
        [ForeignKey("IndustryType")]
        public int IndustryTypeId { get; set; }

        [Required, Display(Name = "Company Details Id")]
        [ForeignKey("CompanyDetails")]
        public int CompanyDetailsId { get; set; }

        public virtual CompanyDetails CompanyDetails { get; set; }
        public virtual IndustryType IndustryType { get; set; }

    }
}
