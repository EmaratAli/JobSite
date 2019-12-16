using System;
using System.Collections.Generic;
using System.Text;
using JobSite.Model.Employer;
using JobSite.Model.Employer.PostedJob;
using JobSite.Model.JobSeeker;

namespace JobSite.Model.Common
{
    public class Skill
    {
        public int SkillId { get; set; }
        public string SkillType { get; set; }

        public ICollection<RequiredSkill> RequiredSkills { get; set; }
        public virtual ICollection<JobSeekerSkill> JobSeekerSkills { get; set; }

    }
}
