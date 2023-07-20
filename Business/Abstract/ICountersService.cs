using Core.Utilities.Results;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface ICountersService
    {
        IDataResult<List<Counters>> GetAll();
        IResult Update(Counters counters);
    }
}
