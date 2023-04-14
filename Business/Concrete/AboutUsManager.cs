using System;
using Business.Abstract;
using Business.Constants;
using Core.Utilities.Results;
using DataAccess.Abstract;
using DataAccess.Concrete;
using Entities.Concrete;

namespace Business.Concrete
{
    public class AboutUsManager : IAboutUsService
    {

        IAboutUsDal _aboutUsDal;

        public AboutUsManager(IAboutUsDal aboutUsDal)
        {
            _aboutUsDal = aboutUsDal;
        }

        public IResult Add(AboutUs aboutUs)
        {
            _aboutUsDal.Add(aboutUs);
            return new SuccessResult(Messages.Added);
        }

        public IResult Delete(AboutUs aboutUs)
        {
            _aboutUsDal.Delete(aboutUs);
            return new SuccessResult(Messages.Deleted);
        }

        public IDataResult<List<AboutUs>> GetAll()
        {
            return new SuccessDataResult<List<AboutUs>>(_aboutUsDal.GetAll(), Messages.Listed);
        }

        public IResult Update(AboutUs aboutUs)
        {
            _aboutUsDal.Update(aboutUs);
            return new SuccessResult(Messages.Updated);
        }
    }
}

