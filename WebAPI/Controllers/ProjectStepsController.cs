using Business.Abstract;
using Entities.Concrete;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [Consumes("application/json")]
    [ApiController]
    public class ProjectStepsController : ControllerBase
    {

        IProjectStepsService _projectStepsService;
        public ProjectStepsController(IProjectStepsService projectStepsService)
        {
            _projectStepsService = projectStepsService;
        }

        [HttpGet("getall")]
        public IActionResult GetAll()
        {
            var result = _projectStepsService.GetAll();
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result.Message);
        }

        [HttpPost("update")]
        public IActionResult Update(ProjectSteps projectSteps)
        {
            var result = _projectStepsService.Update(projectSteps);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }
    }
}
