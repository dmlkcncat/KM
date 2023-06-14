using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concrete
{
    public class ProcessesImages : IEntity
    {
        public int Id { get; set; }
        public int ProcessesId { get; set; }
        public string Path { get; set; }

        public virtual Processes Processes { get; set; }
    }
}
