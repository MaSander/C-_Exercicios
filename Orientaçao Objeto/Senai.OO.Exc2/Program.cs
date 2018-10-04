using System;
using Senai.OO.Exc2.classe;

namespace Senai.OO.Exc2
{
    class Program
    {
        static void Main(string[] args)
        {
            Produto p = new Produto();
            Produto p2 = new Produto();
            Produto p3 = new Produto();

            Console.WriteLine("Qual o nome do produto?");
            p.nome = Console.ReadLine();

            Console.WriteLine("Qual o preço do produto?");
            p.preco = float.Parse(Console.ReadLine());

            Console.WriteLine("Qual a quantidade desse produto?");
            p.quantidade = float.Parse(Console.ReadLine());

            
            // segundo protudo
            
            Console.WriteLine("Qual o nome do segundo produto?");
            p2.nome = Console.ReadLine();

            Console.WriteLine("Qual o preço do segundo produto?");
            p2.preco = float.Parse(Console.ReadLine());

            Console.WriteLine("Qual a quantidade desse segundo produto?");
            p2.quantidade = float.Parse(Console.ReadLine());

          
            // terceiro protudo
            
            Console.WriteLine("Qual o nome do terceiro produto?");
            p3.nome = Console.ReadLine();

            Console.WriteLine("Qual o preço do terceiro produto?");
            p3.preco = float.Parse(Console.ReadLine());

            Console.WriteLine("Qual a quantidade desse terceir produto?");
            p3.quantidade = float.Parse(Console.ReadLine());
            
            // contas

            p.total = (float) (p.preco * p.quantidade);
            p2.total = (float) (p2.preco * p2.quantidade);
            p3.total = (float) (p3.preco * p3.quantidade);

            

            Console.WriteLine($"a media dos produtos vale {String.Format("{0:F2}", (p.total + p2.total + p3.total) / (p.quantidade + p2.quantidade + p3.quantidade))}");
            
            
        }
    }
}
