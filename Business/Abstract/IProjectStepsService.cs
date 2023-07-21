﻿using Business.Concrete;
using Business.Constants;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface IProjectStepsService
    {
        IDataResult<List<ProjectSteps>> GetAll();
        IResult Update(ProjectSteps projectSteps);
    }
}
