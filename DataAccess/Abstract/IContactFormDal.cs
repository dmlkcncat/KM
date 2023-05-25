using System;
using System.Linq.Expressions;
using Core.DataAccess;
using Entities.Concrete;
using Entities.DTOs;

namespace DataAccess.Abstract
{
	public interface IContactFormDal : IEntityRepository<ContactForm>
    {
        List<ContactForm> GetAll(Expression<Func<ContactForm, bool>> filter = null);
        ContactForm GetById(int id);
        Task<bool> AddDto(ContactFormDto contactFormDto);
    }
}

