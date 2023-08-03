using Business.Abstract;
using Core.Entities.Concrete;
using Core.Services;
using DataAccess.Concrete;
using DocumentFormat.OpenXml.Spreadsheet;
using Entities.Concrete;
using Entities.DTOs;
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
    public class ProductsController : ControllerBase
    {
        IProductService _productService;
        IImageService _imageService;

        public ProductsController(IProductService productService, IImageService imageService)
        {
            _productService = productService;
            _imageService = imageService;

        }

        [HttpGet("getall")]
        public IActionResult GetAll(
            string? RoomCount,
            string? FloorOption,
            bool? Garaj,
            string? PlotSquareMeters,
            string? HomeSquareMeters
        )
        {
            var result = _productService.GetAll( x => 
            (FloorOption != null ? x.FloorOption != null && x.FloorOption == FloorOption! : true) &&
            (RoomCount != null ? x.RoomCount != null && x.RoomCount == RoomCount! : true) &&
            (Garaj != null ? x.Garaj != null && x.Garaj == Garaj! : true) &&
            (PlotSquareMeters != null ? x.PlotSquareMeters != null && x.PlotSquareMeters == PlotSquareMeters! : true) &&
            (HomeSquareMeters != null ? x.HomeSquareMeters != null && x.HomeSquareMeters == HomeSquareMeters! : true)
            );
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result.Message);
        }

        [HttpPost("add")]
        public async Task<IActionResult> AddAsync([FromForm] IFormFile image, [FromForm] Product product)
        {
            String? path = await FileService.UploadFile(image);
            product.FirstImage = path;
            var result = _productService.Add(product);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }

        public async Task<bool> AddWithImage(Product product, IFormFile image)
        {
            try
            {
                using (KarbilContext context = new KarbilContext())
                {
                    product.FirstImage = await FileService.UploadFile(image);
                    context.Product.Add(product);
                    context.SaveChanges();
                    return true;
                }
            }
            catch (Exception e)
            {
                // TODO: LOG
            }
            return false;
        }


        //[TypeFilter(typeof(Filters.Perm))]
        //[HttpPost("addDto")]
        //[DisableRequestSizeLimit]
        //public async Task<IActionResult> AddDto(
        //     IFormFile image,
        //     List<IFormFile> images,
        //     [FromForm] ProductDto productDto
        // )
        //{
        //    IResult result = await _productService.AddDto(productDto, image, images);
        //    if (result.Success)
        //    {
        //        return Ok(result);
        //    }
        //    return BadRequest(result);
        //}

        [HttpPost("delete")]
        public IActionResult Delete(Product product)
        {
            var result = _productService.Delete(product);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }

        [HttpPost("update")]
        public IActionResult Update(Product product)
        {
            var result = _productService.Update(product);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }
    }
}
