using System;

namespace _5_CharactersAndTexts
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Executando projeto 4 - Caracteres e texto");
            Console.WriteLine();

            char firstLetter = 'a';
            Console.WriteLine(firstLetter);

            firstLetter = (char)61;
            Console.WriteLine(firstLetter);

            firstLetter = (char)(firstLetter + 1);
            Console.WriteLine(firstLetter);

            Console.WriteLine();
            string title = "Alura cursos de tecnologia " + 2022;
            string programmingCourses = 
@"- .NET
- Java
- Javascript";

            Console.WriteLine(title);
            Console.WriteLine(programmingCourses);
            

            Console.WriteLine();
            Console.WriteLine("A execução terminou. Tecle enter para finalizar...");
        }
    }
}
