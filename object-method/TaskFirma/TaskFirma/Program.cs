using System;

namespace TaskFirma
{
    class Program
    {
        static void Main(string[] args)
        {
            Firma newFirma = new Firma("Taksi Oy", "Valtakatu 22", "+358 50 444 4444", 500, 100);
            newFirma.PrintInfo();
            newFirma.OutcomePercentage();

            Firma newFirma2 = new Firma();
            newFirma2.PrintInfo();
            newFirma2.OutcomePercentage();

            Firma newFirma3 = new Firma(newFirma2);
            newFirma3.PrintInfo();
            newFirma3.OutcomePercentage();



            Console.ReadKey();
        }
    }
}
