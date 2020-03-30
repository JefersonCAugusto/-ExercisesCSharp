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
                if (i>0)
                    Console.WriteLine("--------------------------------");
                Console.Write("This product is:\nCommon(C), Used(U) or Imported(I)");
                string type = Console.ReadLine().ToUpper();
                Console.WriteLine("Product #{0}: ", i + 1);
                Console.Write("Name: ");
                string name = Console.ReadLine();
                Console.Write("Price: ");
                double price = double.Parse(Console.ReadLine());

                switch (type)
                {
                    case "C":
                        Product c1 = new Product(name, price);
                        p1.Add(c1);
                        break;
                    case "U":
                        Console.Write("Manufacture Date: (DD/MM/YYY): ");
                        DateTime manucafture = DateTime.Parse(Console.ReadLine());
                        Product u1 = new UsedProduct(manucafture, name, price);
                        p1.Add(u1);
                        break;
                    case "I":
                        Console.WriteLine("Customs fee: ");
                        double fee = double.Parse(Console.ReadLine());
                        Product i1 = new ImportedProduct(fee, name, price);
                        p1.Add(i1);
                        break;
                    default:
                        Console.WriteLine("Invalid");
                        break;


                }
              

            }
            foreach (Product product in p1)
            {
                Console.WriteLine(product.PriceTag());

            }
        }
    }
}
