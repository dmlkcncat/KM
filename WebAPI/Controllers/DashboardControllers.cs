using Business.Abstract;
using DataAccess.Concrete;
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
    [Consumes("application/json")]
    [ApiController]
    public class DashboardsController : ControllerBase
    {
        ICategoryService _categoryService;
        IProductService _productService;
        IContactFormService _contactFormService;
        IUserService _userService;
        public DashboardsController(
            ICategoryService categoryService,
            IProductService productService,
            IContactFormService contactFormService,
            IUserService userService
            )
        {
            _categoryService = categoryService;
            _productService = productService;
            _contactFormService = contactFormService;
            _userService = userService;
        }
        [AllowAnonymous]
        [HttpGet("get")]
        public IActionResult Get()
        {
            using (var context = new KarbilContext())
            {
                var categorycount = context.Category.Count();
                var productCount = context.Product.Count();
                var contactFormCount = context.ContactForm.Count();
                var userCount = context.User.Count();


                return Ok(new
                {
                    categorycount = categorycount,
                    productCount = productCount,
                    contactFormCount = contactFormCount,
                    userCount = userCount
                });
            }

        }
    }
}
