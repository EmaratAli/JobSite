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
    public class ApplicationRoleConcrete : iApplicationRole
    {
        ApplicationContext _applicationContext;
        private UserManager<ApplicationUser> _userManager;

        public ApplicationRoleConcrete(ApplicationContext applicationContext, UserManager<ApplicationUser> userManager)
        {
            _applicationContext = applicationContext;
            _userManager = userManager;
        }

        public IdentityRole CreateApplicationRole(ApplicationRole applicationUserRole)
        {
            try
            {
                var identityRole = new IdentityRole(applicationUserRole.Name);
                _applicationContext.Add<IdentityRole>(identityRole);
                _applicationContext.SaveChanges();
                return identityRole;
            }
            catch(Exception ex)
            {
                return null;
            }
        }

        public IQueryable<ApplicationRole> GetApplicationRole(string id) => _applicationContext.Roles.Where(r => r.Id == id).Select(r => new ApplicationRole { ID = r.Id, Name = r.Name, NormalizedName = r.NormalizedName });

        public IQueryable<ApplicationRole> ApplicationRoles => _applicationContext.Roles.Select(r => new ApplicationRole { ID = r.Id, Name = r.Name, NormalizedName = r.NormalizedName });

        public async Task<ApplicationRole> PostApplicationRole(ApplicationRole applicationUserRole)
        {
            try
            {
                IdentityRole identityRole = new IdentityRole(applicationUserRole.Name);
                identityRole.NormalizedName = applicationUserRole.NormalizedName;
                _applicationContext.Roles.Add(identityRole);
                await _applicationContext.SaveChangesAsync();
                applicationUserRole.ID = identityRole.Id;
                return applicationUserRole; 
            }
            catch(DbUpdateException)
            {
                throw;
            }
        }

        public async Task<int> PutApplicationRole(string id, ApplicationRole applicationUserRole)
        {
            try
            {
                var identityRole = await _applicationContext.Roles.FindAsync(id);
                identityRole.Name = applicationUserRole.Name;
                identityRole.NormalizedName = applicationUserRole.NormalizedName;
                _applicationContext.Entry(identityRole).State = EntityState.Modified;
                return await _applicationContext.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                throw;
            }
        }

        public async Task<ApplicationRole> DeleteApplicationRole(string id)
        {
            try
            {
                var identityRole = await _applicationContext.Roles.FindAsync(id);
                _applicationContext.Roles.Remove(identityRole);
                await _applicationContext.SaveChangesAsync();
                return new ApplicationRole(identityRole.Id, identityRole.Name, identityRole.NormalizedName);
            }
            catch(Exception)
            {
                throw;
            }
        }


        public async Task<IdentityResult> RemoveRoleFromUser(ApplicationUserRole userAssignedRole)
        {
            try
            {
                var user = await _applicationContext.ApplicationUsers.SingleOrDefaultAsync(x => x.UserName == userAssignedRole.UserId);
                string roleId = _applicationContext.UserRoles.Where(ur => ur.UserId == user.Id).SingleOrDefaultAsync().Result.RoleId;
                return await _userManager.RemoveFromRoleAsync(user, userAssignedRole.RoleId);
            }
            catch (Exception)
            {
                throw;
            }
        }

        public async Task<IdentityResult> RemoveRolesFromUser(ApplicationUserRole userAssignedRole)
        {
            try
            {
                var user = await _applicationContext.ApplicationUsers.SingleOrDefaultAsync(x => x.UserName == userAssignedRole.UserId);
                string[] roleId = _applicationContext.UserRoles.Where(ur => ur.UserId == user.Id).Select(ur => ur.RoleId).ToArray();
                string[] roleName = new string[roleId.Length];
                for (int i = 0; i < roleId.Length; i++)
                {
                    roleName[i] = _applicationContext.Roles.Single(r => r.Id == roleId[i]).Name;
                }
                
                return await _userManager.RemoveFromRolesAsync(user, roleName);
            }
            catch (Exception)
            {
                throw;
            }
        }

        public async Task<IdentityUserRole<string>> ChangeUserRole(ApplicationUserRole userAssignedRole)
        {
            try
            {
                var user = await _applicationContext.ApplicationUsers.SingleOrDefaultAsync(x => x.UserName == userAssignedRole.UserId);
                string roleId = _applicationContext.UserRoles.Where(ur => ur.UserId == user.Id).SingleOrDefaultAsync().Result.RoleId;
                //string roleName = _applicationContext.Roles.SingleOrDefault(r => r.Id == roleId).Name;
                await _userManager.RemoveFromRoleAsync(user, _applicationContext.Roles.SingleOrDefault(r => r.Id == roleId).Name);
                await _userManager.AddToRoleAsync(user, userAssignedRole.RoleId);
                var role = await _applicationContext.Roles.SingleOrDefaultAsync(r => r.Name == userAssignedRole.RoleId);
                var identityUserRole = await _applicationContext.UserRoles.SingleOrDefaultAsync(i => i.UserId == user.Id && i.RoleId == role.Id);
                return identityUserRole;
            }
            catch (Exception)
            {
                throw;
            }
        }

        public bool ApplicationRoleExists(string id) => _applicationContext.Roles.Any(e => e.Id == id);
    }
}
