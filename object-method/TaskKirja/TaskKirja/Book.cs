using System;
using System.Collections.Generic;
using System.Text;

namespace TaskKirja
{
    class Book
    {
        //muuttujat
        public string Title;
        public string Author;
        public int Id;
        public int Price;

        //konstruktori
        public Book(string title, string author, int id, int price)
        {
            Title = title;
            Author = author;
            this.Id = id;
            Price = price;
        }

        public Book()
        {
            Title = "unknown";
            Author = "Heikki";
            Id = 111;
            Price = 22;
        }


        //metodit
        public void PrintBookInfo()
        {
            Console.WriteLine($"Kirjan nimi: {Title}\nKirjoittaja: {Author}\nId: {this.Id}\nHinta: {this.Price}\n");
        }

        public string CompareBook(Book book)
        {

            if (this.Price > book.Price)

                return ($"{this.Title} on kalliimpi kuin {book.Title}");
            else
                return ($"{book.Title} on kalliimpi kuin {this.Title}");
        }
    }
}
