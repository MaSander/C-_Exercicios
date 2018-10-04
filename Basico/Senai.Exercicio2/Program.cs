using System;

namespace Senai.Excr.Retangulo
{
    class Program
    {
        static void Main(string[] args)
        {

            float Base, Altura, Area;

            Console.WriteLine("Insira a base do retangulo");
            Base = float.Parse(Console.ReadLine());

            Console.WriteLine("Insira a altura do retangulo");
            Altura = float.Parse(Console.ReadLine());

            Area = Base * Altura;

            Console.Clear();
        
            Console.WriteLine($"A altura do retangulo vale:{Area}");
            
        }
    }
}
