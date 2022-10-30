using _04_ContaBancariaExercicioFixacao.Entities;
using Microsoft.VisualBasic;
using System;
using System.Globalization;

namespace _04_ContaBancariaExercicioFixacao
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Enter account data ");
                Console.Write("Number: ");
                int number = int.Parse(Console.ReadLine());
                Console.Write("Holder: ");
                string holder = Console.ReadLine();
                Console.Write("Inicial Balance: ");
                double inicialbalance = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                Console.Write("Withdraw Limit: ");
                double withdrawlimit = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                Account ac = new Account(number, holder, inicialbalance, withdrawlimit);
                Console.WriteLine();

                Console.Write("Enter amount for withdraw: ");
                double amount = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                ac.WithDraw(amount);
            }
            catch (DomainExeptions d)
            {
                Console.WriteLine("Errr: " + d.Message);
            }
        }
    }
}
