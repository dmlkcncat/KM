using System;
using Core.Entities;

namespace Entities.Concrete
{
	public class ContactInformation : IEntity
	{

              public int Id { get; set; }
		      public string Mail { get; set; }
		      public string Telephone { get; set; }
		      public string Address { get; set; }

       
	}
}

