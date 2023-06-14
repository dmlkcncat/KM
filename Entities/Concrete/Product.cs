using System;
using Core.Entities;

namespace Entities.Concrete
{
	public class Product : IEntity
	{
		
			public int Id { get; set;}
		    public string? Name { get; set; }
		    public string? FirstImage { get; set; }
		//evin tamamlanma tarihi
		    public DateTime? CreatedDate { get; set; }
		    public string? Location { get; set; }
        //ev gerçekleşti gerçekleşmedi
            public bool? Complete { get; set; }
		    public string? Description { get; set; }
		    public int CategoryId { get; set; }

			
			public virtual Category Category { get; set; }
			public virtual List<Image> Images { get; set; }
    }
}

