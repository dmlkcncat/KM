using Core.Utilities.Results;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface ISSSService
    {
        IDataResult<List<SSS>> GetAll();
        IResult Add(SSS sss);
        IResult Delete(SSS sss);
        IResult Update(SSS sss);
    }
}
