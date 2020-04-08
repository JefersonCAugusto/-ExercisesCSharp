using System;
using System.Globalization;

namespace GeneratorC
{
    class Program
    {
        public static DateTimeStyles Culture { get; private set; }

        static void Main(string[] args)
        {
            Console.WriteLine("recebe numero: ");
            int number = int.Parse(Console.ReadLine());
            Console.WriteLine("recebe Data: ");
            DateTime date = DateTime.ParseExact(Console.ReadLine(), "dd/MM/yyyy HH/mm",CultureInfo.InvariantCulture);
            Console.WriteLine("recebe Valor contrato: ");
            double value = double.Parse(Console.ReadLine());
            Console.WriteLine("recebe quantidade parcelas: ");
            int installments = int.Parse(Console.ReadLine());




        }
    }
}
