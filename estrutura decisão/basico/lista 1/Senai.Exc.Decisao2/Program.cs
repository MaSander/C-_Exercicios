using System;

namespace Senai.Exc.Decisao2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Insira o genero [M ou F]");
            char genero = char.Parse(Console.ReadLine());


            if (genero == 'M')
            {
                
                Console.WriteLine("Insira sua idade");
                int idade = int.Parse(Console.ReadLine());
                
                if (idade >= 18)
                {
                    System.Console.WriteLine("Apto a retiar a reservista");
                }
                else
                {
                    System.Console.WriteLine("Ainda é muleque!!!");
                }
            }
            else
            {
                System.Console.WriteLine("genero não compativel");
            }
        }
    }
}
