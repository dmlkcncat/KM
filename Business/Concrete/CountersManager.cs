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
    public class CountersManager : ICountersService
    {

        ICountersDal _countersDal;

        public CountersManager(ICountersDal countersDal)
        {
            _countersDal = countersDal;
        }

        public IDataResult<List<Counters>> GetAll()
        {
            return new SuccessDataResult<List<Counters>>(_countersDal.GetAll(), Messages.Listed);
        }

        public IResult Update(Counters counters)
        {
            _countersDal.Update(counters);
            return new SuccessResult(Messages.Updated);
        }
    }
}
