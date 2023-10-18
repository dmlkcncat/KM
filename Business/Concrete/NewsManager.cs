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
    public class NewsManager : INewsService
    {
        INewsDal _newsDal;

        public NewsManager(INewsDal newsDal)
        {
            _newsDal = newsDal;
        }

        public IDataResult<List<News>> GetAll()
        {
            return new SuccessDataResult<List<News>>(_newsDal.GetAll(), Messages.Listed);
        }

        public IResult Update(News news)
        {
            _newsDal.Update(news);
            return new SuccessResult(Messages.Updated);
        }
    }
}
