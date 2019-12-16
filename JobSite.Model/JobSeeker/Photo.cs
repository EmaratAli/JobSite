using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace JobSite.Model.JobSeeker
{
    public class Photo
    {
        public int ID { get; set; }
        public byte[] Picture { get; set; }
        [ForeignKey("PersonalInformation")]
        public int PersonalInformationID { get; set; }

        public virtual PersonalInformation PersonalInformation { get; set; }
    }
}
