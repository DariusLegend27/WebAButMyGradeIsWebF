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

        public IActionResult Login()
        {
            return View();
        }

        [ValidateAntiForgeryToken]
        [HttpPost]
        public async Task<IActionResult> Login([FromForm] IFormCollection data)
        {
            if ((data["userName"].ToString().Trim() == "") || (data["password"].ToString().Trim() == ""))
            {
                ViewBag.Message = "User name or password is missing";
                return View();
            }

            var userInput = await _userService.AuthenticateAsync(data["userName"].ToString().ToLower(), data["psw"].ToString());

            if (userInput == null)
            {
                ViewBag.Message = "User name or password is wrong";
                return View();
            }

            var key = Encoding.ASCII.GetBytes(_appSettings.Secret);

            var identity = new ClaimsIdentity(new Claim[]
            {
                new Claim(ClaimTypes.Name, userInput.userName.ToString()),
                new Claim("Name", userInput.userName.ToString())
            }, "MyCookieAuthentication");


            await HttpContext.SignInAsync("MyCookieAuthentication", new ClaimsPrincipal(identity));
            return RedirectToAction("/Home/adminPanel");
        }

        public IActionResult Authenticate()
        {
            return Redirect("/Home/adminPanel");
        }
    }
}
