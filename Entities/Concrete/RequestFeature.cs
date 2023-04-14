using System;
using Core.Entities;

namespace Entities.Concrete
{
	public class RequestFeature : IEntity
	{

            public int Id { get; set; }
            public string RoomCount { get; set; }
        //option : tek katlı, çift katlı
            public string Option { get; set; }
            public bool Garaj { get; set; }
            public string PlotSquareMeters { get; set; }
            public string HomeSquareMeters { get; set; }
        
	}
}

