
using CalcArea.Entities.Enums;
namespace CalcArea.Entities
{
    class Rectangle : Shape
    {
        public double  Width { get; set; }
        public double Height { get; set; }

        public Rectangle(double width, double height, Color color):base (color)
        {
            Width = width;
            Height = height;
        }

        public override double Area()
        {
            double? value = Width * Height;
            return value.GetValueOrDefault(1);
          

        }
    }
}
