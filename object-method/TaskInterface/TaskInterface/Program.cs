using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskInterface
{
    class Program
    {
        public static List<Product> products = new List<Product>();
        public static List<Customer> customers = new List<Customer>();

        static void Main(string[] args)
        {
            // Product productA = new Product("Maito", 20, 5);

            // Console.WriteLine(productA.ToString());
            // Console.WriteLine(productA.TotalValue());

            GenerateData();
            PrintData();
            GenerateCustomer();
            PrintCustomer();

            customers[4].CalculateBonus();

            Console.ReadKey();
        }

        //tuotteet
        public static void GenerateData()
        {
            Random rnd = new Random();
            for (int i = 0; i < 10; i++)
            {
                products.Add(new Product("Product " + i, rnd.Next(5, 50), rnd.Next(1, 10)));
            }
        }
        public static void PrintData()
        {
            foreach (var p in products)
            {
                Console.WriteLine(p.ToString());
            }
        }

        //asiakkaat
        public static void GenerateCustomer()
        {
            Random rnd = new Random();
            for (int i = 0; i < 10; i++)
            {
                customers.Add(new Customer("Customer " + i, rnd.Next(5, 2000)));
            }
        }
        public static void PrintCustomer()
        {
            foreach (var c in customers)
            {
                Console.WriteLine(c.ToString());
            }
        }
    }
}
