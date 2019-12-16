using JobSite.Model.Common;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace JobSite.Model.Employer.PostedJob
{
    public class RequiredSkill
    {
        public int SkillDetailsId { get; set; }
        [ForeignKey("Skill")]
        public int SkillId { get; set; }
        [ForeignKey("Requirement")]
        public int RequirementId  { get; set; }

        public virtual Skill  Skill{ get; set; } 
        public virtual Requirement Requirement  { get; set; } 
    }
}
