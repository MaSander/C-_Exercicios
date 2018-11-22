using System;

namespace Senai.Matrix.Exercicio2
{
    class Program
    {
        static void Main(string[] args)
        {
            bool verificar = false;
            int[,] matriz = new int[5,5];
            Random rand = new Random ();

            for (int i = 0; i < 5; i++){
                for (int j = 0; j < 5; j++){
                matriz[i,j] = rand.Next (50);
                }
                // fim matriz coluna
            }
            // fim matriz linha
            System.Console.WriteLine("Matriz randomica criada");


            System.Console.WriteLine("Insira um numero");
            int numero = int.Parse(Console.ReadLine());

            for (int i = 0; i < 5; i++){
                for (int j = 0; j < 5; j++){
                if(numero == matriz[i,j]){
                    System.Console.WriteLine($"numero encontrado na {i+1}º linha {j+1}º coluna");
                    verificar = true;
                }
                }
                // fim matriz coluna
            }
            // fim matriz linha
            if (verificar != true){
                System.Console.WriteLine("Numero não encontrado na matriz");
            }
            
            for (int i = 0; i < 5; i++){
                for (int j = 0; j < 5; j++){
                System.Console.Write($"{matriz[i,j]}\t");
                }
                System.Console.WriteLine();
            }

        }
    }
}
