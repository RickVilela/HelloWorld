using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorld
{
    internal class Program
    {
        static void Main(string[] args)
        {
            String hello = "Hello World!";
            string linguagem = "C#!";
            Console.Write($"Esse é o meu primeiro Programa em {linguagem} {hello} ");

            if (5 >= 7)
            {
                Console.WriteLine("");
            }

            Console.ReadLine();
        }
    }
}
