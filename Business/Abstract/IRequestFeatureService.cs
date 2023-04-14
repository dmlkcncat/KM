using System;
using Core.Utilities.Results;
using Entities.Concrete;

namespace Business.Abstract
{
	public interface IRequestFeatureService
	{
        IDataResult<List<RequestFeature>> GetAll();
        IResult Add(RequestFeature requestFeature);
        IResult Delete(RequestFeature requestFeature);
        IResult Update(RequestFeature requestFeature);
    }

}

