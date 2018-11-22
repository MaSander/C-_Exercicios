using System;

namespace Senai.Exc.Rept2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Informe o numero incial");
            int ninicio = int.Parse(Console.ReadLine());

            System.Console.WriteLine("informe um numero final maior que o inicial");
            int nfinal = int.Parse(Console.ReadLine());

            System.Console.WriteLine("____________________");

            while (ninicio < nfinal)
            {
                ninicio++;

                Console.WriteLine($"{ninicio}");

            }

        }
    }
}
