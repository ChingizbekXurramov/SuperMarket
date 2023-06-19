using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SMArket
{
    internal class Employee
    {
        private string name;
        private string position;
        private double salary;

        public Employee(string name, string position, double salary)
        {
            this.name = name;
            this.position = position;
            this.salary = salary;
        }

        public string GetName()
        {
            return name;
        }

        public override string ToString()
        {
            return name + " - " + position + " - $" + salary;
        }
    }
}
