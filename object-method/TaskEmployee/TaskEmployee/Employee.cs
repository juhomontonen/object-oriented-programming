using System;
using System.Collections.Generic;
using System.Text;

namespace TaskEmployee
{
    class Employee
    {
        //muuttujat
        public string Name;
        public int Id;
        public string Position;
        public int Salary;

        //konstruktori
        public Employee(string name, int id, string position, int salary)
        {
            Name = name;
            Id = id;
            Position = position;
            this.Salary = salary;
        }

        //metodit
        public void PrintEmployeeInfo()
        {
            Console.WriteLine($"Työnantajan nimi: {Name}\nId: {Id}\nTehtävä: {Position}\nPalkka: {Salary}e/h\n");
        }

        public string CompareSalary(Employee employee)
        {
            if (this.Salary > employee.Salary)

                return ($"Työnantajalla {this.Name} on parempi palkka ({this.Salary}e/h) kuin {employee.Name}:lla ({employee.Salary}e/h)");
            else
                return ($"Työnantajalla {employee.Name} on parempi palkka ({employee.Salary}e/h) kuin {this.Name}:lla ({this.Salary}e/h)");
        }
    }
}
