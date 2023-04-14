using System;
using Core.Entities;

namespace Entities.Concrete
{
	public class ContactForm : IEntity
	{
		
             public int Id { get; set; }
		     public string FullName { get; set; }
		     public string Telephone { get; set; }
		     public string Mail { get; set; }
		     public string Description { get; set; }
		     public int RequestFeature { get; set; }
        
	}
}

