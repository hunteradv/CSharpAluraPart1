using System;

namespace P12_CalculateSavingsLongTerm
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Executando o projeto 12");

            double investedValue = 1000;
            double incomeFactor = 1.0036;

            for (int countYear = 1; countYear <= 5; countYear++)
            {
                for (int countMonth = 1; countMonth <= 12; countMonth++)
                {
                    investedValue *= incomeFactor;
                }

                incomeFactor += 0.0010;
            }

            Console.WriteLine("Ao término do investimento de 5 anos, você terá $" + investedValue);

            Console.ReadLine();
        }
    }
}
