using System;

namespace Senai.For.Exercicio6
{
    class Program
    {
        static void Main(string[] args)
        {
            int qnt;
            float valor, menor = 2147483647, maior = -2147483647;

            Console.WriteLine("Informe a quantidade de numeros que deseja inserir:");
            qnt = int.Parse(Console.ReadLine());

            for(int i = 1; i <= qnt; i++){
                System.Console.WriteLine($"Insira o volor do {i}º numero (sendo ele maior que 0)");
                valor = float.Parse(Console.ReadLine());

                if(valor < menor){
                    menor = valor;
                }
                if(valor > maior){
                    maior = valor;
                }
            }
            System.Console.WriteLine($@"
            Maior numero = {maior}
            Menor numero = {menor}");
        }
    }
}
