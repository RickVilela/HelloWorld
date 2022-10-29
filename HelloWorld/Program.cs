using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
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
            Console.WriteLine($"Esse é o meu primeiro Programa em {linguagem} {hello} ");

            dynamic semTipo = "Essa e uma variavel dinamica, pode ser alterado o tipo!";
            Console.WriteLine(semTipo);

            semTipo = 29.99f;

            Console.WriteLine(semTipo);

            //Como boa pratica, nao utilizar dynamic

            const float PI = 3.14159f;
            int raio = 3;

            double area = PI * raio * raio;

            Console.WriteLine(area);

            // Divisao de inteiros:

            int divisao = 5 / 2;

            Console.WriteLine(divisao);

            float divisao2 = 5.0f / 2;
            
            Console.WriteLine(divisao2);


            VerificaHabilitacao();

            Console.ReadLine();
        }

        // Funcoes

        static void VerificaHabilitacao()
        {
            Console.Write("Digite sua idade: ");

            int idade = int.Parse(Console.ReadLine());

            Console.Write("Voce tem dinheiro? True or false? : ");
            bool dinheiro = bool.Parse(Console.ReadLine());


            //int valorDigitado = Int32.Parse(idade);  
            //Converte a String Digitada pelo Usuario e converte em um valor Inteiro

            if (idade >= 18 && dinheiro == true)
            {
                Console.WriteLine("Parabéns você pode ter Habilitação!");
            }
            else
            {
                Console.WriteLine("Infelizmente você ainda não pode ter Habilitação");
            }
        }
    }
}
