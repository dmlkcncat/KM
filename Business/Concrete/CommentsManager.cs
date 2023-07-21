using Business.Abstract;
using Business.Constants;
using Core.Utilities.Results;
using DataAccess.Abstract;
using DataAccess.Concrete;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class CommentsManager : ICommentsService
    {
        ICommentsDal _commentsDal;

        public CommentsManager(ICommentsDal commentsDal)
        {
            _commentsDal = commentsDal;
        }

        public IResult Add(Comments comments)
        {
            _commentsDal.Add(comments);
            return new SuccessResult(Messages.Added);
        }

        public IResult Delete(Comments comments)
        {
            _commentsDal.Delete(comments);
            return new SuccessResult(Messages.Deleted);
        }

        public IDataResult<List<Comments>> GetAll(Expression<Func<Comments, bool>>? filter = null)
        {
            return new SuccessDataResult<List<Comments>>(_commentsDal.GetAll(filter), Messages.Listed);
        }
    }
}
