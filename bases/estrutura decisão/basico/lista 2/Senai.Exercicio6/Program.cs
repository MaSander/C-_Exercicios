using System;

namespace Senai.Exercicio6
{
    class Program
    {
        static void Main(string[] args)
        {
            int a, b, c;

            Console.WriteLine("Informe 3 numeros");
            a = int.Parse(Console.ReadLine());
            b = int.Parse(Console.ReadLine());
            c = int.Parse(Console.ReadLine());

            Console.Clear();
            System.Console.WriteLine(@"
            ______________________________________________________________
            entre os numeros informados abaixo há os divisiveis por 2 ou 3
            ______________________________________________________________");

            if ( a%2==0 || a%3==0)
            {
                System.Console.WriteLine($"{a}");
            }

            if ( b%2==0 || b%3==0)
            {
                System.Console.WriteLine($"{b}");
            }

            if ( c%2==0 || c%3==0)
            {
                System.Console.WriteLine($"{c}");
            }

        }
    }
}
