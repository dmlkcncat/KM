using Business.Abstract;
using Business.Constants;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class ProjectStepsManager : IProjectStepsService
    {
        IProjectStepsDal _projectStepsDal;

        public ProjectStepsManager(IProjectStepsDal projectStepsDal)
        {
            _projectStepsDal = projectStepsDal;
        }

        public IDataResult<List<ProjectSteps>> GetAll()
        {
            return new SuccessDataResult<List<ProjectSteps>>(_projectStepsDal.GetAll(), Messages.Listed);
        }

        public IResult Update(ProjectSteps projectSteps)
        {
            _projectStepsDal.Update(projectSteps);
            return new SuccessResult(Messages.Updated);
        }
    }
}
