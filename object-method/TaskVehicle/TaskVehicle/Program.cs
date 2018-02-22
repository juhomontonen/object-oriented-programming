using System;

namespace TaskVehicle
{
    class Program
    {
        static void Main(string[] args)
        {
            //Vehicle vehicleA = new Vehicle("Pyörä", "Nopsa", 1960, 20);
            Car carA = new Car("Auto", "Toyota", 1990, 600, 2.2, "Hiace", 2);

            //Vehicle vehicleB = new Vehicle("Auto", "Volkswagen", 1998, 750);
            Car carB = new Car("Auto", "Volkswagen", 1998, 750, 2, "Golf", 4);


            Console.WriteLine(carA.ToString());
            Console.WriteLine(carB.ToString());

            Console.WriteLine($"Onko Auton 1 moottori isompi kuin Auton 2 {carA.Equals(carB)}");

            Truck truckA = new Truck("Auto", "Ford", 1989, 200, 1.5, "Kuorma-auto", 2, 3000, 10);
            Console.WriteLine(truckA.ToString());
            Console.WriteLine(truckA.CalcCons());

            Console.ReadKey();
        }
    }
}
