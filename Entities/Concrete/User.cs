using System;
using Core.Entities;

namespace Entities.Concrete
{
	public class User : IEntity
	{
		
           public int Id { get; set; }
           public string Mail { get; set; }
		   public string FullName { get; set; }
		   public string Password { get; set; }
		   public string Token { get; set; }
	}
}

