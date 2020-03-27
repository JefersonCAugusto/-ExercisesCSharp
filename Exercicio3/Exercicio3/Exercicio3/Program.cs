using System;
using Exercicio3.Entities.Enums;
using Exercicio3.Entities;
namespace Exercicio3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter with cliente data");
            Console.Write("Name: ");
            string nameTemp = Console.ReadLine();

            Console.Write("Enter with Email");
            string emailTemp = Console.ReadLine();

            Console.WriteLine("Enter with birth date(DD/MM/AAAA): ");
            DateTime dateTemp = DateTime.Parse(Console.ReadLine());

            Console.WriteLine("Status(Pending_payment/Processing/Shipped/Delivered: ");
            OrderStatus orderTemp = Enum.Parse<OrderStatus>(Console.ReadLine());

            Console.WriteLine("how many products do you want to buy?");
            int nProduct = int.Parse(Console.ReadLine());
            


            for (int i=1;i<=nProduct;i++)
            Console.WriteLine("");

            
            
           
        }
    }
}
