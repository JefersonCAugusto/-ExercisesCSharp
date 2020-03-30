using System;
using System.Collections.Generic;
using System.Text;
using CalcArea.Entities.Enums;
using CalcArea.Entities;

namespace CalcArea.Entities
{
    abstract class Shape
    {
        public Color Color { get; set; }

        public Shape(Color color)
        {
            Color = color;
        }

        public abstract double Area();

    }
}
