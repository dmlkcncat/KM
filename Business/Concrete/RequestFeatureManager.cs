using System;
using Business.Abstract;
using Business.Constants;
using Core.Utilities.Results;
using DataAccess.Abstract;
using DataAccess.Concrete;
using Entities.Concrete;

namespace Business.Concrete
{
    public class RequestFeatureManager : IRequestFeatureService
    {

        IRequestFeatureDal _requestFeatureDal;

        public RequestFeatureManager(IRequestFeatureDal requestFeatureDal)
        {
            _requestFeatureDal = requestFeatureDal;
        }

        public IResult Add(RequestFeature requestFeature)
        {
            _requestFeatureDal.Add(requestFeature);
            return new SuccessResult(Messages.Added);
        }

        public IResult Delete(RequestFeature requestFeature)
        {
            _requestFeatureDal.Delete(requestFeature);
            return new SuccessResult(Messages.Deleted);
        }

        public IDataResult<List<RequestFeature>> GetAll()
        {
            return new SuccessDataResult<List<RequestFeature>>(_requestFeatureDal.GetAll(), Messages.Listed);
        }

        public IResult Update(RequestFeature requestFeature)
        {
            _requestFeatureDal.Update(requestFeature);
            return new SuccessResult(Messages.Updated);
        }
    }
}

