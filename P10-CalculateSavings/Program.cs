using System;

namespace P10_CalculateSavings
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Executando projeto 10 - Calcula Poupança");

            double investedValue = 1000;
            int countMonth = 1;

            while (countMonth <= 12)
            {
                //0.36% = 0.0036
                investedValue = investedValue + investedValue * 0.0036;
                Console.WriteLine("Após " + countMonth + " meses você terá $" + investedValue);

                countMonth++;
            }          

            Console.ReadLine();
        }
    }
}
