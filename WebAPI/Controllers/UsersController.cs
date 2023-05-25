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
        public UsersController(
            IUserService userService
        )
        {
            _userService = userService;
        }

        //[AllowAnonymous]
        //[HttpPost("authenticate")]
        //public IActionResult Authenticate([FromForm] string mail, [FromForm] string password)
        //{
        //    User kullanici = _userService.Get(user => user.Mail == mail).Data;

        //    if (kullanici == null)
        //        return BadRequest(new ErrorResult(Messages.USER_NOT_FOUND));

        //    if (kullanici.Password != password)
        //        return BadRequest(new ErrorResult(Messages.USER_WRONG_PASSWORD));

        //    kullanici.Password = null;

        //    var token = _jWTAuthenticationManager.Authenticate(mail);

        //    if (token == null) return Unauthorized();

        //    kullanici.Token = token;

        //    return Ok(kullanici);
        //}


        [AllowAnonymous]
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
