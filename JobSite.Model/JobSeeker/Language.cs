using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace JobSite.Model.JobSeeker
{
    public class Language
    {
        public int ID { get; set; }
        public string LanguageName { get; set; }
        [ForeignKey("LanguageProficiency")]
        public int Reading { get; set; }
        [ForeignKey("LanguageProficiency")]
        public int Writing { get; set; }
        [ForeignKey("LanguageProficiency")]
        public int Speaking { get; set; }


        [ForeignKey("PersonalInformation")]
        public int PersonalInformationID { get; set; }

        public virtual PersonalInformation PersonalInformation { get; set; }
        public virtual LanguageProficiency LanguageProficiency { get; set; }
    }
}
