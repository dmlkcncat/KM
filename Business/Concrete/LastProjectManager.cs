using Business.Abstract;
using Business.Constants;
using Core.Utilities.Results;
using DataAccess.Abstract;
using DataAccess.Concrete;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete 
{
    public class LastProjectManager : ILastProjectService
    {
        ILastProjectDal _lastProjectDal;

        public LastProjectManager(ILastProjectDal lastProjectDal)
        {
            _lastProjectDal = lastProjectDal;
        }

        public IDataResult<List<LastProject>> GetAll()
        {
            return new SuccessDataResult<List<LastProject>>(_lastProjectDal.GetAll(), Messages.Listed);
        }

        public IResult Update(LastProject lastProject)
        {
            _lastProjectDal.Update(lastProject);
            return new SuccessResult(Messages.Updated);
        }
    }
}
