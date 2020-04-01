using Bank.Entities;
using Bank.Entities.Exceptions;
using System;

namespace Bank
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Enter account data: ");
                Console.Write("Number: ");
                int number = int.Parse(Console.ReadLine());
                Console.Write("Holder: ");
                string holder = Console.ReadLine();
                Console.Write("Initial Balanc: ");
                double balance = double.Parse(Console.ReadLine());
                Console.Write("Withdraw limit: ");
                double withdrawLimit = double.Parse(Console.ReadLine());
                Console.WriteLine("---Account successfully created---");
                Account ac1 = new Account(number, holder, balance, withdrawLimit);
                Console.Write("Enter amount for withdraw: ");
                ac1.Withdraw(double.Parse(Console.ReadLine()));

            }
            catch (LimitException e)
            {
                Console.WriteLine("Error in reservation: " + e.Message);
            }
            catch (LimitOfRangeException e)
            {
                Console.WriteLine("Error in reservation: " + e.Message);
            }
            catch (Exception e)
            {
                Console.WriteLine("Unexpected error: " + e.Message);
            }
        }
    }
}
