using System;

namespace _7_Conditionals
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Executando projeto 7 - Condicionais");
            Console.WriteLine();

            int joaoAge = 16;
            int peopleQuantity = 2;

            if (joaoAge >= 18)
            {
                Console.WriteLine("Possui mais que 18 anos, pode entrar");
            }
            else if (peopleQuantity >= 2)
            {
                Console.WriteLine("Não possui mais de 18 anos, mas está acompanhado, pode entrar");
            }
            else
            {
                Console.WriteLine("Não possui mais de 18 anos e nem está acompanhado, não pode entrar");
            }

            Console.ReadLine();
        }
    }
}
