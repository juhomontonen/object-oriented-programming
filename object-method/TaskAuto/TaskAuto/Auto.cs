using System;
using System.Collections.Generic;
using System.Text;

namespace TaskAuto
{
    class Auto
    {
        //muuttujat
        public string Brand;
        public int Speed;


        //konstruktori
        public Auto(string brand, int speed)
        {
            Brand = brand;
            Speed = speed;
        }

        public Auto()
        {
            Brand = "unknown";
            Speed = 0;
        }

        //metodit
        public void AskData()
        {
            Console.Write("Syötä auton merkki: ");
            Brand = Console.ReadLine();

            Console.Write("Syötä auton nopeus: ");
            string userInput = Console.ReadLine();
            Speed = int.Parse(userInput);



        }

        public void ShowCarInfo()
        {
            Console.WriteLine($"Auton merkki on {Brand} ja nopeus {Speed}");
        }
    }
}
