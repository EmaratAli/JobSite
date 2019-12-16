using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using JobSite.Model.ViewModel;
using Microsoft.AspNetCore.Identity;

namespace JobSite.Interface.Common
{
    public interface iApplicationUserRole
    {
        IQueryable<IdentityUserRole<string>> GetApplicationUserRoles();
        IQueryable<IdentityUserRole<string>> GetSpecificApplicationUserRoles(string userid);
        Task<IdentityUserRole<string>> AssignRoleToUser(ApplicationUserRole applicationUserRole);
        Task<IdentityResult> RemoveRoleFromUser(ApplicationUserRole applicationUserRole);
        Task<IdentityResult> RemoveRolesFromUser(List<IdentityUserRole<string>> identityUserRoles);
        Task<IdentityUserRole<string>> ChangeUserRole(ApplicationUserRole existingApplicationUserRole, string roleName);
        bool ApplicationUserRoleExists(ApplicationUserRole applicationUserRole);
    }
}
