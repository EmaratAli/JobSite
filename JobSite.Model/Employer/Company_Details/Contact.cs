using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace JobSite.Model.Employer.Company_Details
{
    public class Contact
    {
        [Required, Display(Name = "Contact Id")]
        public int ContactId { get; set; }

        [Required, Display(Name = "Person Name")]
        public string PersonName { get; set; }

        [Required]
        public string Designation { get; set; }

        [Required]
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }

        [Required]
        public int Phone { get; set; }

        [Required, Display(Name = "Company Details Id")]
        [ForeignKey("CompanyDetails")]
        public int CompanyDetailsId { get; set; }
        public virtual CompanyDetails CompanyDetails { get; set; }

    }
}