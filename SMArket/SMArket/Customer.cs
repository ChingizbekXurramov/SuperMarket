using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SMArket
{
    internal class Customer
    {
        private string name;
        private string address;
        private string phone;

        public Customer(string name, string address, string phone)
        {
            this.name = name;
            this.address = address;
            this.phone = phone;
        }

        public string GetName()
        {
            return name;
        }

        public override string ToString()
        {
            return name + " - " + address + " - " + phone;
        }
    }
}
