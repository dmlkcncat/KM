using Business.Abstract;
using Core.Entities.Concrete;
using Core.Services;
using DataAccess.Concrete;
using DocumentFormat.OpenXml.Spreadsheet;
using Entities.Concrete;
using Entities.DTOs;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [Consumes("application/json")]
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

        //[HttpGet("getall")]
        //public IActionResult GetAll(
        //    string? RoomCount,
        //    string? FloorOption,
        //    bool? Garaj,
        //    string? PlotSquareMeters,
        //    string? HomeSquareMeters
        //)
        //{
        //    var result = _productService.GetAll( x => 
        //    (FloorOption != null ? x.FloorOption != null && x.FloorOption == FloorOption! : true) &&
        //    (RoomCount != null ? x.RoomCount != null && x.RoomCount == RoomCount! : true) &&
        //    (Garaj != null ? x.Garaj != null && x.Garaj == Garaj! : true) &&
        //    (PlotSquareMeters != null ? x.PlotSquareMeters != null && x.PlotSquareMeters == PlotSquareMeters! : true) &&
        //    (HomeSquareMeters != null ? x.HomeSquareMeters != null && x.HomeSquareMeters == HomeSquareMeters! : true)
        //    );
        //    if (result.Success)
        //    {
        //        return Ok(result);
        //    }
        //    return BadRequest(result.Message);
        //}

        //[HttpPost("add")]
        //public async Task<IActionResult> AddAsync([FromForm] IFormFile image, [FromForm] Product product)
        //{
        //    String? path = await FileService.UploadFile(image);
        //    product.FirstImage = path;
        //    var result = _productService.Add(product);
        //    if (result.Success)
        //    {
        //        return Ok(result);
        //    }
        //    return BadRequest(result);
        //}

        //[HttpPost("addwithImage")]
        //public async Task<bool> AddWithImage(Product product, IFormFile image)
        //{
        //    try
        //    {
        //        using (KarbilContext context = new KarbilContext())
        //        {
        //            product.FirstImage = await FileService.UploadFile(image);
        //            context.Product.Add(product);
        //            context.SaveChanges();
        //            return true;
        //        }
        //    }
        //    catch (Exception e)
        //    {
        //        Console.WriteLine("Hata Oluştu: " + e.Message);
        //    }
        //    return false;
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
