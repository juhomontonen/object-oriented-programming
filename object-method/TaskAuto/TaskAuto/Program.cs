using System;

namespace TaskAuto
{
    class Program
    {
        static void Main(string[] args)
        {
            Auto autoA = new Auto();
            autoA.AskData();

            autoA.ShowCarInfo();
            Console.ReadKey();
        }
    }
}
