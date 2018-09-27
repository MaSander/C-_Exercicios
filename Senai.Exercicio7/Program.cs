using System;

namespace Senai.Exercicio7
{
    class Program
    {
        static void Main(string[] args)
        {

            float precoDol, precoReal, cnvDol, cnvReal;

            Console.WriteLine("Informe o preço em dolar:");
            precoDol = float.Parse(Console.ReadLine());

            Console.WriteLine("Informe o preço em reais:");
            precoReal = float.Parse(Console.ReadLine());

            cnvDol = (float) (precoDol * 3.99);

            cnvReal = (float) (precoReal / 3.99);

            Console.Clear();

            Console.WriteLine($"US${precoDol} fica: R${cnvDol}");
            Console.WriteLine("-------------------------------------");
            Console.WriteLine($"US${precoReal} fica: R${cnvReal}");

        }
    }
}
