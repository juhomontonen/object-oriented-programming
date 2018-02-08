using System;
using System.Collections.Generic;
using System.Text;

namespace TaskVehicle
{
    class Vehicle
    {
        //muuttujat
        protected string Type;
        protected string Brand;
        protected int Year;
        protected double Price;

        //konstruktori
        public Vehicle(string type, string brand, int year, double price)
        {
            Type = type;
            Brand = brand;
            Year = year;
            Price = price;
        }

        //metodit
        virtual public void PrintVehicleInfo()
        {
            Console.WriteLine($"Kulkuneuvon tiedot\nTyyppi: {Type}\nMerkki: {Brand}\nVuosimalli: {Year}\nHinta: {Price}\n");
        }


    }
}
