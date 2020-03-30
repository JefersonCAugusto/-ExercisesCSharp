using System;
using System.Collections.Generic;
using System.Text;
using CalcArea.Entities.Enums;

namespace CalcArea.Entities
{
    class Circle : Shape
    {
        public double Radius { get; set; }

        public Circle(double radius, Color color): base(color)
        {
            Radius = radius;
        }

        public override double Area()
        {
            throw new NotImplementedException();
        }
    }
}
