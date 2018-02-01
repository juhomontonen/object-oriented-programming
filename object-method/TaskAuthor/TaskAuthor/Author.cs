using System;
using System.Collections.Generic;
using System.Text;
using Literature;

namespace TaskAuthor
{
    class Author
    {
        //muuttujat
        string Name;
        string Birthdate;
        Book Book;

        //konstruktori
        public Author(string name, string birthdate, Book book)
        {
            Name = name;
            Birthdate = birthdate;
            Book = book;
        }

        //metodi
        public void PrintAuthorInfo()
        {
            Console.WriteLine($"Kirjailijan nimi: {Name}\nSyntymäaika: {Birthdate}");
            Book.SearchBook("jamie oliverin yrttikirja");
        }
    }
}
