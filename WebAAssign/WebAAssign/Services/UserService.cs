using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebAAssign.Data;
using WebAAssign.Helpers;
using WebAAssign.Models;

namespace WebAAssign.Services
{
    public interface IUserService
    {
        Task<SysUser> AuthenticateAsync(string username, string password);
    }

    public class UserService : IUserService
    {
        private readonly AppSettings _appSettings;

        public ApplicationDbContext Database { get; }

        public UserService(IOptions<AppSettings> appSettings, ApplicationDbContext database)
        {
            Database = database;
            _appSettings = appSettings.Value;
        }

        public async Task<SysUser> AuthenticateAsync(string userName, string password)
        {
            if (userName.Equals(null) || password.Equals(null))
                return null;
            //As of now it uses the local List to look up the users.
            var user = await Database.SysUsers.Include(u => u.userName).SingleOrDefaultAsync(p => p.userName == userName && p.userPassHash == password);

            // return null if user not found
            if (user == null)
                return null;

            user.userPassHash = null;

            return user;
        }
    }
}
