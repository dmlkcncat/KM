using Business.Abstract;
using Entities.Concrete;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CountersController : ControllerBase
    {

        ICountersService _countersService;
        public CountersController(ICountersService countersService)
        {
            _countersService = countersService;
        }

        [HttpGet("getall")]
        public IActionResult GetAll()
        {
            var result = _countersService.GetAll();
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result.Message);
        }

        [HttpPost("update")]
        public IActionResult Update(Counters counters)
        {
            var result = _countersService.Update(counters);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }
    }
}
