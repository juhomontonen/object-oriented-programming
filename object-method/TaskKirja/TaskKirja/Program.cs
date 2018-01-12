using System;

namespace TaskKirja
{
    class Program
    {
        static void Main(string[] args)
        {

            Book tietoKirja = new Book();
            tietoKirja.Title = "Tietokirja 1780";
            tietoKirja.Author = "Matti";
            tietoKirja.Id = 100;
            tietoKirja.Price = 22;
            tietoKirja.PrintBookInfo();

            Book ennatysKirja = new Book();
            ennatysKirja.Title = "Ennätyskirja";
            ennatysKirja.Author = "Esa";
            ennatysKirja.Id = 129;
            ennatysKirja.Price = 2;
            ennatysKirja.PrintBookInfo();

            Book autoKirja = new Book("Autokirja 2018","Mauri Kunnas", 1, 20);
            autoKirja.PrintBookInfo();

            Book keittoKirja = new Book("Keittokirja 2017", "Kaj Kunnas", 2, 36);
            keittoKirja.PrintBookInfo();

            Console.WriteLine($"{tietoKirja.CompareBook(ennatysKirja)}");
            Console.WriteLine($"{autoKirja.CompareBook(ennatysKirja)}");

            Console.ReadKey();
        }
    }
}
