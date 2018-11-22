using System;
using Senai.Metodos.Exc1.classe;

namespace Senai.Metodos.Exc1
{
    class Program
    {
        static void Main(string[] args)
        {
            Retangulo retangulo1 = new Retangulo();

            // Rcebendo lado A
            Console.WriteLine("Insira a base do retangulo");
            retangulo1.LadoA = float.Parse(Console.ReadLine());
            // Recebendo lado B
            Console.WriteLine("Insira o lado do retangulo");
            retangulo1.LadoB = float.Parse(Console.ReadLine());
            // Mostrando resultado
            retangulo1.CalcularArea();
            System.Console.WriteLine($"Perimetro ={retangulo1.CalcularPerimetro()}");
        }
    }
}
