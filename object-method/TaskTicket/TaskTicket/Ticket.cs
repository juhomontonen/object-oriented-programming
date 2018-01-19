using System;
using System.Collections.Generic;
using System.Text;

namespace TaskTicket
{
    class Ticket
    {
        //muuttujat
        public double Age;
        public double Mtk;
        public double Varusmies;
        public double Opiskelija;
        public double Price;

        //konstruktori
        public Ticket(double age, double mtk, double varusmies, double opiskelija, double price)
        {
            Age = age;
            Mtk = mtk;
            Varusmies = varusmies;
            Opiskelija = opiskelija;
            Price = price;
        }

        public Ticket()
        {
            Age = 0;
            Mtk = 0;
            Varusmies = 0;
            Opiskelija = 0;
            Price = 16;
        }

        //metodit
        public void AskData()
        {
            Console.WriteLine("Ohjelma laskee lippusi hinnan\n\n");

            Console.Write("Syötä ikäsi: ");
            string userInputAge = Console.ReadLine();
            Age = double.Parse(userInputAge);

            Console.Write("Oletko Mtk:n jäsen? Jos olet syötä 1, jos et syötä 0: ");
            string userInputMtk = Console.ReadLine();
            Mtk = double.Parse(userInputMtk);

            Console.Write("Oletko varusmies? Jos olet syötä 1, jos et syötä 0: ");
            string userInputVarusmies = Console.ReadLine();
            Varusmies = double.Parse(userInputVarusmies);

            Console.Write("Oletko opiskelija? Jos olet syötä 1, jos et syötä 0: ");
            string userInputOpiskelija = Console.ReadLine();
            Opiskelija = double.Parse(userInputOpiskelija);
        }

        public void ShowTicketPrice(Ticket ticket)
        {
            Console.WriteLine($"\nLipun normaali hinta on {Price} euroa\n");

            if (Age < 7)
            {
                Console.WriteLine($"Alennettu hintasi on {Price * 0} euroa");
            }
            else if (Age >= 7 && Age <= 15)
            {
                Console.WriteLine($"Alennettu hintasi on {Price * 0.5} euroa");
            }
            else if (Age >= 65)
            {
                Console.WriteLine($"Alennettu hintasi on {Price * 0.5} euroa");
            }
            if (Age > 15 && Age < 65)
            {
                if (Varusmies == 1)
                    Console.WriteLine($"Alennettu hintasi on {Price * 0.5} euroa");

                else
                {
                    if (Mtk == 1)
                    {
                        Price = Price * 0.85;
                    }
                    if (Opiskelija == 1)
                    {
                        Price = Price * 0.55;
                    }
                    Console.WriteLine($"Alennettu hintasi on {Price} euroa");
                }
            }
        }

    }
}
