using System;
namespace Entities.Concrete
{
	public class Product
	{
		public Product()
		{
			public int Id { get; set;}
		    public string Name { get; set; }
		    public string FirstImage { get; set; }
		//evin tamamlanma tarihi
		    public DateTime CreatedDate { get; set; }
		    public string Location { get; set; }
        //ev gerçekleşti gerçekleşmedi
            public bool Complete { get; set; }
		    public string Description { get; set; }
		    public int CategoryId { get; set; }

          }
    }
}

