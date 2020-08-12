using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using System.Security.Claims;
using System.Text;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Options;
using WebAAssign.Models;
using System.Diagnostics;
using WebAAssign.Services;
using WebAAssign.Helpers;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace WebAAssign.Controllers
{
    public class LoginController : Controller
    {
        private IUserService _userService;
        private readonly AppSettings _appSettings;

        public LoginController(
                  IUserService userService,
                  IOptions<AppSettings> appSettings)
        {
            _userService = userService;
            _appSettings = appSettings.Value;
        }

        [AllowAnonymous]
        [ActionName("Login")]
        public IActionResult Login()
        {
            return View();
        }

        [AllowAnonymous]
        [ValidateAntiForgeryToken]
        [HttpPost("Login")]
        public async Task<IActionResult> Login([FromForm] IFormCollection data)
        {//Referred to the code at this GitHub repo
         //https://github.com/minato128/aspnet-core20-auth-sample/blob/master/WebApplication6/Controllers/HomeController.cs
         //I am avoiding the usage of the ViewModel. You can go through the online
         //tutorials to replace the logic here by using ViewModel.
            if ((data["passwordInput"].ToString().Trim() == "") || (data["usernameInput"].ToString().Trim() == ""))
            {
                //Make a ViewBag
                //ViewBag lifecycle only last for this request cycle.
                ViewBag.Message = "User name or password is missing";
                return View();
            }

            var user = _userService.Authenticate(data["usernameInput"], data["passwordInput"]);

            if (user == null)
            {
                //Make a ViewBag
                ViewBag.Message = "User name or password is wrong";
                return View();
            }

            var key = Encoding.ASCII.GetBytes(_appSettings.Secret);

            /********************************************************************/
            //The following block of code has been added to support token storage in Browser cookie
            var claimsIdentity = new ClaimsIdentity(new Claim[]
            {
                new Claim(ClaimTypes.Name, user.userId.ToString() ),
                new Claim("username", user.userName.ToString()),
                new Claim("userid", user.userId.ToString()),
             }, "CookieAuthenticationScheme");

            var claimsPrincipal = new ClaimsPrincipal(claimsIdentity);
            await Request.HttpContext.SignInAsync("CookieAuthenticationScheme", claimsPrincipal);
            /********************************************************************/

            return Redirect("/");
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
        public async Task<IActionResult> Logout()
        {
            await HttpContext.SignOutAsync("CookieAuthenticationScheme");
            return Redirect("/");
        }
    }
}
