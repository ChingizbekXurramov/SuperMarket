using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SMArket
{
    internal class Sale
    {
        private DateTime date;
        private Customer customer;
        private Employee employee;
        private Product product;
        private int quantity;

        public Sale(DateTime date, Customer customer, Employee employee, Product product, int quantity)
        {
            this.date = date;
            this.customer = customer;
            this.employee = employee;
            this.product = product;
            this.quantity = quantity;
        }

        public double GetTotalPrice()
        {
            return product.GetPrice() * quantity;
        }

        public double GetProfit()
        {
            return GetTotalPrice() - (product.GetCost() * quantity);
        }

        public override string ToString()
        {
            return date.ToString("dd/MM/yyyy") + " - " + customer.GetName() + " - " + employee.GetName() + " - " + product.GetName() + " - " + quantity + " - $" + GetTotalPrice();
        }
    }
}
