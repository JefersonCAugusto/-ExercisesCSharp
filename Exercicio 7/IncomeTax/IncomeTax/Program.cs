using System;
using IncomeTax.Entities;
using System.Collections.Generic;

namespace IncomeTax
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the number of tax payers:");
            int n1 = int.Parse(Console.ReadLine());
            List<TaxPayer> taxPayer = new List<TaxPayer>();
            for (int i = 0; i < n1; i++)
            {
                Console.WriteLine("-------------------------");
                Console.WriteLine("Tax payer #{0} data:", i + 1);
                Console.Write("Individual or company(i/c):");
                char type = char.Parse(Console.ReadLine().ToUpper());
                if (type == 'I')
                {
                    Console.Write("Enter the Name: ");
                    string name = Console.ReadLine();
                    Console.Write("Enter de anual incame: ");
                    double anualIncame = double.Parse(Console.ReadLine());
                    Console.Write("Enter the health spent (0 if not): ");
                    double healthSpent = double.Parse(Console.ReadLine());
                    TaxPayer i1 = new Individual(healthSpent, name, anualIncame);
                    taxPayer.Add(i1);

                }
                else if (type == 'C')
                {
                    Console.Write("Enter the Company: ");
                    string name = Console.ReadLine();
                    Console.Write("Enter de anual incame: ");
                    double anualIncame = double.Parse(Console.ReadLine());
                    Console.Write("Number of employees: ");
                    int numberOfEmployees = int.Parse(Console.ReadLine());
                    TaxPayer c1 = new Company(numberOfEmployees, name, anualIncame);
                    taxPayer.Add(c1);

                }
                else
                    Console.WriteLine("Invalid value. Aborted operation.");

            }
            Console.WriteLine("\n");
            Console.WriteLine("TAXES PAID:");

            foreach (TaxPayer x1 in taxPayer)
            {
                Console.WriteLine("Name: "+x1.Name+ " $"+x1.TotalTax());
            }
            Console.ReadLine();//so para manter o programa parado.

        }
    }
}
