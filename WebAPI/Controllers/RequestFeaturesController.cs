using Business.Abstract;
using Entities.Concrete;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RequestFeaturesController : ControllerBase
    {

        IRequestFeatureService _requestFeatureService;
        public RequestFeaturesController(IRequestFeatureService requesrFeatureService)
        {
            _requestFeatureService = requesrFeatureService;
        }

        [HttpGet("getall")]
        public IActionResult GetAll()
        {
            var result = _requestFeatureService.GetAll();
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result.Message);
        }

        [HttpPost("add")]
        public IActionResult Add(RequestFeature requestFeature )
        {
            var result = _requestFeatureService.Add(requestFeature);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }

        [HttpPost("delete")]
        public IActionResult Delete(RequestFeature requestFeature)
        {
            var result = _requestFeatureService.Delete(requestFeature);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }

        [HttpPost("update")]
        public IActionResult Update(RequestFeature requestFeature)
        {
            var result = _requestFeatureService.Update(requestFeature);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }
    }
}
