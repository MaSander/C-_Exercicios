using System;

namespace Senai.Exercicio5
{
    class Program
    {
        static void Main(string[] args)
        {

            float P, qMin, qMax, ea, estqM, pEstqM, pEstqA;

            Console.WriteLine("Qual o preço do produto?");
            P = float.Parse(Console.ReadLine());

            Console.WriteLine("Qual a quantidade minima deste produto no estoque?");
            qMin = float.Parse(Console.ReadLine());

            Console.WriteLine("Qual a quantidade maxima deste produto no estoque?");
            qMax = float.Parse(Console.ReadLine());

            Console.WriteLine("Qual a quantidade atual deste produto no estoque?");
            ea = float.Parse(Console.ReadLine());

            estqM = (qMin + qMax) / 2;

            pEstqM = P * estqM;

            pEstqA = P * ea;

        }
    }
}
