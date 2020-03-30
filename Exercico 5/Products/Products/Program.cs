using System;
using System.Collections.Generic;
using Products.Entities;
namespace Products
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter with de number of products");
            int n1 = int.Parse(Console.ReadLine());
            List<Product> p1 = new List<Product>();
            for (int i = 0; i < n1; i++)
            {
                Console.Write("This product is:\nCommon(C), Used(U) or Imported(I)");
                string type = Console.ReadLine().ToUpper();
                Console.WriteLine("Product #{0}: ", i + 1);
                Console.Write("Name: ");
                string name = Console.ReadLine();
                Console.Write("Price: ");
                double price = double.Parse(Console.ReadLine());

                switch (type)
                {
                    case "C": Product c1 = new Product(name, price);
                        p1.Add(c1);
                        break;
                    case "U": Console.Write("Manufacture Date: (DD/MM/YYY): ");
                }
            }
            }
        }
    }
