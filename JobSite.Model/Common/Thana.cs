using JobSite.Model.Employer.Company_Details;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace JobSite.Model.Common
{
    public class Thana
    {
        public int ThanaId { get; set; }
        public string ThanaName { get; set; }

        [ForeignKey("District")]
        public int DistrictId { get; set; }

        public virtual District District { get; set; }

        public ICollection<Address> Addresses { get; set; }
    }
}