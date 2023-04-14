using System;
using Core.Utilities.Results;
using Entities.Concrete;

namespace Business.Abstract
{
	public interface IImageService
	{
        IDataResult<List<Image>> GetAll();
        IResult Add(Image image);
        IResult Delete(Image image);
        IResult Update(Image image);
    }
}

