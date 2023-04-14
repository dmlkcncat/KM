using System;
using Core.Utilities.Results;
using Entities.Concrete;

namespace Business.Abstract
{
	public interface IContactInformationService
	{
        IDataResult<List<ContactInformation>> GetAll();
        IResult Add(ContactInformation contactInformation);
        IResult Delete(ContactInformation contactInformation);
        IResult Update(ContactInformation contactInformation);
    }
}

