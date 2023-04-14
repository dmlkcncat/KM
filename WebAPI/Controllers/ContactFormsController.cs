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
    public class ContactFormsController : ControllerBase
    {
        IContactFormService _contactFormService;
        public ContactFormsController(IContactFormService contactFormService)
        {
            _contactFormService = contactFormService;
        }

        [HttpGet("getall")]
        public IActionResult GetAll()
        {
            var result = _contactFormService.GetAll();
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result.Message);
        }

        [HttpPost("add")]
        public IActionResult Add(ContactForm contactForm)
        {
            var result = _contactFormService.Add(contactForm);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }

        [HttpPost("delete")]
        public IActionResult Delete(ContactForm contactForm)
        {
            var result = _contactFormService.Delete(contactForm);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }

        [HttpPost("update")]
        public IActionResult Update(ContactForm contactForm)
        {
            var result = _contactFormService.Update(contactForm);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }
    }
}
