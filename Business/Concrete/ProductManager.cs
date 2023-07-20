using System;
using Business.Abstract;
using Business.Constants;
using Core.Utilities.Results;
using DataAccess.Abstract;
using DataAccess.Concrete;
using Entities.Concrete;
using Entities.DTOs;
using Microsoft.AspNetCore.Http;

namespace Business.Concrete
{
    public class ProductManager : IProductService
    {
        IProductDal _productDal;

        public ProductManager(IProductDal productDal)
        {
            _productDal = productDal;
        }


        public IResult Add(Product product)
        {
            _productDal.Add(product);
            return new SuccessResult(Messages.Added);
        }

        //public async Task<IResult> AddDto(ProductDto productDto, IFormFile image, List<IFormFile> images)
        //{
        //    if (await _productDal.AddDto(productDto, image, images))
        //        return new SuccessResult(Messages.Added);
        //    return new ErrorResult();
        //}

        public IResult Delete(Product product)
        {
            _productDal.Delete(product);
            return new SuccessResult(Messages.Deleted);
        }

        public async Task<IResult> AddWithImage(Product product, IFormFile image)
        {
            await _productDal.AddWithImage(product, image);
            return new SuccessResult(Messages.Added);
        }

        public IDataResult<List<Product>> GetAll()
        {
            return new SuccessDataResult<List<Product>>(_productDal.GetAll(), Messages.Listed);
        }

        public IResult Update(Product product)
        {
            _productDal.Update(product);
            return new SuccessResult(Messages.Updated);
        }
    }
}

