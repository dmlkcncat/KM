using System;
using Business.Abstract;
using Business.Constants;
using Core.Utilities.Results;
using DataAccess.Abstract;
using DataAccess.Concrete;
using Entities.Concrete;

namespace Business.Concrete
{
    public class ContactInformationManager : IContactInformationService
    {

        IContactInformationDal _contactInformationDal;

        public ContactInformationManager(IContactInformationDal contactInformationDal)
        {
            _contactInformationDal = contactInformationDal;
        }


        public IResult Add(ContactInformation contactInformation)
        {
            _contactInformationDal.Add(contactInformation);
            return new SuccessResult(Messages.Added);
        }

        public IResult Delete(ContactInformation contactInformation)
        {
            _contactInformationDal.Delete(contactInformation);
            return new SuccessResult(Messages.Deleted);
        }

        public IDataResult<List<ContactInformation>> GetAll()
        {
            return new SuccessDataResult<List<ContactInformation>>(_contactInformationDal.GetAll(), Messages.Listed);
        }

        public IResult Update(ContactInformation contactInformation)
        {
            _contactInformationDal.Update(contactInformation);
            return new SuccessResult(Messages.Updated);
        }
    }
}

