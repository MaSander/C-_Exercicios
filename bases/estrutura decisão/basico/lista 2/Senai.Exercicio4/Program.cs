using System;

namespace Senai.Exercicio4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Quantas maças deseja comprar?");
            float qnt = int.Parse(Console.ReadLine());

            if ((int) qnt <= 12)
            {
                float preco = (float) (qnt * 0.30);
                System.Console.WriteLine($@"
                Maças compradas: {qnt}
                Preço total: {preco}");
            }
            else
            {
                float preco = (int) (qnt * 0.25);
                System.Console.WriteLine($@"
                Maças compradas: {qnt}
                Preço total: {preco}");
            }
        }
    }
}
