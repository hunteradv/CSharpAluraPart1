using System;

namespace _9_Scope
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Executando projeto 9 - Escopo");
            Console.WriteLine();

            int joaoAge = 18;
            int peopleQuantity = 2;
            bool accompanied = peopleQuantity >= 2;
            string additionalMessage;

            if (accompanied)
            {
                additionalMessage = "Pessoa está acompanhada!";
            }
            else            
                additionalMessage = "Pessoa não está acompanhada";
                            

            if (joaoAge >= 18 || accompanied)
            {
                Console.WriteLine("Pode entrar.");
                Console.WriteLine(additionalMessage);
            }
            else
            {
                Console.WriteLine("Não pode entrar");
                Console.WriteLine(additionalMessage);
            }

            Console.ReadLine();
        }
    }
}
