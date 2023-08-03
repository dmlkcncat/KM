using Business.Abstract;
using Entities.Concrete;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LastProjectController : ControllerBase
    {
        ILastProjectService _lastProjectService;
        public LastProjectController(ILastProjectService lastProjectService)
        {
            _lastProjectService = lastProjectService;
        }

        [HttpGet("getall")]
        public IActionResult GetAll()
        {
            var result = _lastProjectService.GetAll();
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result.Message);
        }

        [HttpPost("update")]
        public IActionResult Update(LastProject lastProject)
        {
            var result = _lastProjectService.Update(lastProject);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }
    }
}
