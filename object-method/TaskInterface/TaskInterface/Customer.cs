using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskInterface
{
    class Customer
    {
        //muuttujat
        public string Name;
        public double Goods;

        //konstruktori
        public Customer(string name, double goods)
        {
            Name = name;
            Goods = goods;
        }

        //metodit
        public void PrintCustomerInfo()
        {
            Console.WriteLine($"{Name}, {Goods}");
        }

        public override string ToString()
        {
            return $"{Name}, {Goods}";
        }

        public void GetCustomer()
        {
            Console.Write("Syötä asiakkaan nimi: ");
            string CustomerName = Console.ReadLine().ToUpper();

            if (CustomerName.Equals(Name.ToUpper()))
                PrintCustomerInfo();
            else
                Console.WriteLine($"Tuotetta {CustomerName} ei löytynyt.");
        }

        public void CalculateBonus()
        {
            double Bonus;
            if (Goods <= 1000)
            {
                Bonus = Goods * 0.02;
                Console.WriteLine($"Bonus on 2% eli {Bonus}");
            }
            else if (Goods > 1000 && Goods < 200)
            {
                Bonus = Goods * 0.03;
                Console.WriteLine($"Bonus on 3% eli {Bonus}");
            }
            else
            {
                Bonus = Goods * 0.05;
                Console.WriteLine($"Bonus on 5% eli {Bonus}");
            }

        }


    }
}
