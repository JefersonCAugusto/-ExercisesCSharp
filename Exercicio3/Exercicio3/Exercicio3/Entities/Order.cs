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

        public Order(DateTime moment, OrderStatus status)
        {
            Moment = moment;
            Status = status;
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



    }
}
