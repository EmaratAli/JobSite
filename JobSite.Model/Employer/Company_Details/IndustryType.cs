using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace JobSite.Model.Employer.Company_Details
{
    public class IndustryType
    {
        [Required, Display(Name = "Industry Type Id")]
        public int IndustryTypeId { get; set; }

        [Required, Display(Name = "Industry Type Name")]
        public string IndustryTypeName { get; set; }



    }
}