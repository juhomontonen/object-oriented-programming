using System;

namespace TaskTicket
{
    class Program
    {
        static void Main(string[] args)
        {
            Ticket ticketA = new Ticket();
            ticketA.AskData();

            ticketA.ShowTicketPrice(ticketA);

            Console.ReadKey();
        }
    }
}
