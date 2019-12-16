using System;
using System.Collections.Generic;
using System.Text;

namespace JobSite.Model.JobSeeker
{

    public class JobSeekerProfessionalCertificate
    {
        public int ID { get; set; }

        public int ProfessionalCertificationID { get; set; }
        public int PersonalInformationID { get; set; }

        public virtual ProfessionalCertification ProfessionalCertification { get; set; }
        public virtual PersonalInformation PersonalInformation { get; set; }

    }
}
