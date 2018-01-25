using System;
using System.Collections.Generic;
using System.Text;

namespace TaskAuthor
{
    class Book
    {
        //muuttujat
        public string Title;
        public string Author;
        public string Publisher;
        public double Price;
        public string Genre;
        static string ChangeGenre;

        //konstruktori
        public Book(string title, string author, string publisher, double price, string genre)
        {
            Title = title;
            Author = author;
            Publisher = publisher;
            Price = price;
            Genre = genre;
        }

        public Book()
        {
            Title = " ";
            Author = " ";
            Publisher = " ";
            Price = 0;
            Genre = " ";
        }

        //public Book(Book book)
        //{
        //    Title = book.Title;
        //    Author = book.Author;
        //    Publisher = book.Publisher;
        //    Price = book.Price;
        //    Genre = book.Genre;
        //}

        //metodit
        public void PrintBookInfo()
        {
            Console.WriteLine($"Kirjan nimi: {Title}\nKirjoittaja: {Author}\nKustantaja: {Publisher}\nHinta: {Price}\nGenre: {Genre}\n");
        }

        public void GetBook(Book book)
        {
            Console.Write("Syötä kirjan nimi: ");
            this.Title = Console.ReadLine();

            if (this.Title.Equals(Title))
                PrintBookInfo();
            else
                Console.WriteLine($"Kirjaa {this.Title} ei löytynyt.");
        }

        public static void GenreChange()
        {
            Console.WriteLine(ChangeGenre);
        }

    }
}
