using System;
using System.Linq.Expressions;
using Core.DataAccess;
using Entities.Concrete;

namespace DataAccess.Abstract
{
	public interface IUserDal : IEntityRepository<User>
    {
        User GetById(int id);
        User Get(Expression<Func<User, bool>> filter);
    }
}

