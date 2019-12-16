using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using JobSite.Model.Common;
using JobSite.Model.ViewModel;
using Microsoft.AspNetCore.Identity;
using Microsoft.IdentityModel.Tokens;

namespace JobSite.Interface.Common
{
    public interface iApplicationUser
    {
        Task<ApplicationUser> RegisterApplicationUserAsync(Registration model);
        Task<ApplicationUser> LoginApplicationUserAsync(Login model);
        IQueryable<ApplicationUser> AllApplicationUsers { get; }
        IQueryable<ApplicationUser> GetApplicationUser(string id);

        bool ApplicationUserExists(string id);
    }
}
