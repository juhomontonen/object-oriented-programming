using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskInterface
{
    class Product : IProduct
    {
        //muuttujat
        string Name;
        double Price;
        int Quantity;

        //konstruktori
        public Product(string name, double price, int quantity)
        {
            Name = name;
            Price = price;
            Quantity = quantity;
        }

        //metodit
        public void GetProduct()
        {
            Console.Write("Syötä tuotteen nimi: ");
            string AskName = Console.ReadLine().ToUpper();

            if (AskName.Equals(Name.ToUpper()))
                PrintProductInfo();
            else
                Console.WriteLine($"Tuotetta {AskName} ei löytynyt.");
        }

        public string TotalValue()
        {
            double value = Price * Quantity;
            return $"Kokonaisarvo on {value} euroa.";
        }

        public void PrintProductInfo()
        {
            Console.WriteLine($"{Name}, {Price}, {Quantity}");
        }

        public override string ToString()
        {
            return $"{Name}, {Price}, {Quantity}";
        }

    }
}
