using System;
using System.Collections.Generic;
using System.Text;

namespace JobSite.Model.JobSeeker
{
    public class JobSeekerTraining
    {
        public int ID { get; set; }
        public int TrainingID { get; set; }
        public int PersonalInformationID { get; set; }

        public virtual Training Training { get; set; }
        public virtual PersonalInformation PersonalInformation { get; set; }
    }
}
