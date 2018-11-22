using System;

namespace Senai.Matrix.Exemplo1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Informe a quantidade de pessoas que deseja cadastra");
            int quantidadeCadastro = int.Parse(Console.ReadLine());

            string[,] usuario = new string[quantidadeCadastro,3];

            for (int i = 0; i < quantidadeCadastro; i++){
                System.Console.WriteLine("Informe o seu nome");
                usuario[i,0] = Console.ReadLine();
                
                System.Console.WriteLine("Informe o Cpf");
                usuario[i,1] = Console.ReadLine();
                
                System.Console.WriteLine("Informe o telefone");
                usuario[i,2] = Console.ReadLine();
            }

            for (int i = 0; i < quantidadeCadastro; i++){
                System.Console.WriteLine($"{usuario[i,0]} - {usuario[i,1]} - {usuario[i,2]}");
            }
        }
    }
}
