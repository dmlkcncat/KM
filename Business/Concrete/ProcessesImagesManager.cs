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
    public class ProcessesImagesManager : IProcessesImagesService
    {
        IProcessesImagesDal _processesImagesDal;

        public ProcessesImagesManager(IProcessesImagesDal processesImagesDal)
        {
            _processesImagesDal = processesImagesDal;
        }

        public IDataResult<List<ProcessesImages>> GetAll()
        {
            return new SuccessDataResult<List<ProcessesImages>>(_processesImagesDal.GetAll(), Messages.Listed);
        }
    }
}
