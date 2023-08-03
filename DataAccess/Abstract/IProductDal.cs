using System;
using System.Linq.Expressions;
using Core.DataAccess;
using Entities.Concrete;
using Entities.DTOs;
using Microsoft.AspNetCore.Http;

namespace DataAccess.Abstract
{
    public interface IProductDal : IEntityRepository<Product>
    {
        Task<bool> AddWithImage(Product product, IFormFile image);
        //Task<bool> AddDto(ProductDto productDto, IFormFile image, List<IFormFile> images);
    }
}

