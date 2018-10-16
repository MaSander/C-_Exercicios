using System;

namespace Senai.For.Exercicio4
{
    class Program
    {
        static void Main(string[] args)
        {
            int qnt = 0, numero = 0, soma = 0;

            Console.WriteLine("Insira a quantidade dos numeros");
            qnt = int.Parse(Console.ReadLine());

            for(int cont = 0; cont < qnt; cont++){
                System.Console.WriteLine($"Insira o {cont + 1}º numero");
                numero = int.Parse(Console.ReadLine());

                soma += numero;
            }
            System.Console.WriteLine($@"
            Somatoria = {soma}
            Media = {soma / qnt}");
        }
    }
}
