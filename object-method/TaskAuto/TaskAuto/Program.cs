using System;

namespace TaskAuto
{
    class Program
    {
        static void Main(string[] args)
        {
            Auto autoA = new Auto();
            autoA.AskData();

            Auto autoB = new Auto();
            autoB.AskData();

            autoA.ShowCarInfo();
            autoB.ShowCarInfo();
            autoA.Accelerate(20);
            autoB.Brake();

            Console.ReadKey();
        }
    }
}
