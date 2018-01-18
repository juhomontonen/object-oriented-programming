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

        public void Accelerate(int number)
        {
            Console.Write($"Syötä kiihtyvyys autolle {this.Brand}: ");
            string userInput = Console.ReadLine();
            number = int.Parse(userInput);

            if (number < 1)
                Console.WriteLine("Kiihtyvyys ei voi olla negatiivinen.");
            else
                Console.WriteLine($"Syötit kiihtyvyydeksi {number}, auton {Brand} uusi nopeus on {this.Speed + number}");
        }

        public void Brake()
        {
            double speed = Speed * 0.9;
            Console.WriteLine($"Auto {Brand} jarrutti ja nopeus laski 10%, uusi nopeus on {speed}");
        }
    }
}
