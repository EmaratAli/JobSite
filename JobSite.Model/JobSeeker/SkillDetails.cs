using JobSite.Model.Common;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace JobSite.Model.JobSeeker
{
    public class JobSeekerSkill
    {
        public int SkillDetailsId { get; set; }
        [ForeignKey("Skill")]
        public int SkillId { get; set; }
        

        [ForeignKey("PersonalInformation")]
        public int PersonalInformationID { get; set; }

        public virtual PersonalInformation PersonalInformation { get; set; }

        public virtual Skill  Skill{ get; set; } 
    }
}
