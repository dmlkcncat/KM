using Business.Abstract;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProcessesImagesController : ControllerBase
    {
        IProcessesImagesService _processesImagesService;
        public ProcessesImagesController(IProcessesImagesService processesImagesService)
        {
            _processesImagesService = processesImagesService;
        }

        [HttpGet("getall")]
        public IActionResult GetAll()
        {
            var result = _processesImagesService.GetAll();
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result.Message);
        }
    }
}
