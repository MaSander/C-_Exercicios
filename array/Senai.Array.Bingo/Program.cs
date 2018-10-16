using System;

namespace Senai.Array.Bingo
{
    class Program
    {
        static void Main(string[] args)
        {
            // declaração do Array
            int[] cartela = new int[5];
            int contador = 0, acertos = 0, indice, numero;

            #region recebe numeros da cartela
            do{
                System.Console.WriteLine("Informe o numero:");
                cartela[contador] = int.Parse(Console.ReadLine());
                contador++;
            } while (contador < cartela.Length);
            #endregion 

            #region Exibe nú meros da cartela
            contador = 0;
            do{
                System.Console.WriteLine("################################");
                System.Console.WriteLine(cartela[contador]);
                contador++;
            }while (contador < cartela.Length);
            #endregion

            #region Sorteia número
                do{
                    System.Console.WriteLine("Informe o número sorteado");
                    numero = int.Parse(Console.ReadLine());

                    indice = System.Array.IndexOf(cartela,numero);
                    if (indice >= 0){
                        acertos++;
                        System.Console.WriteLine($"Você acertou {acertos}, faltam {5 - acertos}");
                    }

                }while(acertos != 5);

                System.Console.WriteLine("Bingoo, você ganhou!!!");
            #endregion

        }
    }
}