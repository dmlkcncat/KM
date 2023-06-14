using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;
using Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete
{
    public class ProcessesDal : EfEntityRepositoryBase<Processes, KarbilContext>, IProcessesDal
    {
        //public Processes GetById(int id)
        //{
        //    using (KarbilContext context = new KarbilContext())
        //    {
        //        var query = context.Processes;
        //        return query.SingleOrDefault();
        //    }
        //}
        public List<Processes> GetAll(Expression<Func<Processes, bool>> filter = null)
        {

            using (KarbilContext context = new KarbilContext())
            {
                var query = context.Processes
                    .Include(item => item.ProcessesImages).AsQueryable();

                if (filter != null) query = query.Where(filter);

                return query.ToList();
            }
        }

        public List<Processes> GetById(int id)
        {
            using (KarbilContext context = new KarbilContext())
            {
                var query = context.Processes.Where(item => item.Id == id)
                    .Include(item => item.ProcessesImages).AsQueryable();
                return query.ToList();
            }
        }
    }
}
