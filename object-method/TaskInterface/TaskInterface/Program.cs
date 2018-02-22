using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskInterface
{
    class Program
    {
        static void Main(string[] args)
        {
            IProduct iproductA = new IProduct("Maito", 20, 5);


            iproductA.PrintProductInfo();
            Console.WriteLine(iproductA.TotalValue());

            Console.ReadKey();
        }
    }
}
