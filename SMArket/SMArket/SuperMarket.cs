using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SMArket
{
    internal class SuperMarket
    {
        private string name;
        private string address;
        private string phone;
        private List<Product> products;
        private List<Customer> customers;
        private List<Employee> employees;
        private List<Sale> sales;

        public Supermarket(string name, string address, string phone)
        {
            this.name = name;
            this.address = address;
            this.phone = phone;
            this.products = new List<Product>();
            this.customers = new List<Customer>();
            this.employees = new List<Employee>();
            this.sales = new List<Sale>();
        }

        public void AddProduct(Product product)
        {
            products.Add(product);
        }

        public List<Product> GetProducts()
        {
            return products;
        }

        public Product SearchProduct(string name)
        {
            foreach (Product product in products)
            {
                if (product.GetName() == name)
                {
                    return product;
                }
            }
            return null;
        }

        public void AddCustomer(Customer customer)
        {
            customers.Add(customer);
        }

        public void AddEmployee(Employee employee)
        {
            employees.Add(employee);
        }

        public void AddSale(Sale sale)
        {
            sales.Add(sale);
        }

        public void ServeCustomer(Customer customer)
        {
            Console.WriteLine("Serving customer: " + customer.GetName());
        }

        public double GetTotalSales()
        {
            double totalSales = 0;
            foreach (Sale sale in sales)
            {
                totalSales += sale.GetTotalPrice();
            }
            return totalSales;
        }

        public double GetTotalProfit()
        {
            double totalProfit = 0;
            foreach (Sale sale in sales)
            {
                totalProfit += sale.GetProfit();
            }
            return totalProfit;
        }

        public override string ToString()
        {
            return name + " - " + address + " - " + phone;
        }
    }
}
