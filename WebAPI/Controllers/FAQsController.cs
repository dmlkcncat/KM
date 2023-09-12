using Business.Abstract;
using Entities.Concrete;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [Consumes("application/json")]
    [ApiController]
    public class FAQsController : ControllerBase
    {
        ISSSService _sssService;
        public FAQsController(ISSSService sssService)
        {
            _sssService = sssService;
        }

        [HttpGet("getall")]
        public IActionResult GetAll()
        {
            var result = _sssService.GetAll();
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result.Message);
        }

        [HttpPost("add")]
        public IActionResult Add(SSS sss)
        {
            var result = _sssService.Add(sss);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }

        [HttpPost("delete")]
        public IActionResult Delete(SSS sss)
        {
            var result = _sssService.Delete(sss);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }

        [HttpPost("update")]
        public IActionResult Update(SSS sss)
        {
            var result = _sssService.Update(sss);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }
    }
}
