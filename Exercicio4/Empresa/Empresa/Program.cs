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
                Console.Write("Hours: ");
                int hourTemp = int.Parse(Console.ReadLine());
                Console.Write("ValuePerHour: ");
                int valuePHTemp = int.Parse(Console.ReadLine());
                
                if (type =="y")
                { 
                    Console.Write("Additional expenses: ");
                    double additTemp = double.Parse(Console.ReadLine());
                    Employee e1 = new OutsourcedEmployee(nameTemp, hourTemp, valuePHTemp, additTemp);
                    empl.Add(e1);     //UpCast  lista de employee recebendo outsourcedemployee
                }
                else
                {
                    Employee e1 = new Employee(nameTemp, hourTemp, valuePHTemp);
                    empl.Add(e1);

                }
            }
            Console.WriteLine("--------Pagamentos---------");
            foreach(Employee emp in empl)
            {
                Console.Write(emp.Name);
                Console.Write(" - $");
                Console.Write(emp.Payment());
                Console.WriteLine("---------------");


            }
        }
    }
}
