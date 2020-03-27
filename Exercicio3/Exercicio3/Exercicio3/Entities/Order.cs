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
        public List<OrderItem> Itens { get; set; } = new List<OrderItem>();

        public Order(DateTime moment, OrderStatus status)
        {
            Moment = moment;
            Status = status;
        }

        public void AddItens(OrderItem orderItem)
        {
            Itens.Add(orderItem);
        }
        public void RemovItens(OrderItem orderItem)
        {
            Itens.Remove(orderItem);
        }

    }
}
