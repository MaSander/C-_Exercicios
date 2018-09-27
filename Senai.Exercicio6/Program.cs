using System;

namespace Senai.Exercicio6
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Informe o preço do protudo.");
            float preco = float.Parse(Console.ReadLine());

            float desconto = (float) (preco * 0.9);

            Console.WriteLine("O preço desse produto com 10% de desconto fica:" + desconto);
        }
    }
}
