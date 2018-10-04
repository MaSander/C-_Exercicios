using System;

namespace Senai.Exercicio4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Informe a temperatura em Célsius");
            float Celsius = float.Parse(Console.ReadLine());

            float Fahrenheit;
            
            Fahrenheit = (9* Celsius + 160) / 5;

            Console.WriteLine($"A temperatura em Fahrenheit vale: {Fahrenheit}");

        }
    }
}
