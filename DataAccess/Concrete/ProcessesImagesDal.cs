using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete
{
    public class ProcessesImagesDal : EfEntityRepositoryBase<ProcessesImages, KarbilContext>, IProcessesImagesDal
    {
        public ProcessesImages GetById(int id)
        {
            using (KarbilContext context = new KarbilContext())
            {
                var query = context.ProcessesImages;
                return query.SingleOrDefault();
            }
        }
    }
}
