using System;

namespace TaskVehicle
{
    class Program
    {
        static void Main(string[] args)
        {
            Vehicle vehicleA = new Vehicle("Pyörä", "Nopsa", 1960, 20);
            Car carA = new Car("Auto", "Toyota", 1990, 1000, 100, "Hiace", 2);


            vehicleA.PrintVehicleInfo();
            carA.PrintVehicleInfo();

            Console.ReadKey();
        }
    }
}
