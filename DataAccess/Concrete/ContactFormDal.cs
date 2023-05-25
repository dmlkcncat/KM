using System;
using System.Linq.Expressions;
using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using Microsoft.EntityFrameworkCore;

namespace DataAccess.Concrete
{
    public class ContactFormDal : EfEntityRepositoryBase<ContactForm, KarbilContext>, IContactFormDal
    {
        public Task<bool> AddDto(ContactFormDto contactFormDto) => throw null;

        public List<ContactForm> GetAll(Expression<Func<ContactForm, bool>> filter = null)
        {

            using (KarbilContext context = new KarbilContext())
            {
                var query = context.ContactForm
                    .Include(item => item.RequestFeature).AsQueryable();

                if (filter != null) query = query.Where(filter);

                return query.ToList();
            }
        }

        public ContactForm GetById(int id)
        {
            using (KarbilContext context = new KarbilContext())
            {
                var query = context.ContactForm.Where(item => item.Id == id)
                    .Include(item => item.RequestFeature).AsQueryable();
                return query.SingleOrDefault();
            }
        }
    }
}

