using System;

namespace _8_Conditionals2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Executando projeto 8 - Condicionais 2");
            Console.WriteLine();

            int joaoAge = 18;
            int peopleQuantity = 2;

            bool accompanied = peopleQuantity >= 2;

            if (joaoAge >= 18 && accompanied)
            {
                Console.WriteLine("Pode entrar");
            }
            else
            {
                Console.WriteLine("Não pode entrar");
            }

            Console.ReadLine();
        }
    }
}
