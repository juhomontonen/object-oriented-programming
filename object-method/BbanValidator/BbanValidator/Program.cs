using System;

namespace BbanValidator
{
    class Program
    {
        static void Main(string[] args)
        {
            string machineFormat = "123456-78912";
            bool isMachineFormat = BankUtil.CorrectNumber(ref machineFormat);
            if (isMachineFormat)
            {
                Console.WriteLine($"{machineFormat} - {BankUtil.IsValidAccount(machineFormat)}");
            }
            else
            {
                Console.WriteLine("Account number incorrect!");
            }

            Console.ReadKey();
            ;
        }
    }
}
