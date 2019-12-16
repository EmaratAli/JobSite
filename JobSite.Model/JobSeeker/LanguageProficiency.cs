using System;
using System.Collections.Generic;
using System.Text;

namespace JobSite.Model.JobSeeker
{
   public class LanguageProficiency
    {
        public int ID { get; set; }
        public string ProficiencyType { get; set; }
        public ICollection<Language> Languages { get; set; }
    }
}
