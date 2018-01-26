using System;

namespace TaskAuthor
{
    class Program
    {
        static void Main(string[] args)
        {
            Book bookA = new Book("Jamie Oliverin yrttikirja", "Matti", "Mauri Kunnas Oy", 30, "Keittokirja");
            Book bookB = new Book("Hauskoja juttuja", "Kimmo", "Kustannus Ay", 22, "Vitsikirja");
            Book bookC = new Book("Guinness World Records", "Jari", "Kustannus Ay", 50, "Ennätyskirja");

            Book[] books = new Book[3];
            books[0] = bookA;
            books[1] = bookB;
            books[2] = bookC;

            Console.Write("Syötä kirjan nimi: ");
            string askTitle = Console.ReadLine().ToUpper();

            bool isBookFound = false;

            for (int i = 0; i < books.Length; i++)
            {
                if (books[i].SearchBook(askTitle.ToUpper()))
                {
                    Console.WriteLine("Kirja löytyi.");
                    books[i].PrintBookInfo();
                    isBookFound = true;
                    break;
                }
            }
            if (!isBookFound)
                Console.WriteLine("Kirjaa ei löytynyt!");
            //changegenre testi
            bookB.ChangeGenre("Elämänkerta");
            bookC.NewPrice = 50;
            bookC.PrintBookInfo();



            Console.ReadKey();
        }
    }
}
