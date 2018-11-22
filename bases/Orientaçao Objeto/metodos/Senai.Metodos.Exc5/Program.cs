using System;
using Senai.Metodos.Exc5.classe;

namespace Senai.Metodos.Exc5
{
    class Program
    {
        static void Main(string[] args)
        {
            Triangulo tri = new Triangulo();

            Console.WriteLine("Infome o primeiro lado do triangulo");
            tri.ladoA = float.Parse(Console.ReadLine());

            Console.WriteLine("Infome o segundo lado do triangulo");
            tri.ladoB = float.Parse(Console.ReadLine());

            Console.WriteLine("Infome o terceiro lado do triangulo");
            tri.ladoC = float.Parse(Console.ReadLine());

            if (tri.Valido()) {
                System.Console.WriteLine($"Triangulo {tri.Tipo()}");;
            }else {
                System.Console.WriteLine("Triangulo invalido");
            }
        }
    }
}
