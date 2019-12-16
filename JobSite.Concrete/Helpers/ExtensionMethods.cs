using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using JobSite.Model.Common;

namespace JobSite.Concrete.Helpers
{
    public static class ExtensionMethods
    {
        public static IEnumerable<ApplicationUser> WithoutPasswords(this IEnumerable<ApplicationUser> users)
        {
            return users.Select(x => x.WithoutPassword());
        }

        public static IQueryable<ApplicationUser> GetAllWithoutPasswords(this IQueryable<ApplicationUser> users)
        {
            return users.Select(x => x.WithoutPassword());
        }

        public static ApplicationUser WithoutPassword(this ApplicationUser user)
        {
            user.PasswordHash = null;
            user.SecurityStamp = null;
            user.ConcurrencyStamp = null;
            return user;
        }
    }
}
