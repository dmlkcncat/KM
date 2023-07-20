using Business.Abstract;
using Business.Constants;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class SSSManager : ISSSService
    {
        ISSSDal _sssDal;

        public SSSManager(ISSSDal sssDal)
        {
            _sssDal = sssDal;
        }

        public IResult Add(SSS sss)
        {
            _sssDal.Add(sss);
            return new SuccessResult(Messages.Added);
        }

        public IResult Delete(SSS sss)
        {
            _sssDal.Delete(sss);
            return new SuccessResult(Messages.Deleted);
        }

        public IDataResult<List<SSS>> GetAll()
        {
            return new SuccessDataResult<List<SSS>>(_sssDal.GetAll(), Messages.Listed);
        }

        public IResult Update(SSS sss)
        {
            _sssDal.Update(sss);
            return new SuccessResult(Messages.Updated);
        }
    }
}
