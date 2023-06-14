using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concrete
{
    public class Processes : IEntity
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string FirstImage { get; set; }

        public virtual List<ProcessesImages> ProcessesImages { get; set; }
        //public virtual ProcessesImages ProcessesImages { get; set; }

    }
}
