using System;

namespace Senai.Exercicio10
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("deseja converter qual medida de temperatura? (f=Fahrenheit), (c=Celcius):");
            char medida = char.Parse(Console.ReadLine());

            if (medida == 'f' )
            {
                System.Console.WriteLine("Informe a quantidade de graus F.:");
                float graus = float.Parse(Console.ReadLine());

                float cvrt = (float) ((graus - 32) / 1.8);

                System.Console.WriteLine($"F={graus}° é igual a C={cvrt}°");
                
            }
            else
            {
                System.Console.WriteLine("Informe a quantidade de graus C.:");
                float graus = float.Parse(Console.ReadLine());

                float cvrt = (float) (graus * 1.8 + 32);

                System.Console.WriteLine($"C={graus}° é igual a F={cvrt}°");
            }
        }
    }
}
