using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.IdentityModel.Tokens;
using RestaurantsAPI.Data;
using RestaurantsAPI.DTOs;
using RestaurantsAPI.Models;
using RestaurantsAPI.Repository;

namespace RestaurantsAPI.Controllers
{
    [ApiController]
    [Route("api/account")]
    public class AccountController : ControllerBase
    {
        private readonly IAccountRepository _accountRepository;
        private readonly IMapper _mapper;
        private readonly UserManager<UserModel> _userManager;
        private readonly IConfiguration _configuration;
       

        public AccountController(IAccountRepository accountRepository, IMapper mapper, UserManager<UserModel> userManager, IConfiguration configuration)
        {
            _accountRepository = accountRepository;
            _userManager = userManager;
            _mapper = mapper;
            _configuration = configuration;
        }

        [HttpPost("registration")]
        public async Task<IActionResult> Register(UserRegistration userRegistration)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            if(await _accountRepository.UserExists(userRegistration.Email.ToLower()))
                return BadRequest("User exists with same email.");

            var user = _mapper.Map<UserModel>(userRegistration);
            var userCreated = await _userManager.CreateAsync(user, userRegistration.Password);

            if (userCreated.Succeeded)
            {
                var userToReturn = _mapper.Map<UserInfo>(user);
                return Ok(userToReturn);
            }

            return BadRequest("Registration failed");
        }

        [HttpPost("login")]
        public async Task<IActionResult> Login(UserLoginModel userLoginModel)
        {
            if (!ModelState.IsValid)
                return BadRequest("Unable to login.");

            var user = await _userManager.FindByEmailAsync(userLoginModel.Username);

            if (user == null)
                return Unauthorized();

            var result = await _userManager.CheckPasswordAsync(user, userLoginModel.Password);

            if (!result)
                return Unauthorized();

            var claims = new[]
            {
                new Claim(ClaimTypes.NameIdentifier, user.Id),
                new Claim(ClaimTypes.Name, user.Name)
            };
            
            var key = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(_configuration.GetSection("AuthSetting:tokenKey").Value));
            var credential = new SigningCredentials(key, SecurityAlgorithms.HmacSha512Signature);
            var tokenDescriptor = new SecurityTokenDescriptor()
            {
                Subject = new ClaimsIdentity(claims),
                Expires = DateTime.Now.AddHours(12),
                SigningCredentials = credential
            };

            var tokenHandler = new JwtSecurityTokenHandler();

            var token = tokenHandler.CreateToken(tokenDescriptor);

            return Ok(new {token = tokenHandler.WriteToken(token)});
        }
    }
}
