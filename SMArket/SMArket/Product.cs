using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SMArket
{
    internal class Product
    {
        private string name;
        private double price;
        private int quantity;
        private string description;

        public Product(string name, double price, int quantity, string description)
        {
            this.name = name;
            this.price = price;
            this.quantity = quantity;
            this.description = description;
        }

        public string GetName()
        {
            return name;




        }




        public void SetPrice(double price)
        {
            this.price = price;
        }

        public override string ToString()
        {
            return name + " - $" + price + " - " + quantity + " - " + description;
        }
    }
}
