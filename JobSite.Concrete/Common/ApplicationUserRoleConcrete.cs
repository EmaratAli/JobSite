using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using JobSite.Interface.Common;
using JobSite.Model.Common;
using JobSite.Model.Context;
using JobSite.Model.ViewModel;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;

namespace JobSite.Concrete.Common
{
    public class ApplicationUserRoleConcrete : iApplicationUserRole
    {
        ApplicationContext _applicationContext;
        private UserManager<ApplicationUser> _userManager;

        public ApplicationUserRoleConcrete(ApplicationContext applicationContext, UserManager<ApplicationUser> userManager)
        {
            _applicationContext = applicationContext;
            _userManager = userManager;
        }

        public IQueryable<IdentityUserRole<string>> GetApplicationUserRoles()
        {
            try
            {
                return _applicationContext.UserRoles;
            }
            catch(Exception ex)
            {
                throw ex;
            }
        }

        public IQueryable<IdentityUserRole<string>> GetSpecificApplicationUserRoles(string userid)
        {
            return _applicationContext.UserRoles.Where(ur => ur.UserId == userid);
        }

        public bool ApplicationUserRoleExists(ApplicationUserRole applicationUserRole) => _applicationContext.UserRoles.Any(ur => ur.UserId == applicationUserRole.UserId && ur.RoleId == applicationUserRole.RoleId);

        public async Task<IdentityUserRole<string>> AssignRoleToUser(ApplicationUserRole applicationUserRole)
        {
            try
            {
                var user = await _applicationContext.ApplicationUsers.FindAsync(applicationUserRole.UserId);
                var roleName = _applicationContext.Roles.FindAsync(applicationUserRole.RoleId).Result.Name;
                await _userManager.AddToRoleAsync(user, roleName);
                return await _applicationContext.UserRoles.SingleOrDefaultAsync(i => i.UserId == applicationUserRole.UserId && i.RoleId == applicationUserRole.RoleId);
            }
            catch (Exception)
            {
                throw;
            }
        } 

        public async Task<IdentityUserRole<string>> ChangeUserRole(ApplicationUserRole existingApplicationUserRole, string roleName)
        {
            try
            {
                var user = await _applicationContext.ApplicationUsers.FindAsync(existingApplicationUserRole.UserId);
                var existingRole = await _applicationContext.Roles.FindAsync(existingApplicationUserRole.RoleId);
                var proposedRole = await _applicationContext.Roles.SingleAsync(r => r.Name == roleName);
                var removeResult = await _userManager.RemoveFromRoleAsync(user, existingRole.Name);
                await _userManager.UpdateAsync(user);
                var addresult = await _userManager.AddToRoleAsync(user, proposedRole.Name);
                await _userManager.UpdateAsync(user);
                return await _applicationContext.UserRoles.SingleOrDefaultAsync(i => i.UserId == user.Id && i.RoleId == proposedRole.Id);
            }
            catch (Exception)
            {
                throw;
            }
        }

        public async Task<IdentityResult> RemoveRoleFromUser(ApplicationUserRole applicationUserRole)
        {
            try
            {
                var user = await _applicationContext.ApplicationUsers.FindAsync(applicationUserRole.UserId);
                var roleName = _applicationContext.Roles.Find(applicationUserRole.RoleId).Name;
                return await _userManager.RemoveFromRoleAsync(user, roleName);
            }
            catch (Exception)
            {
                throw;
            }
        }

        public async Task<IdentityResult> RemoveRolesFromUser(List<IdentityUserRole<string>> identityUserRoles)
        {
            try
            {
                var user = await _applicationContext.ApplicationUsers.FindAsync(identityUserRoles[0].UserId);
                var roleNames = new string[identityUserRoles.Count];
                for (int i = 0; i < identityUserRoles.Count; i++)
                {
                    roleNames[i] = _applicationContext.Roles.Find(identityUserRoles[i].RoleId).Name;
                }
                return await _userManager.RemoveFromRolesAsync(user, roleNames);
            }
            catch (Exception)
            {
                throw;
            }
        }

        
    }
}
