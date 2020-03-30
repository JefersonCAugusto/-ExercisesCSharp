using System;
using System.Collections.Generic;
using System.Text;
using CalcArea.Entities.Enums;
namespace CalcArea.Entities
{
    class Rectangle : Shape
    {
        public double  Width { get; set; }
        public double Height { get; set; }

        public Rectangle(double width, double height, Color color):(color)
        {
            Width = width;
            Height = height;
        }
    }
}
