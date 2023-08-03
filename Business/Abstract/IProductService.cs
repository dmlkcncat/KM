using System;
using System.Linq.Expressions;
using Core.Utilities.Results;
using Entities.Concrete;
using Entities.DTOs;
using Microsoft.AspNetCore.Http;

namespace Business.Abstract
{
	public interface IProductService
	{
        IDataResult<List<Product>> GetAll(Expression<Func<Product, bool>>? filter = null);
        IResult Add(Product product);
        Task<IResult> AddWithImage(Product product, IFormFile image);
        //Task<IResult> AddDto(ProductDto productDto, IFormFile image, List<IFormFile> images);
        IResult Delete(Product product);
        IResult Update(Product product);
    }
}

