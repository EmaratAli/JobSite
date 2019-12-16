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
using Microsoft.AspNetCore.Authorization;
using JobSite.Model.Common;
using Microsoft.AspNetCore.Identity;

namespace JobSite.API.Controllers
{
    [Authorize]
    [Route("role")]
    [ApiController]
    public class ApplicationRolesController : ControllerBase
    {

        private readonly iApplicationRole _iApplicationRole;

        public ApplicationRolesController(iApplicationRole iapplicationUserRole)
        {
            _iApplicationRole = iapplicationUserRole;
        }

        [HttpGet("roles")]
        public async Task<ActionResult<IEnumerable<ApplicationRole>>> GetApplicationUserRoles()
        {
            try
            {
                var result = await _iApplicationRole.ApplicationRoles.ToListAsync();
                return Ok(result);
            }
            catch(Exception ex)
            {
                throw ex;
            }
        }

        [HttpGet("roles/{id}")]
        public async Task<ActionResult<ApplicationRole>> GetApplicationUserRole(string id)
        {
            var applicationUserRole = await _iApplicationRole.ApplicationRoles.FirstAsync(f => f.ID == id);

            if (applicationUserRole == null)
            {
                return NotFound();
            }

            return Ok(applicationUserRole);
        }

        [HttpPut("amend/{id}")]
        public async Task<IActionResult> PutApplicationUserRole(string id, ApplicationRole applicationUserRole)
        {
            if (id != applicationUserRole.ID)
            {
                return BadRequest();
            }

            try
            {
                var result = await _iApplicationRole.PutApplicationRole(id, applicationUserRole);
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!_iApplicationRole.ApplicationRoleExists(id))
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

        [HttpPost("add")]
        public async Task<ActionResult<ApplicationRole>> PostApplicationUserRole(ApplicationRole applicationUserRole)
        {
            try
            {
                var aApplicationUserRole = await _iApplicationRole.PostApplicationRole(applicationUserRole);
                return CreatedAtAction(nameof(GetApplicationUserRole), new { id = aApplicationUserRole.ID }, aApplicationUserRole);
            }
            catch (DbUpdateException)
            {
                if (_iApplicationRole.ApplicationRoleExists(applicationUserRole.ID))
                {
                    return Conflict();
                }
                else
                {
                    return Problem();
                }
            }
        }

        [HttpDelete("remove/{id}")]
        public async Task<ActionResult<ApplicationRole>> DeleteApplicationUserRole(string id)
        {
            try
            {
                var aApplicationUserRole = await _iApplicationRole.DeleteApplicationRole(id);
            }
            catch(Exception)
            {
                throw;
            }
            return NoContent();
        }
    }
}
