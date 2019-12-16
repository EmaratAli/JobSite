using System;
using System.Collections.Generic;
using System.Text;

namespace JobSite.Model.ViewModel
{
    public class ApplicationRole
    {
        public string ID { get; set; }
        public string Name { get; set; }
        public string NormalizedName { get; set; }

        public ApplicationRole()
        {

        }

        public ApplicationRole(string id, string name, string normalizedName) : this()
        {
            ID = id;
            Name = name;
            NormalizedName = normalizedName;
        }
    }
}
