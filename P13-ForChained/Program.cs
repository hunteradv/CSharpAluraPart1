using System;

namespace P13_ForChained
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Projeto 13");

            //*
            //**
            //***
            //****
            //*****
            //******
            //*******

            //Escrevendo com o break
            //for (int line = 0; line < 10; line++)
            //{
            //    for (int column = 0; column < 10; column++)
            //    {
            //        Console.Write("*");

            //        if (column >= line)
            //        {
            //            break;
            //        }
            //    }

            //    Console.WriteLine();
            //}


            //forma alternativa
            for (int line = 0; line < 10; line++)
            {
                for (int column = 0; column <= line; column++)
                {
                    Console.Write("*");
                }

                Console.WriteLine();
            }

            Console.ReadLine();
        }
    }
}
