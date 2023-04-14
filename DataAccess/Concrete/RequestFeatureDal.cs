using System;
using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;
using Entities.Concrete;

namespace DataAccess.Concrete
{
	public class RequestFeatureDal : EfEntityRepositoryBase<RequestFeature, KarbilContext>, IRequestFeatureDal
    {
		
	}
}

