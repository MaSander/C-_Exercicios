using System;

namespace Senai.Exc.Decisao1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Insira um numero:");
            int numero = int.Parse(Console.ReadLine());

            // estrutura de decisao: if (se), else (senão).
            if (numero >= 0)
            {
                System.Console.WriteLine("Positivo");
            }
            else
            {
                System.Console.WriteLine("Negativo");
            }

        }
    }
}
