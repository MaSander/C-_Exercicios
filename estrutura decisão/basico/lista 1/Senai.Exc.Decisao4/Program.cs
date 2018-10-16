using System;

namespace Senai.Exc.Decisao4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Informe seu salaio");
            int s = int.Parse(Console.ReadLine());

            if (s > 1000)
            {
                int a = s + ((s/100) * 15);
                System.Console.WriteLine($"Salario total de {a.ToString("c")}");
            }
            else if (s > 2000)
            {
                int a = s + ((s/100) * 15);
                System.Console.WriteLine($"Salario total de {a.ToString("c")}");
            }

        }
    }
}
