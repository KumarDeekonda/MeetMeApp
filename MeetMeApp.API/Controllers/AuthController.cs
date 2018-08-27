using System.IdentityModel.Tokens.Jwt;
using System.Text;
using System.Threading.Tasks;
using MeetMeApp.API.Data;
using MeetMeApp.API.Dtos;
using MeetMeApp.API.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.IdentityModel.Tokens;
using System.Security.Claims;
using System;
using Microsoft.Extensions.Configuration;

namespace MeetMeApp.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]

    public class AuthController : ControllerBase
    {
        private readonly IAuthRepository _repo;
        public AuthController(IAuthRepository repo)
        {
            _repo = repo;

        }

        [HttpPost("register")]

        public async Task<IActionResult> Register(UserForRegisterDto userForRegisterDto)
        {
            // if (!ModelState.IsValid) 
            //     return BadRequest(ModelState);

            // if you use apicontroller you do not need to mention modelvalid code 

            // if you comment apicontroller need to use [frombody] for userforregisterdto

            userForRegisterDto.Username = userForRegisterDto.Username.ToLower();

            if (await _repo.UserExists(userForRegisterDto.Username))
                return BadRequest("Username is already taken");

            var userToCreate = new User
            {
                Username = userForRegisterDto.Username,

            };

            var createdUser = await _repo.Register(userToCreate, userForRegisterDto.Password);

            return StatusCode(201);
        }
    }
}