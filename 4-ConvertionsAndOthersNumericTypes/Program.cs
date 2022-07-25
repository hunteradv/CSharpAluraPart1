using System;

namespace _4_ConvertionsAndOthersNumericTypes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Executando projeto 3 - Converções e outros tipos numéricos");

            double salary = 1200.5;
            Console.WriteLine(salary);

            //tipo de variavel até 32 bits
            int salaryInInt = (int)salary;
            Console.WriteLine(salaryInInt);

            //tipo de variavel até 64 bits
            long age = 130000000000000000;
            Console.WriteLine(age);

            //tipo de variavel até 16 bits
            short productQuantity = 15000;
            Console.WriteLine(productQuantity);

            float height = 1.80f;
            Console.WriteLine(height);

            Console.WriteLine("A execução terminou. Tecle enter para finalizar...");
            Console.ReadLine();
        }
    }
}
