using ArkkanCore.DAL.Interfaces;
using ArkkanCore.DAL.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.IdentityModel.Tokens;
using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;

namespace ArkanCore.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LoginController : ControllerBase
    {
        private IUserMasService _userMasService;
        public IConfiguration _config;
        public LoginController(IConfiguration config, IUserMasService userMasService)
        {
            _config = config;
            _userMasService = userMasService;
        }

        public IActionResult Login(string username, string password, int branch)
        {
            UserMa login = new UserMa();
            login.Username = username;
            login.Password = password;
            login.Branchcode = branch;

            IActionResult response = Unauthorized();

            var user = AuthenticateUser(login);
            if (user != null)
            {
                var tokenStr = GenerateJSONWebToken(user);
                response = Ok(new { token = tokenStr, user });
            }

            return response;
        }

        private string GenerateJSONWebToken(UserMa userinfo)
        {
            var securityKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(_config["Jwt:key"]));
            var crednetials = new SigningCredentials(securityKey, SecurityAlgorithms.HmacSha256);

            var claims = new[]
            {
                new Claim(JwtRegisteredClaimNames.Sub, userinfo.Username),
                new Claim(JwtRegisteredClaimNames.Email, userinfo.Email),
                new Claim(JwtRegisteredClaimNames.Jti, Guid.NewGuid().ToString())
            };

            var token = new JwtSecurityToken(
                issuer: _config["Jwt:issuer"],
                audience: _config["Jwt:issuer"],
                claims,
                expires: DateTime.Now.AddMinutes(120),
                signingCredentials: crednetials);

            var encodetoken = new JwtSecurityTokenHandler().WriteToken(token);
            return encodetoken;

        }

        private UserMa AuthenticateUser(UserMa login)
        {
            UserMa user = _userMasService.dbset().Where(c => c.Username == login.Username && c.Password == login.Password && c.Branchcode == login.Branchcode).FirstOrDefault();
            return user;
        }
    }
}