using System;

namespace Senai.Exercicio1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Informe dois valores de numeros");
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            
            if (a > b)
            {
                Console.WriteLine($"{a} é o maior numero");
            }
            else
            {
                System.Console.WriteLine($"{b} é o maior numero");
            }
        }
    }
}
