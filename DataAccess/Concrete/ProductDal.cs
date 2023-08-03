using System;
using System.Linq.Expressions;
using Core.DataAccess.EntityFramework;
using Core.Services;
using DataAccess.Abstract;
using Entities.Concrete;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;

namespace DataAccess.Concrete
{
	public class ProductDal : EfEntityRepositoryBase<Product, KarbilContext>, IProductDal
    {
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
                throw e;
                // TODO: LOG
            }
            return false;
        }

        public Product GetById(int id)
        {
            using (KarbilContext context = new KarbilContext())
            {
                var query = context.Product.Where(item => item.Id == id)
                    .Include(item => item.Category).AsQueryable();
                return query.SingleOrDefault();
            }
        }
    }
}

