﻿using System;
using Core.Entities;

namespace Entities.Concrete
{
    public class AboutUs : IEntity
    {

        public int Id { get; set; }
        public string Text { get; set; }
        public string Title { get; set; }
        public bool Active { get; set; }
    }
}

