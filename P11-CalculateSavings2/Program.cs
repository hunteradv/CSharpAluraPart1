using System;

namespace P11_CalculateSavings2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Executando o projeto 11");

            double investedValue = 1000;
            Console.WriteLine("Valor investido: $" + investedValue);
            Console.WriteLine();

            for (int countMonth = 1; countMonth <= 12; countMonth++)
            {
                investedValue *= 1.0036;
                Console.WriteLine("Após " + countMonth + " meses você terá $" + investedValue);
            }

            Console.ReadLine();
        }
    }
}
