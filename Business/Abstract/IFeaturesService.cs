using System;
using Core.Utilities.Results;
using Entities.Concrete;

namespace Business.Abstract
{
	public interface IFeaturesService
	{

        IDataResult<List<Features>> GetAll();
        IResult Add(Features features);
        IResult Delete(Features features);
        IResult Update(Features features);
    }
}

