using Core;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.DTOs
{
    public class ProductDto : IDto
    {
        public int Id { get; set; }
        public int Name { get; set; }
        public  string? FirstImage { get; set; }
        public DateTime CreatedDate { get; set; }
        public string? Location { get; set; }
        public bool Complete { get; set; }
        public string? Description { get; set; }
        public int ? CategoryId { get; set; }
        public List<Image>? Image { get; set; }
    }
}
