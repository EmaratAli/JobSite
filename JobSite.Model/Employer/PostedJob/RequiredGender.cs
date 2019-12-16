using JobSite.Model.Common;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace JobSite.Model.Employer.PostedJob
{
    public class RequiredGender
    {
        public int RequiredGenderId { get; set; }
        [ForeignKey("Gender")]
        public int GenderId { get; set; }

        [ForeignKey("RequiredPerson")]
        public int RequiredPersonId { get; set; }

        public virtual Gender Gender { get; set; }
        public virtual RequiredPerson RequiredPerson  { get; set; }
    }
}
