using System;
using CalcArea.Entities.Enums;
using CalcArea.Entities;
using System.Collections.Generic;
namespace CalcArea
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Ener the number of Shapes: ");

            List<Shape> sh1 = new List<Shape>(); 
            int n1 = int.Parse(Console.ReadLine());

            for (int i = 0; i < n1; i++)
            {
                Console.WriteLine("Shape #{0} data: ", i+1);
                string type;
                Console.Write("Rectangle(r) or Circle(c): ");
                type = Console.ReadLine().ToUpper();
                Console.Write("Color: Red, black, Blue: ");
                Color color = Enum.Parse<Color>(Console.ReadLine());

                if (type == "R")
                {
                    Console.WriteLine("Width: ");
                    double width = double.Parse(Console.ReadLine());
                    Console.WriteLine("height: ");
                    double height = double.Parse(Console.ReadLine());
                    Shape rec1 = new Rectangle(width, height, color);
                    sh1.Add(rec1);
                }


                else
                {
                    Console.WriteLine("Radius: ");
                    double radius = double.Parse(Console.ReadLine());
                    Shape circ1 = new Circle(radius, color);
                    sh1.Add(circ1);
                }

            }
            foreach(Shape sh in sh1)
            {
                Console.WriteLine(sh.Area());
            }
        }
        }
    }

