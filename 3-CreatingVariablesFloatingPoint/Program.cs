using System;

namespace _3_CreatingVariablesFloatingPoint
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Executando projeto 3 - Criando variaveis ponto flutuante");

            double salary;
            salary = 1200.7;
            Console.WriteLine(salary);

            double age;
            age = 15.0 /2;
            Console.WriteLine(age);

            age = 5 / 3;
            Console.WriteLine("5 / 3 = " + age);

            age = 5.0 / 3;
            Console.WriteLine("5.0 / 3 = " + age);

            Console.WriteLine("A execução terminou. Tecle enter para finalizar...");
            Console.ReadLine();
        }
    }
}
