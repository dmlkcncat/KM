using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concrete
{
    public class Counters : IEntity
    {
        public int Id { get; set; }
        public int Count { get; set; }
        public string? Name { get; set; }

    }
}
