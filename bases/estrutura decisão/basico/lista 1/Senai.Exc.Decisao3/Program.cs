using System;

namespace Senai.Exc.Decisao3
{
    class Program
    {
        static void Main(string[] args)
        {
            // recebendo numero
            Console.WriteLine("Insira um numero inteiro");
            int a = int.Parse(Console.ReadLine());

            Console.WriteLine("Insira um numero inteiro");
            int b = int.Parse(Console.ReadLine());

            Console.WriteLine("Insira um numero inteiro");
            int c = int.Parse(Console.ReadLine());

            // declarçao
            int maior = 0, menor = 0;


            // Conectores Logicos
            if (a > b && a > c)
            {
                maior = a;
            }
            else if (b > c)
            {
                maior = b;
            }
            else
            {
                maior = c;
            }

            // menor
            if (a < b && a < c)
            {
                menor = a;
            }
            else if (b < c)
            {
                menor = b;
            }
            else
            {
                menor = c;
            }
            
            System.Console.WriteLine($@"
            {maior} é o maior numero,
            e {menor} é o menor.");
        }
    }
}
