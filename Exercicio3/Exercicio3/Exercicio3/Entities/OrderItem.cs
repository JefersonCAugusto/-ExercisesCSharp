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


        public OrderItem(int quantity, double price, Product prod1)
        {
            Quantity = quantity;
            Price = price;
            Product = prod1;
    
        }


        public double SubTotal()
        {
            return Quantity * Price;
        }

        public void AddProduct(double price, string product)
        {
            Product p1 = new Product(product, price);
      
        }

        public void RemovProduct(string product)
        {
            Product.Name = product;
        }

    }
}
