using System;
using Core.Utilities.Results;
using Entities.Concrete;

namespace Business.Abstract
{
	public interface IAboutUsService
	{
        IDataResult<List<AboutUs>> GetAll();
        IResult Add(AboutUs aboutUs);
        IResult Delete(AboutUs aboutUs);
        IResult Update(AboutUs aboutUs);
    }
}

