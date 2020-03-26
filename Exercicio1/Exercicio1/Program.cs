using System;
using Exercicio1.Entities.Enums;
using Exercicio1.Entities;
namespace Exercicio1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the employee name: ");
            string nameTemp = Console.ReadLine();

            Console.Write("Enter the Department name: ");
            string depTemp = Console.ReadLine();

            Console.Write("Enter the level: ");
            string lvlTemp = Console.ReadLine();

            Console.Write("Hou de salary base: ");
            double salTemp = double.Parse(Console.ReadLine());


            Console.Write("How many contracts were made by employee? ");
            int nCtr = int.Parse(Console.ReadLine());

            Department dpt = new Department(depTemp);
            WorkLevel level = Enum.Parse<WorkLevel>(lvlTemp);
            Worker employee = new Worker(nameTemp, level, salTemp, dpt);

            for (int i = 0; i < nCtr; i++)
            {
                Console.Write("Enter the date (DD/MM/AAAA): ");
                DateTime dateTemp = DateTime.Parse(Console.ReadLine());

                Console.Write("Enter Value Per Hour: ");
                double valuePerHour = double.Parse(Console.ReadLine());


                Console.Write("Enter the work hours: ");
                int hours = int.Parse(Console.ReadLine());

                HourContract ctr = new HourContract(dateTemp, valuePerHour, hours);
                employee.AddContract(ctr);


            }

            Console.WriteLine("Enter month and year you want to search? MM/AAA");
            string[] search = new string[2];
            search = Console.ReadLine().Split('/');
            double totalValue = employee.Income(int.Parse(search[0]), int.Parse(search[1]));

            Console.WriteLine(employee);
            Console.WriteLine("O rendimento total foi de: "+totalValue);
            Console.ReadLine();


        }
    }
}
