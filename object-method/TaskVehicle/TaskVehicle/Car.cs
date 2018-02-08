using System;
using System.Collections.Generic;
using System.Text;

namespace TaskVehicle
{
    class Car : Vehicle
    {
        //muuttujat
        protected double MotorSize;
        protected string Model;
        protected int Doors;

        //konstruktori
        public Car(string type, string brand, int year, double price, double motorsize, string model, int doors) : base(type, brand, year, price)
        {
            MotorSize = motorsize;
            Model = model;
            Doors = doors;
        }

        //metodit
        public override void PrintVehicleInfo()
        {
            base.PrintVehicleInfo();
            Console.WriteLine($"Moottorin koko: {MotorSize}\nMalli: {Model}\nVuosimalli: {Year}\n");
        }



    }
}
