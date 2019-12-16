using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using JobSite.Model.Context;
using JobSite.Model.ViewModel;
using JobSite.Interface.Common;
using Microsoft.AspNetCore.Identity;

namespace JobSite.API.Controllers
{
    [Route("userrole")]
    [ApiController]
    public class ApplicationUserRolesController : ControllerBase
    {
        iApplicationUserRole _iApplicationUserRole;

        public ApplicationUserRolesController(iApplicationUserRole iApplicationUserRole)
        {
            _iApplicationUserRole = iApplicationUserRole;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<IdentityUserRole<string>>>> GetApplicationUserRoles() => await _iApplicationUserRole.GetApplicationUserRoles().ToListAsync();

        // GET: api/ApplicationRoles/5
        [HttpGet]
        [Route("{roleid}")]
        public async Task<ActionResult<IdentityUserRole<string>>> GetApplicationUserRole(string roleid)
        {
            var applicationUserRole = await _iApplicationUserRole.GetApplicationUserRoles().FirstAsync(ur => ur.RoleId == roleid);

            if (applicationUserRole == null)
            {
                return NotFound();
            }

            return applicationUserRole;
        }

        [HttpGet]
        [Route("user/{userid}")]
        public async Task<ActionResult<IEnumerable<IdentityUserRole<string>>>> GetSpecificApplicationUserRoles(string userid) => await _iApplicationUserRole.GetSpecificApplicationUserRoles(userid).ToListAsync();

        [HttpPut]
        [Route("{userid}")]
        public async Task<IActionResult> PutApplicationUserRole(string userid, ApplicationUserRole existingApplicationUserRole, string rolename)
        {
            if (userid != existingApplicationUserRole.UserId)
            {
                return BadRequest();
            }

            try
            {
                await _iApplicationUserRole.ChangeUserRole(existingApplicationUserRole, rolename);
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!_iApplicationUserRole.ApplicationUserRoleExists(existingApplicationUserRole))
                {
                    return NotFound();
                }
                else
                {
                    return Problem();
                }
            }

            return NoContent();
        }

        [HttpPost]
        public async Task<ActionResult<IdentityUserRole<string>>> PostApplicationUserRole(ApplicationUserRole applicationUserRole)
        {
            try
            {
                var aApplicationUserRole = await _iApplicationUserRole.AssignRoleToUser(applicationUserRole);
                return CreatedAtAction(nameof(GetApplicationUserRole), new { id = aApplicationUserRole.RoleId }, aApplicationUserRole);
            }
            catch (DbUpdateException)
            {
                if (_iApplicationUserRole.ApplicationUserRoleExists(applicationUserRole))
                {
                    return Conflict();
                }
                else
                {
                    return Problem();
                }
            }
        }

        // DELETE: api/ApplicationRoles/5
        [HttpDelete]
        [Route("removeuserrole")]
        public async Task<ActionResult<IdentityUserRole<string>>> DeleteApplicationUserRole(ApplicationUserRole applicationUserRole)
        {
            var aApplicationUserRole = await _iApplicationUserRole.GetApplicationUserRoles().FirstAsync(ur => ur.UserId == applicationUserRole.UserId && ur.RoleId == applicationUserRole.RoleId);
            if (applicationUserRole == null)
            {
                return NotFound();
            }

            try
            {
                var result = await _iApplicationUserRole.RemoveRoleFromUser(new ApplicationUserRole() { RoleId = applicationUserRole.RoleId, UserId = applicationUserRole.UserId });
            }
            catch (Exception)
            {
                throw;
            }

            return aApplicationUserRole;
        }

        [HttpDelete]
        [Route("removeuserroles/{userid}")]
        public async Task<ActionResult<IEnumerable<IdentityUserRole<string>>>> DeleteAllApplicationUserRole(string userid)
        {
            var applicationUserRoles = await _iApplicationUserRole.GetSpecificApplicationUserRoles(userid).ToListAsync();
            if (applicationUserRoles == null)
            {
                return NotFound();
            }

            try
            {
                var result = await _iApplicationUserRole.RemoveRolesFromUser(applicationUserRoles);
            }
            catch (Exception)
            {
                throw;
            }

            return applicationUserRoles;
        }
    }
}
