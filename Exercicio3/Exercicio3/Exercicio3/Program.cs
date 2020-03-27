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
            DateTime dateTemp = DateTime.Now;

            Console.Write("Status (Pending_payment/Processing/Shipped/Delivered: ");
            OrderStatus orderTemp = Enum.Parse<OrderStatus>(Console.ReadLine());

            Console.WriteLine("how many products do you want to buy?");
            int nProduct = int.Parse(Console.ReadLine());


            Order order = new Order(dateTemp, orderTemp);
            order.Client.Name = nameTemp;
            order.Client.Email = emailTemp;
            for (int i = 1; i <= nProduct; i++)
            {
                Console.WriteLine("Product name: ");
                string product = Console.ReadLine();

                Console.WriteLine("Product price: ");
                double price = double.Parse(Console.ReadLine());

                Console.WriteLine("Product quantity: ");
                int quantity = int.Parse(Console.ReadLine());

                OrderItem prod = new OrderItem;

            }



        }
    }
}
