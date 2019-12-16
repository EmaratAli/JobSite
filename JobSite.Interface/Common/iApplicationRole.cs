using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using JobSite.Model.Common;
using JobSite.Model.ViewModel;
using Microsoft.AspNetCore.Identity;

namespace JobSite.Interface.Common
{
    public interface iApplicationRole
    {
        IdentityRole CreateApplicationRole(ApplicationRole applicationRole);
        IQueryable<ApplicationRole> ApplicationRoles { get; }

        IQueryable<ApplicationRole> GetApplicationRole(string id);
        Task<ApplicationRole> PostApplicationRole(ApplicationRole applicationRole);
        Task<int> PutApplicationRole(string id, ApplicationRole applicationRole);
        Task<ApplicationRole> DeleteApplicationRole(string id);
        
        bool ApplicationRoleExists(string id);
    }
}
