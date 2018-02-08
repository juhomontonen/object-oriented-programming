using System;

namespace TaskVehicle
{
    class Program
    {
        static void Main(string[] args)
        {
            Vehicle vehicleA = new Vehicle("Pyörä", "Nopsa", 1960, 20);
            Car carA = new Car("Auto", "Toyota", 1990, 1000, 2.2, "Hiace", 2);

            Vehicle vehicleB = new Vehicle("Auto", "Volkswagen", 1998, 750);
            Car carB = new Car("Auto", "Volkswagen", 1998, 750, 2, "Golf", 4);


            vehicleA.PrintVehicleInfo();
            carA.PrintVehicleInfo();
            carB.PrintVehicleInfo();

            Console.WriteLine(vehicleA.ToString());
            Console.WriteLine(carA.ToString());

            Console.WriteLine($"Onko Auton 1 moottori isompi kuin Auton 2 {carA.Equals(carB)}");

            Console.ReadKey();
        }
    }
}
