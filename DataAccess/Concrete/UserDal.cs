using System;
using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;
using Entities.Concrete;

namespace DataAccess.Concrete
{
	public class UserDal : EfEntityRepositoryBase<User, KarbilContext>, IUserDal
    {
        public User GetById(int id)
        {
            using (KarbilContext context = new KarbilContext())
            {
                var query = context.User;
                return query.SingleOrDefault();
            }
        }
    }
}

