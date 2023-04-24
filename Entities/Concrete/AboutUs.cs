using System;
using Core.Entities;

namespace Entities.Concrete
{
	public class AboutUs : IEntity
	{

             public int Id { get; set; }
		     public string Text { get; set; }
    }
}

