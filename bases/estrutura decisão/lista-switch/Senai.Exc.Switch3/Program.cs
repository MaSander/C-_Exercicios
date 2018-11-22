using System;

namespace Senai.Exc.Switch
{
    class Program
    {
        static void Main(string[] args)
        {
            float medida, medidab, medidah, medidar;

            Console.WriteLine(@"
            Escolha um poligo abaixo:
            q = quadrado
            t = triangulo
            c = circulo");
            char forma = char.Parse(Console.ReadLine());

            switch (forma)
            {
                case 'q':
                {
                    System.Console.WriteLine("Informe o tamanho do lado do quadrado");
                    medida = float.Parse(Console.ReadLine());

                    System.Console.WriteLine($"A area deste quadrado vale: {medida * medida}");
                }
                break;

                case 't':
                {
                    System.Console.WriteLine("Informe o tamanho da base e da altura");
                    medidab = float.Parse(Console.ReadLine());
                    medidah = float.Parse(Console.ReadLine());

                    System.Console.WriteLine($"A area desse triangulo vale: { (medidab * medidah) / 2 }");
                }
                break;

                case 'c':
                {
                    System.Console.WriteLine("Iinforme o raio do circulo");
                    medidar = float.Parse(Console.ReadLine());

                    System.Console.WriteLine($"A area desse circulo vale: { 3.14 * medidar * medidar }");
                }
                break;
            }
        }
    }
}
