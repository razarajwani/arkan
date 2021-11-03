using ArkkanCore.DAL.Interfaces;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;

namespace ArkanCore.MVC.Controllers
{
    public class AuthController : Controller
    {
        public IUserMasService _UserMasService { get; }

        public AuthController(IUserMasService userMasService) 
        {
            _UserMasService = userMasService;
        }

        public IActionResult Index()
        {
            return View();
        }



        public IActionResult accessDenied()
        {
            return View();
        }

        [HttpPost]
        public IActionResult verify(string username, string password, int branch)
        {
            var status = false;
            var userInfo = _UserMasService.Find(c => c.Username.ToLower() == username.Trim().ToLower() && c.Password == password && c.Branchcode==branch).SingleOrDefault();
            if (userInfo != null)
            {
                var userClaims = new List<Claim>() {
                    new Claim(ClaimTypes.Name,userInfo.UserCode.ToString()),
                    new Claim(ClaimTypes.NameIdentifier,userInfo.Username),
                    new Claim(ClaimTypes.Email,userInfo.Email),
                    new Claim(ClaimTypes.Role, userInfo.UsergroupCode.ToString()),
                    //new Claim("RoleName", userInfo.RoleNameEn),

                };

                var userIdentity = new ClaimsIdentity(userClaims, "User Identity");
                var userPrincipal = new ClaimsPrincipal(new[] { userIdentity });

                HttpContext.SignInAsync(userPrincipal);
                status = userPrincipal.Identity.IsAuthenticated;
            }

            return Json(new { status = status });
        }


        public IActionResult Logout()
        {
            HttpContext.SignOutAsync();

            return RedirectToAction("Login");
        }


    }
}
