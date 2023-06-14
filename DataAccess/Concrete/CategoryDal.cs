using System;
using System.Linq.Expressions;
using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;
using Entities.Concrete;
using Microsoft.EntityFrameworkCore;

namespace DataAccess.Concrete
{
	public class CategoryDal : EfEntityRepositoryBase<Category, KarbilContext>, ICategoryDal
    {
        public List<Category> GetAll(Expression<Func<Category, bool>> filter = null)
        {

            using (KarbilContext context = new KarbilContext())
            {
                var query = context.Category
                    .Include(item => item.Product).AsQueryable();

                if (filter != null) query = query.Where(filter);

                return query.ToList();
            }
        }

        public List<Category> GetById(int id)
        {
            using (KarbilContext context = new KarbilContext())
            {
                var query = context.Category.Where(item => item.Id == id)
                    .Include(item => item.Product).AsQueryable();
                return query.ToList();
            }
        }

    }

}

