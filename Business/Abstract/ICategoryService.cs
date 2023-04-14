﻿using System;
using Core.Utilities.Results;
using Entities.Concrete;

namespace Business.Abstract
{
	public interface ICategoryService
	{

        IDataResult<List<Category>> GetAll();
        IResult Add(Category category);
        IResult Delete(Category category);
        IResult Update(Category category);
    }
}

