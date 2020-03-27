using System;
using System.Collections.Generic;
using System.Text;
using Exercicio3.Entities.Enums;
namespace Exercicio3.Entities
{
    class Order
    {
        public DateTime Moment { get; set; }
        public OrderStatus Status { get; set; }
        public List<OrderItem> Items { get; set; } = new List<OrderItem>();
        public Client Client { get; set; }

        public Order(DateTime moment, OrderStatus status, string name, string email,DateTime birth)
        {
            Moment = moment;
            Status = status;
            Client c1= new Client(name, email, birth);

        }

        public void AddItens(OrderItem orderItem)
        {
            Items.Add(orderItem);
        }
        public void RemovItens(OrderItem orderItem)
        {
            Items.Remove(orderItem);
        }
        public double Total()
        {
            double sum = 0;
            foreach (OrderItem items in Items)
            {
                sum = sum + items.SubTotal();
            }
            return sum;
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("Order Summary");
            sb.Append("Order Hour: "); sb.AppendLine(Moment.ToString("dd/MM/yyyy HH:mm:ss"));
            sb.Append("Order status: "); sb.AppendLine(Status.ToString());
            sb.Append("Client: "); sb.Append(Client.Name + " - "); 
            sb.Append(Client.BirthDate + " - "); sb.Append(Client.Email+"\n\n");
            sb.AppendLine("------Order Items------");
            sb.AppendLine("Order items: ");
            double total = 0;
            foreach (OrderItem producList in Items)
            {
                sb.Append(producList.Product+", "); 
                sb.Append("$"+producList.Price);
                sb.Append(" Quantity: "); 
                sb.Append(producList.Quantity.ToString()+" "); 
                sb.Append("Subtotal: ");
                sb.AppendLine(producList.SubTotal().ToString());
                total += producList.SubTotal();
            }

            sb.Append("TOTAL PRICE: $");
            sb.AppendLine(total.ToString());

            return ToString();
        }   

    }
}
