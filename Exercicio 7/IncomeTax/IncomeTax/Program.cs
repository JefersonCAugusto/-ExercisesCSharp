using System;

namespace IncomeTax
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the number of tax payers:");
            int n1 = int.Parse(Console.ReadLine());
            for (int i = 0; i < n1; i++)
            {
                Console.WriteLine("-------------------------");
                Console.WriteLine("Tax payer #{0} data:",i+1);
                Console.Write("Individual or company(i/c):");
                char type = char.Parse(Console.ReadLine().ToUpper());
                if (type=='I')
                {
                    Console.Write("Enter the Name: ");
                    Console.Write("Enter de anual incame: ");
                    Console.Write("Enter the health spent (0 if not): ");
                    
                }
                


            }
        }
    }
}
