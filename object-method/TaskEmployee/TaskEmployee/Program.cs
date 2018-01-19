using System;

namespace TaskEmployee
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee employeeA = new Employee("Matti Oy", 1, "Roskakuski", 20);
            Employee employeeB = new Employee("Esa Ab", 11, "Pitsalähetti", 1);
            Employee employeeC = new Employee("Heikki Ky", 107, "Opettaja", 34);
            Employee employeeD = new Employee("Kimmo Ay", 44, "Myyjä", 8);

            Employee[] employees = new Employee[4];
            employees[0] = employeeA;
            employees[1] = employeeB;
            employees[2] = employeeC;
            employees[3] = employeeD;

            for (int i = 0; i < employees.Length; i++)
            {
                employees[i].PrintEmployeeInfo();
            }

            Console.WriteLine($"{employees[0].CompareSalary(employees[2])}");
            Console.WriteLine($"{employees[3].CompareSalary(employees[1])}");

            Console.ReadKey();
        }
    }
}
