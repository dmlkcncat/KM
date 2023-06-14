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
    public class ProcessesManager : IProcessesService
    {
        IProcessesDal _processesDal;

        public ProcessesManager(IProcessesDal processesDal)
        {
            _processesDal = processesDal;
        }

        public IDataResult<List<Processes>> GetAll()
        {
            return new SuccessDataResult<List<Processes>>(_processesDal.GetAll(), Messages.Listed);
        }

        public IDataResult<List<Processes>> GetById(int id)
        {
            return new SuccessDataResult<List<Processes>>(_processesDal.GetById(id), Messages.Listed);
        }
    }
}
