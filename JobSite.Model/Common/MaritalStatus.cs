using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;
using JobSite.Model.JobSeeker;

namespace JobSite.Model.Common
{
    [Table("MaritalStatus")]
    public class MaritalStatus
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ID { get; set; }

        [Required]
        public string Name { get; set; }

        public virtual ICollection<PersonalInformation> PersonalInformations { get; set; }
    }
}
