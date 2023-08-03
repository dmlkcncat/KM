using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concrete
{
    public class Comments :IEntity
    {
        public int Id { get; set; }
        public string? UserName { get; set; }
        public DateTime CreatedDate { get; set; }
        public string? Title { get; set; }
        public string? Comment { get; set; }
        public Boolean Active { get; set; } = false;

    }
}
