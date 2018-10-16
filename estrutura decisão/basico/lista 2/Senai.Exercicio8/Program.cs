using System;

namespace Senai.Exercicio8
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Insira um numero inteiro");
            int numero = int.Parse(Console.ReadLine());

            if ( numero%2 == 0 )
            {
                System.Console.WriteLine($"O numero {numero} é par");
            }
            else
            {
                System.Console.WriteLine($"O numero {numero} é impar");
            }
        }
    }
}
