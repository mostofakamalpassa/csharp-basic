﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreateTypes.Methods
{
    class Rectangle
    {
        public readonly float Width, Height;
        public Rectangle(float width, float height)
        {
            Width = width;
            Height = height;
        }
        public void Deconstruct(out float width, out float height)
        {
            width = Width;
            height = Height;
        }
    }
}
