namespace SMArket
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Supermarket sinfi
            Supermarket supermarket = new Supermarket("Supermarket", "Tashkent", "+99871234567");

            // Product sinfi
            Product product1 = new Product("Milk", 1.50, 50, "1L");
            Product product2 = new Product("Bread", 0.75, 100, "500g");

            // Mahsulot qo'shish funktsiyasi
            supermarket.AddProduct(product1);
            supermarket.AddProduct(product2);

            // Mahsulotlarni ko'rish va qidirish funktsiyasi
            Console.WriteLine("All products:");
            foreach (Product product in supermarket.GetProducts())
            {
                Console.WriteLine(product);
            }

            Console.WriteLine("Search for 'Milk':");
            Product searchedProduct = supermarket.SearchProduct("Milk");
            if (searchedProduct != null)
            {
                Console.WriteLine(searchedProduct);
            }
            else
            {
                Console.WriteLine("Product not found.");
            }

            // Customer sinfi
            Customer customer1 = new Customer("John Doe", "New York", "+11234567890");
            Customer customer2 = new Customer("Jane Smith", "London", "+442071234567");

            // Mijozlar ro'yxatiga qo'shish funktsiyasi
            supermarket.AddCustomer(customer1);
            supermarket.AddCustomer(customer2);

            // Xodimlar sinfi
            Employee employee1 = new Employee("Bob Johnson", "Cashier", 500);
            Employee employee2 = new Employee("Alice Brown", "Manager", 1000);

            // Xodimlar ro'yxatiga qo'shish funktsiyasi
            supermarket.AddEmployee(employee1);
            supermarket.AddEmployee(employee2);

            // Mahsulotlar narxini belgilash funktsiyasi
            product1.SetPrice(1.75);

            // Mijozlarga xizmat ko'rsatish funktsiyasi
            supermarket.ServeCustomer(customer1);

            // Sotuvlar tarixini saqlash funktsiyasi
            supermarket.AddSale(new Sale(DateTime.Now, customer1, employee1, product1, 2));

            // Hisob-kitob funktsiyalari
            Console.WriteLine("Total sales: " + supermarket.GetTotalSales());
            Console.WriteLine("Total profit: " + supermarket.GetTotalProfit());
        }
    }
}