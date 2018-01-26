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
        public static string GenreChange;

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

        public Book(Book book)
        {
            Title = book.Title;
            Author = book.Author;
            Publisher = book.Publisher;
            Price = book.Price;
            Genre = book.Genre;
        }

        //metodit
        public void PrintBookInfo()
        {
            Console.WriteLine($"Kirjan nimi: {Title}\nKirjoittaja: {Author}\nKustantaja: {Publisher}\nHinta: {Price}\nGenre: {Genre}\n");
        }

        //public void GetBook(Book book)
        //{
        //    Console.Write("Syötä kirjan nimi: ");
        //    string AskTitle = Console.ReadLine().ToUpper();
        //
        //    if (AskTitle.Equals(Title.ToUpper()))
        //        PrintBookInfo();
        //    else
        //        Console.WriteLine($"Kirjaa {AskTitle} ei löytynyt.");
        //}

        public bool SearchBook(string askedTitle)
        {
            if (askedTitle.Equals(Title.ToUpper()))
                return true;
            else
                return false;
        }

        //public void GetBook()
        //{
        //    Console.Write("Syötä kirjan nimi: ");
        //    string AskTitle = Console.ReadLine().ToUpper();
        //    
        //    if (AskTitle.Equals(Title.ToUpper()))
        //            PrintBookInfo();
        //    else
        //        Console.WriteLine($"Kirjaa {AskTitle} ei löytynyt.");
        //}

        public void ChangeGenre(string newgenre)
        {
            Genre = newgenre;
        }

    }
}
