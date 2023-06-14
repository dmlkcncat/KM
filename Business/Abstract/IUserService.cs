using System;
using System.Linq.Expressions;
using Core.Utilities.Results;
using Entities.Concrete;

namespace Business.Abstract
{
	public interface IUserService
	{
        IDataResult<List<User>> GetAll();
        IResult Add(User user);
        IResult Delete(User user);
        IResult Update(User user);
        IDataResult<User> GetById(int Id);
        IDataResult<User> Get(Expression<Func<User, bool>> filter);
    }
}

