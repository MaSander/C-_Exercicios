using System;
using Senai.OO.Exc4.classe;

namespace Senai.OO.Exc4
{
    class Program
    {
        
        static void Main(string[] args)
        {
            Cartao c = new Cartao();

            // receba o nome
            Console.WriteLine("Informe seu nome:");
            c.nome = Console.ReadLine();

            // receba o numero do cartão
            Console.WriteLine("Informe o numero da conta:");
            c.numero = Console.ReadLine();

            // receba a data de validade
            Console.WriteLine("Informe a data de validade do cartão:");
            c.data = Convert.ToDateTime(Console.ReadLine());

            Console.Clear();
            // informa
            Console.WriteLine($"Nome do cliente:{c.nome}");
            Console.WriteLine($"Numero do cartão:{c.numero}");
            Console.WriteLine($"Data de validade:{c.data.ToShortDateString()}");

        }
    }
}
