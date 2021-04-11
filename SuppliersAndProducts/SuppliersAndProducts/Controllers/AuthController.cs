
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.IdentityModel.Tokens;
using SuppliersAndProducts.Data;
using SuppliersAndProducts.Dtos;
using SuppliersAndProducts.Models.Classes;
using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;

namespace SuppliersAndProducts.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class AuthController : ControllerBase
    {
        private IAuthRepository _authRepository;
        private IConfiguration _configuration;
            
        public AuthController(IAuthRepository authRepository,IConfiguration configuration)
        {
            _authRepository = authRepository;
            _configuration = configuration;
        }
        [HttpPost]

        public async Task<IActionResult> Register([FromForm] AdminForRegisterDto adminForRegister) {
            if(await _authRepository.UserExist(adminForRegister.UserName))
            {
                ModelState.AddModelError("UserName", "Username already exists");
            }
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            var adminToCreate = new Admin
            {
                UserName = adminForRegister.UserName,
                Password=adminForRegister.Password,
            };
            var createAdmin = await _authRepository.Register(adminToCreate);
            return StatusCode(201);

        }
        [HttpPost]
        public async Task<ActionResult> Login([FromForm] Admin adminForLogin) 
        {
            var admin = await _authRepository.Login(adminForLogin);


            if (admin == null)
            {
                return Unauthorized();
            }

            var tokenHandler = new JwtSecurityTokenHandler();
            var key = Encoding.ASCII.GetBytes(_configuration.GetSection("AppSettings:Token").Value);

            var tokenDescriptor = new SecurityTokenDescriptor
            {
                Subject = new ClaimsIdentity(new Claim[]
                {
                    new Claim(ClaimTypes.NameIdentifier, admin.UserID.ToString()),
                    new Claim(ClaimTypes.Name, admin.UserName),
                }),
                Expires = DateTime.UtcNow.AddDays(1),
                SigningCredentials = new SigningCredentials(new SymmetricSecurityKey(key),
                SecurityAlgorithms.HmacSha512Signature),
            };

            var token = tokenHandler.CreateToken(tokenDescriptor);
            var tokenString = tokenHandler.WriteToken(token);

            return Ok(tokenString);

        }
    }
}
