using System;
using System.Collections.Generic;
using System.Text;

namespace TaskFirma
{
    class Firma
    {
        //muuttujat
        public string Title;
        public string Address;
        public string Phone;
        public int Outcome;
        public int Expense;

        //konstruktori
        public Firma(string title, string address, string phone, int outcome, int expense)
        {
            Title = title;
            Address = address;
            Phone = phone;
            Outcome = outcome;
            Expense = expense;
        }

        public Firma()
        {
            Title = "Autokorjaamo Oy";
            Address = "Koulukatu 1, 53100 Lappeenranta";
            Phone = "+358 50 538 2889";
            Outcome = 150;
            Expense = 100;
        }

        public Firma(Firma firma)
        {
            Title = firma.Title;
            Address = firma.Address;
            Phone = firma.Phone;
            Outcome = firma.Outcome;
            Expense = firma.Expense;
        }

        //metodit
        public void PrintInfo()
        {
            Console.WriteLine($"Yrityksen nimi: {Title}\nOsoite: {Address}\nPuhelin: {Phone}\nTulot: {Outcome}\nMenot: {Expense}");
        }

        public void OutcomePercentage()
        {
            double profit = ((double)(Outcome - Expense) / (double)Expense);
            Console.WriteLine($"Yrityksen {Title} voittoprosentti on: {profit*100}%");

            if (profit <= 1)
            {
                Console.WriteLine($"Yrityksellä {Title} menee kehnosti.\n");
            }
            else if (profit > 1 && profit < 3)
            {
                Console.WriteLine($"Yrityksellä {Title} menee tyydyttävästi.\n");
            }
            else if (profit >= 3)
            {
                Console.WriteLine($"Yrityksellä {Title} menee hyvin.\n");
            }
        }

    }
}
