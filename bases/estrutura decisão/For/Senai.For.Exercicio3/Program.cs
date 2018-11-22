using System;

namespace Senai.For.Exercicio3
{
    class Program
    {
        static void Main(string[] args)
        {
            int numero;

            Console.WriteLine("Insira um numero Par:");
            numero = int.Parse(Console.ReadLine());

            for (int cont = 100;cont >= 0;cont--){
                numero += 2;
                System.Console.WriteLine(numero); 
            }
        }
    }
}
