using System;
using Business.Abstract;
using Business.Constants;
using Core.Utilities.Results;
using DataAccess.Abstract;
using DataAccess.Concrete;
using Entities.Concrete;
using static System.Net.Mime.MediaTypeNames;

namespace Business.Concrete
{
    public class FeaturesManager : IFeaturesService
    {

        IFeaturesDal _featuresDal;

        public FeaturesManager(IFeaturesDal featuresDal)
        {
            _featuresDal = featuresDal;
        }

        public IResult Add(Features features)
        {
            _featuresDal.Add(features);
            return new SuccessResult(Messages.Added);
        }

        public IResult Delete(Features features)
        {
            _featuresDal.Delete(features);
            return new SuccessResult(Messages.Deleted);
        }

        public IDataResult<List<Features>> GetAll()
        {
            return new SuccessDataResult<List<Features>>(_featuresDal.GetAll(), Messages.Listed);
        }

        public IResult Update(Features features)
        {
            _featuresDal.Update(features);
            return new SuccessResult(Messages.Updated);
        }
    }
}

