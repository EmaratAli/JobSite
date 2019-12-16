using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using JobSite.Concrete.Helpers;
using JobSite.Interface.Common;
using JobSite.Model.Common;
using JobSite.Model.ViewModel;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;
using Microsoft.IdentityModel.Tokens;

namespace JobSite.API.Controllers
{
    [Authorize(Roles = "Admin")]
    [ApiController]
    [Route("[controller]")]
    public class ApplicationUsersController : ControllerBase
    {
        private iApplicationUser _iApplicationUser;

        public ApplicationUsersController(iApplicationUser iUser)
        {
            _iApplicationUser = iUser;
        }

        [AllowAnonymous]
        [HttpPost]
        [Route("register")]
        public async Task<ActionResult<ApplicationUser>> Register(Registration model)
        {
            try
            {
                var applicationUser = await _iApplicationUser.RegisterApplicationUserAsync(model);
                return CreatedAtAction(nameof(Get), new { id = applicationUser.Id }, applicationUser);
            }
            catch (DbUpdateException)
            {
                if (_iApplicationUser.ApplicationUserExists(model.UserName))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }
        }

        [AllowAnonymous]
        [HttpPost]
        [Route("login")]
        public async Task<ActionResult<ApplicationUser>> Login(Login model)
        {
            try
            {
                var user = await _iApplicationUser.LoginApplicationUserAsync(model);
                if (user == null)
                {
                    return NotFound();
                }
                return CreatedAtAction(nameof(GetAll), new { id = user.Id }, user);
                //return Ok(user.Result.Token);
            }
            catch(Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpGet]
        [Route("users")]
        public async Task<ActionResult<IEnumerable<ApplicationUser>>> GetAll()
        {
            var users = await _iApplicationUser.AllApplicationUsers.ToListAsync();
            return Ok(users);
        }

        [HttpGet]
        [Route("users/{id}")]
        public async Task<ActionResult<ApplicationUser>> Get(string id)
        {
            var users = await _iApplicationUser.GetApplicationUser(id).SingleAsync();
            return Ok(users);
        }
    }
}