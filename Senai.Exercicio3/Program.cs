using System;

namespace Senai.Exrc.Media
{
    class Program
    {
        static void Main(string[] args)
        {

            float Produto1, Produto2, Produto3, Produto4, Produto5, mediaProduto;

            Console.WriteLine("Informe o preço do primeiro produto");
            Produto1 = float.Parse(Console.ReadLine());

            Console.WriteLine("Informe o preço do primeiro produto");
            Produto2 = float.Parse(Console.ReadLine());

            Console.WriteLine("Informe o preço do primeiro produto");
            Produto3 = float.Parse(Console.ReadLine());

            Console.WriteLine("Informe o preço do primeiro produto");
            Produto4 = float.Parse(Console.ReadLine());

            Console.WriteLine("Informe o preço do primeiro produto");
            Produto5 = float.Parse(Console.ReadLine());

            mediaProduto = (Produto1 + Produto2 + Produto3 + Produto4 + Produto5) / 5;

            Console.WriteLine($"A media do produto vale {mediaProduto}");

        }
    }
}
