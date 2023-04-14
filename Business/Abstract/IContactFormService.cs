using System;
using Core.Utilities.Results;
using Entities.Concrete;

namespace Business.Abstract
{
	public interface IContactFormService
	{
        IDataResult<List<ContactForm>> GetAll();
        IResult Add(ContactForm contactForm);
        IResult Delete(ContactForm contactForm);
        IResult Update(ContactForm contactForm);
    }
}

