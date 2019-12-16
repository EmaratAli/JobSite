using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;
using JobSite.Interface.Common;
using Microsoft.Extensions.Options;
using JobSite.Model;
using JobSite.Model.Common;
using System.IdentityModel.Tokens.Jwt;
using Microsoft.IdentityModel.Tokens;
using JobSite.Concrete.Helpers;
using Microsoft.AspNetCore.Identity;
using JobSite.Model.ViewModel;
using JobSite.Model.Context;

namespace JobSite.Concrete.Common
{
    public class ApplicationUserConcrete : iApplicationUser
    {
        ApplicationContext _applicationContext;
        private UserManager<ApplicationUser> _userManager;
        private readonly AppSettings _appSettings;

        public ApplicationUserConcrete(UserManager<ApplicationUser> userManager, IOptions<AppSettings> appSettings, ApplicationContext applicationContext)
        {
            _userManager = userManager;
            _appSettings = appSettings.Value;
            _applicationContext = applicationContext;
        }

        public async Task<ApplicationUser> RegisterApplicationUserAsync(Registration model)
        {
            var applicationUser = new ApplicationUser()
            {
                UserName = model.UserName,
                Email = model.Email,
                PhoneNumber = model.PhoneNumber
            };

            try
            {
                var result = await _userManager.CreateAsync(applicationUser, model.Password);
                return applicationUser.WithoutPassword();
            }
            catch (Exception)
            {
                throw;
            }
        }

        public async Task<ApplicationUser> LoginApplicationUserAsync(Login model)
        {
            try
            {
                var user = await _userManager.FindByNameAsync(model.UserName);
                if (user != null && await _userManager.CheckPasswordAsync(user, model.Password))
                {
                    var role = await _userManager.GetRolesAsync(user);
                    var options = new IdentityOptions();

                    var tokenHandler = new JwtSecurityTokenHandler();
                    var key = Encoding.ASCII.GetBytes(_appSettings.Secret);
                    var tokenDescriptor = new SecurityTokenDescriptor
                    {
                        Subject = new ClaimsIdentity(new Claim[]
                        {
                        new Claim(ClaimTypes.Name, user.Id.ToString()),
                        new Claim(options.ClaimsIdentity.RoleClaimType,role.FirstOrDefault())
                        }),
                        Expires = DateTime.UtcNow.AddDays(7),
                        SigningCredentials = new SigningCredentials(new SymmetricSecurityKey(key), SecurityAlgorithms.HmacSha256Signature)
                    };
                    var token = tokenHandler.CreateToken(tokenDescriptor);
                    user.Token = tokenHandler.WriteToken(token);
                    var result = await _userManager.UpdateAsync(user);
                    //var writtenToken = tokenHandler.WriteToken(token);
                    return user.WithoutPassword();
                }
                return null;
            }
            catch(Exception ex)
            {
                throw ex;
            }
            //return null;
        }

        public IQueryable<ApplicationUser> AllApplicationUsers => _applicationContext.ApplicationUsers.GetAllWithoutPasswords().AsQueryable();

        public IQueryable<ApplicationUser> GetApplicationUser(string id) => _applicationContext.ApplicationUsers.Where(a => a.Id == id).GetAllWithoutPasswords();

        public bool ApplicationUserExists(string id) => _applicationContext.ApplicationUsers.Any(e => e.Id == id);
    }
}
