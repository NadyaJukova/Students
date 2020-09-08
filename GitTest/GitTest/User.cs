﻿using System;
using System.Collections.Generic;
using System.Text;

namespace GitTest
{
    class User : IDrawable
    {
        public string Id { get; set; }
        public string Name { get; set; }

        public void Draw()
        {
            Console.WriteLine($"Class:User. Value:ID:{this.Id},Name:{this.Name}");
        }
    }
}
