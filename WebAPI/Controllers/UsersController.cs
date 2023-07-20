using Business.Abstract;
using Business.Constants;
using Core.Utilities.Results;
using Entities.Concrete;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebAPI.Controllers
{
    [Authorize]
    [Route("api/[controller]")]
    [ApiController]
    public class UsersController : ControllerBase
    {
        IUserService _userService;
        IJWTAuthenticationManager _jwtAuthenticationManager;
        public UsersController(
            IUserService userService,
            IJWTAuthenticationManager jWTAuthenticationManager
        )
        {
            _userService = userService;
            _jwtAuthenticationManager = jWTAuthenticationManager;
        }

        [AllowAnonymous]
        [HttpPost("authenticate")]
        public IActionResult Authenticate([FromForm] string email, [FromForm] string password)
        {
            User kullanici = _userService.Get(user => user.Email == email).Data;

            if (kullanici == null)
                return BadRequest(new ErrorResult(Messages.USER_NOT_FOUND));

            if (kullanici.Password != password)
                return BadRequest(new ErrorResult(Messages.USER_WRONG_PASSWORD));

#pragma warning disable CS8625 // Cannot convert null literal to non-nullable reference type.
            kullanici.Password = null;
#pragma warning restore CS8625 // Cannot convert null literal to non-nullable reference type.

            var token = _jwtAuthenticationManager.Authenticate(email);

            if (token == null) return Unauthorized();

            kullanici.Token = token;

            return Ok(kullanici);
        }

        [HttpGet("getall")]
        public IActionResult GetAll()
        {
            var result = _userService.GetAll();
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result.Message);
        }

        [HttpPost("add")]
        public IActionResult Add(User user)
        {
            var result = _userService.Add(user);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }

        [HttpPost("delete")]
        public IActionResult Delete(User user)
        {
            var result = _userService.Delete(user);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }

        [HttpPost("update")]
        public IActionResult Update(User user)
        {
            var result = _userService.Update(user);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }
    }
}
