using System;

namespace Senai.Aula.For
{
    class Program
    {
        static void Main(string[] args)
        {
            // Recebendo o numero x
            Console.WriteLine("Insira o numero:");
            int x = int.Parse(Console.ReadLine());
            
            // Recebendo limite
            System.Console.WriteLine("Insira o limite:");
            int limite = int.Parse(Console.ReadLine());

            // int cont = 0;
            // while (cont <= limite){
            //     System.Console.WriteLine($" {x} X {cont} = {x * cont} ");
            //     cont++;
            // }

            for (int cont = 0;cont <= limite; cont++){
                System.Console.WriteLine($" {x} X {cont} = {x * cont} ");
            }
        }
    }
}
