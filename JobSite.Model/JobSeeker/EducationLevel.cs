using System;
using System.Collections.Generic;
using System.Text;

namespace JobSite.Model.JobSeeker
{
    public class EducationLevel
    {
        public int ID { get; set; }
        public string EducationLevelName { get; set; }
        public virtual ICollection<EducationTitle> EducationTitles { get; set; }
    }
}
