using System;

namespace Senai.Exercicio2
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime yAtual = DateTime.Now;
            int yNascido;

            Console.WriteLine("Insira seu ano de nascimento");
            yNascido = int.Parse(Console.ReadLine());

            if ( yAtual.Year - yNascido >= 16)
            {
                System.Console.WriteLine("você esta apto a votar");
            }
            else
            {
                Console.WriteLine("Você não esta apto a votar");
            }
        }
    }
}
