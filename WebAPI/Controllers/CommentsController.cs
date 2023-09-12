using Business.Abstract;
using Core;
using Entities.Concrete;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Linq.Expressions;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [Consumes("application/json")]
    [ApiController]
    public class CommentsController : ControllerBase
    {

        ICommentsService _commentsService;
        public CommentsController(ICommentsService commentsService)
        {
            _commentsService = commentsService;
        }

        [AllowAnonymous]
        [HttpGet("getall")]
        public IActionResult GetAll([FromQuery(Name = "active")] bool active = true)
        {
            Expression<Func<Comments, bool>> filter = filter = x => x.Active;
            if (!active) filter = null;
            var result = _commentsService.GetAll(filter);
            if (result.Success)
            {
                return Ok(result);

            }
            return BadRequest(result.Message);
        }

        [HttpPost("add")]
        public IActionResult Add(Comments comments)
        {
            comments.CreatedDate = DateTime.Now;

            var result = _commentsService.Add(comments);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }

        [HttpPost("delete")]
        public IActionResult Delete(Comments comments)
        {
            var result = _commentsService.Delete(comments);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }
    }
}
