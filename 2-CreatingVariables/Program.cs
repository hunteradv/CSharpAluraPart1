using System;

namespace _2_CreatingVariables
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Executando projeto 2 - Criando Variáveis");

            int age;
            age = 32;
            Console.WriteLine(age);

            age = 10;
            Console.WriteLine(age);

            age = 10 + 5;
            Console.WriteLine(age);

            age = 10 + 5 * 2;
            Console.WriteLine(age);

            age = (10 + 5) * 2;
            Console.WriteLine("Sua idade é: " + age + "!");

            Console.WriteLine("A execução terminou. Tecle enter para finalizar...");
            Console.ReadLine();
        }
    }
}
