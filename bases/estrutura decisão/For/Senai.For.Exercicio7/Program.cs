using System;

namespace Senai.For.Exercicio7
{
    class Program
    {
        static void Main(string[] args)
        {
            int nFib,Na, Nx = 0, Ny = 1;
            Console.WriteLine("Insira o numero de sequências de Fibonacci desejada:");
            nFib = int.Parse(Console.ReadLine());
            
            System.Console.WriteLine("----------------------");
            System.Console.WriteLine(Nx);
            System.Console.WriteLine(Ny);
            for(int i = 2; i < nFib; i++){
                System.Console.WriteLine($"{Na = Nx + Ny}");
                Nx = Ny;
                Ny = Na;
            }

        }
    }
}
