using System;
using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;
using Entities.Concrete;

namespace DataAccess.Concrete
{
	public class UserDal : EfEntityRepositoryBase<User, KarbilContext>, IUserDal
    {
	}
}

