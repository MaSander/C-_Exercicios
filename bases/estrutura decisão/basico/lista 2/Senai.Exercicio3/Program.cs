using System;

namespace Senai.Exercicio3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Insira a senha");
            int senha = int.Parse(Console.ReadLine());

            if ((int) (senha) == 1234)
            {
                System.Console.WriteLine("ACESSO PERMITIDO");
            }
            else
            {
                System.Console.WriteLine("ACESSO NEGADO");
            }
        }
    }
}
