using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concrete
{
    public class Comments
    {
        public int Id { get; set; }
        public string UserName { get; set; }
        public DateTime CreateDate { get; set; }
        public string Comment { get; set; }

    }
}
