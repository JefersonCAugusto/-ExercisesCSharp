using System;
using System.Collections.Generic;
using Empresa.Entities;
namespace Empresa
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter with the number of employee: ");
            int nFunc = int.Parse(Console.ReadLine());
            List<Employee> empl = new List<Employee>();
            for (int i = 1; i <= nFunc; i++)
            {
                Console.WriteLine("Employee data Nº{0}:", i);
                Console.Write("Is Outsourced?  (y/n): ");
                string type = Console.ReadLine();
                Console.Write("name: ");
                string nameTemp = Console.ReadLine();
                Console.WriteLine("Hours: ");
                int hourTemp = int.Parse(Console.ReadLine());


            }
        }
    }
}
