using System;

namespace _6_VariablesAssignments
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Executando o projeto 6");
            Console.WriteLine();

            int age = 32;
            int ageGustavo = age;

            age = 20;

            Console.WriteLine(age);
            Console.WriteLine(ageGustavo);

            Console.WriteLine();
            Console.WriteLine("A execução terminou. Tecle enter para finalizar...");
        }
    }
}
