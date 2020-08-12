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
        SysUser Authenticate(string inUserId, string inPassword);
        IEnumerable<SysUser> GetAll();

        SysUser GetById(int id);
        SysUser Create(SysUser user, string password);
        void Update(SysUser user, string password = null);
        void Delete(int id);
    }

    public class UserService : IUserService
    {
        private ApplicationDbContext _context;

        public UserService(ApplicationDbContext context)
        {
            _context = context;
        }

        public SysUser Authenticate(string inUserName, string inPassword)
        {
            if (string.IsNullOrEmpty(inUserName) || string.IsNullOrEmpty(inPassword))
                return null;
            //Check whether there is a matching user name information first.
            //Then, the subsequent code will verify the password by calling
            //the VefiryPasswordHash method
            var user = _context.SysUsers.Include(u => u.userId).SingleOrDefault(x => x.userName == inUserName);

            // check if username exists
            if (user == null)
                return null;

            // check if password is correct
            if (!VerifyPasswordHash(inPassword, user.userPassHash, user.userPassSalt))
                return null;

            // authentication successful
            return user;
        }

        public IEnumerable<SysUser> GetAll()
        {
            return _context.SysUsers.Include(user => user.userId);
        }

        public SysUser GetById(int id)
        {
            return _context.SysUsers.Find(id);
        }

        public SysUser Create(SysUser user, string password)
        {
            // validation to check if the password is empty or spaces only.
            if (string.IsNullOrWhiteSpace(password))
                throw new AppException("Password is required");
            // If the user name (email) already exists, raise an exception
            // so that the Web API controller class code can capture the error and
            // send back a JSON response to the client side.
            if (_context.SysUsers.Any(appUser => appUser.userName == user.userName))
                throw new AppException("Username " + user.userName + " is already taken");

            byte[] passwordHash, passwordSalt;
            CreatePasswordHash(password, out passwordHash, out passwordSalt);

            user.userPassHash = passwordHash;
            user.userPassSalt = passwordSalt;

            _context.SysUsers.Add(user);
            _context.SaveChanges();

            return user;
        }

        public void Update(SysUser userParam, string inPassword = null)
        {
            var user = _context.SysUsers.Find(userParam.userId);

            if (user == null)
                throw new AppException("User not found");

            if (userParam.userName != user.userName)
            {
                // username has changed so check if the new username is already taken
                if (_context.SysUsers.Any(x => x.userName == userParam.userName))
                    throw new AppException("User name " + userParam.userName + " is already taken");
            }

            //Update user properties
            user.userName = userParam.userName;
            user.userPassHash = userParam.userPassHash;
            user.userPassSalt = userParam.userPassSalt;
            //Update password if it was entered
            if (!string.IsNullOrWhiteSpace(inPassword))
            {
                byte[] passwordHash, passwordSalt;
                CreatePasswordHash(inPassword, out passwordHash, out passwordSalt);

                user.userPassHash = passwordHash;
                user.userPassSalt = passwordSalt;
            }

            _context.SysUsers.Update(user);
            _context.SaveChanges();
        }

        public void Delete(int id)
        {
            var user = _context.SysUsers.Find(id);
            if (user != null)
            {
                try
                {
                    _context.SysUsers.Remove(user);
                    _context.SaveChanges();
                }
                catch (Exception ex)
                {
                    if (ex.InnerException.Message.ToUpper().Contains("REFERENCE CONSTRAINT"))
                    {
                        throw new AppException("Unable to delete user record. The user information might have been linked to other information. ");
                    }
                    else
                    {
                        throw new AppException("Unable to delete user record.");
                    }
                }
            }
        }

        // private helper methods

        private static void CreatePasswordHash(string inPassword, out byte[] inPasswordHash, out byte[] inPasswordSalt)
        {
            if (inPassword == null) throw new ArgumentNullException("password");
            if (string.IsNullOrWhiteSpace(inPassword)) throw new ArgumentException("Value cannot be empty or whitespace only string.", "password");
            //The password is hashed with a new random salt.
            //https://crackstation.net/hashing-security.htm
            using (var hmac = new System.Security.Cryptography.HMACSHA512())
            {
                inPasswordSalt = hmac.Key;
                inPasswordHash = hmac.ComputeHash(System.Text.Encoding.UTF8.GetBytes(inPassword));
            }
        }

        private static bool VerifyPasswordHash(string inPassword, byte[] inStoredHash, byte[] inStoredSalt)
        {
            if (inPassword == null) throw new ArgumentNullException("password");
            if (string.IsNullOrWhiteSpace(inPassword)) throw new ArgumentException("Value cannot be empty or whitespace only string.", "password");
            if (inStoredHash.Length != 64) throw new ArgumentException("Invalid length of password hash (64 bytes expected).", "passwordHash");
            if (inStoredSalt.Length != 128) throw new ArgumentException("Invalid length of password salt (128 bytes expected).", "passwordHash");

            using (var hmac = new System.Security.Cryptography.HMACSHA512(inStoredSalt))
            {
                var computedHash = hmac.ComputeHash(System.Text.Encoding.UTF8.GetBytes(inPassword));
                for (int i = 0; i < computedHash.Length; i++)
                {
                    if (computedHash[i] != inStoredHash[i]) return false;
                }
            }

            return true;
        }
    }
}
