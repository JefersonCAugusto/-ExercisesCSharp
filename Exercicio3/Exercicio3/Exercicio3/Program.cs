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

            Console.Write("Enter with Email: ");
            string emailTemp = Console.ReadLine();

            Console.Write("Enter with birth date(DD/MM/AAAA): ");
            DateTime birthTemp = DateTime.Parse(Console.ReadLine());

            Console.Write("Status (Pending_payment/Processing/Shipped/Delivered: ");
            OrderStatus orderTemp = Enum.Parse<OrderStatus>(Console.ReadLine());

            Console.Write("how many products do you want to buy? ");
            int nProduct = int.Parse(Console.ReadLine());

            DateTime momentTemp = DateTime.Now;

            Order order = new Order(momentTemp, orderTemp,nameTemp,emailTemp,birthTemp);
            Client c1 = new Client(nameTemp, emailTemp, birthTemp);
            order.AddClient(c1);
            for (int i = 1; i <= nProduct; i++)
            {
                Console.Write("Product name: ");
                string product = Console.ReadLine();

                Console.Write("Product price: ");
                double price = double.Parse(Console.ReadLine());

                Console.Write("Product quantity: ");
                int quantity = int.Parse(Console.ReadLine());
                Product p1 = new Product(product, price);
                OrderItem prod = new OrderItem(quantity, price,p1);
                order.Items.Add(prod);

            }
            //Console.WriteLine(order);   // futuramente implementar tostring
            Console.WriteLine("\n\nCliente :"+order.Client.Name+" - "+order.Client.BirthDate+" - "+order.Client.Email);
            Console.WriteLine("----Order Items----\n");
            double total=0;
            foreach (OrderItem producList in order.Items)
            {
                Console.WriteLine("Item: "+producList.Product.Name);
                Console.WriteLine("Pric: $"+producList.Price);
                Console.WriteLine("qty: "+producList.Quantity);
                Console.Write("Subtotal: ");
                Console.WriteLine(producList.SubTotal().ToString());
                total += producList.SubTotal();
            }

            Console.WriteLine("\nTotal : "+ total);
            Console.ReadLine();


        }
    }
}
