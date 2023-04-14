using System;
using Business.Abstract;
using Business.Constants;
using Core.Utilities.Results;
using DataAccess.Abstract;
using DataAccess.Concrete;
using Entities.Concrete;

namespace Business.Concrete
{
    public class ContactFormManager : IContactFormService
    {
        IContactFormDal _contactFormDal;

        public ContactFormManager(IContactFormDal contactFormDal)
        {
            _contactFormDal = contactFormDal;
        }

        public IResult Add(ContactForm contactForm)
        {
            _contactFormDal.Add(contactForm);
            return new SuccessResult(Messages.Added);
        }

        public IResult Delete(ContactForm contactForm)
        {
            _contactFormDal.Delete(contactForm);
            return new SuccessResult(Messages.Deleted);
        }

        public IDataResult<List<ContactForm>> GetAll()
        {
            return new SuccessDataResult<List<ContactForm>>(_contactFormDal.GetAll(), Messages.Listed);
        }

        public IResult Update(ContactForm contactForm)
        {
            _contactFormDal.Update(contactForm);
            return new SuccessResult(Messages.Updated);
        }
    }
}

