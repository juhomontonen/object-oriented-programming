using System;

namespace TaskAuthor
{
    class Program
    {
        static void Main(string[] args)
        {
            Book newBook1 = new Book("Jamie Oliverin yrttikirja", "Matti", "Mauri Kunnas Oy", 30, "Keittokirja");
            Book newBook2 = new Book("Hauskoja juttuja", "Kimmo", "Kustannus Ay", 22, "Vitsikirja");

            newBook1.GetBook(newBook1);

            

            Console.ReadKey();
        }
    }
}
