using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace JobSite.Model.JobSeeker
{
    public class References
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Designation { get; set; }
        public string Mobile { get; set; }
        public string Email { get; set; }
        public string Relation { get; set; }
        public string Organization { get; set; }
        public string Address { get; set; }
        [ForeignKey("PersonalInformation")]
        public int PersonalInformationID { get; set; }

        public virtual PersonalInformation PersonalInformation { get; set; }
    }
}
