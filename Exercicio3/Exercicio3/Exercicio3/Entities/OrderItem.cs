using System;
using System.Collections.Generic;
using System.Text;

namespace Exercicio3.Entities
{
    class OrderItem
    {
        public int Quantity { get; set; }
        public double Price { get; set; }
        public Product Product { get; set; }


        public OrderItem(int quantity, double price, string product)
        {
            Quantity = quantity;
            Price = price;
            AddProduct(product);
        }


        public double SubTotal()
        {
            return Quantity * Price;
        }

        public void AddProduct(string product)
        {
            Product.Name = product;
            Product.Price = Price;
        }

        public void RemovProduct(string product)
        {
            Product.Name = product;
        }

    }
}
