using System;

namespace Senai.Exercicio9
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Insira o dia de seu aniversario");
            int dia = int.Parse(Console.ReadLine());

            Console.WriteLine("Insira o mes de seu aniversario");
            int mes = int.Parse(Console.ReadLine());

            Console.WriteLine("Insira o ano de seu aniversario");
            int ano = int.Parse(Console.ReadLine());

            if ( dia <= 31 )
            {
                if ( mes <= 12)
                {
                    if ( ano <= 2013)
                    {
                        System.Console.WriteLine($"Data {dia}/{mes}/{ano} valida");
                    }
                    else
                    {
                        System.Console.WriteLine("Ano invalido");
                    }
                }
                else
                {
                    System.Console.WriteLine("Mes invalido");
                }
            }
            else
            {
                System.Console.WriteLine("Dia invalido");
            }
        }
    }
}
