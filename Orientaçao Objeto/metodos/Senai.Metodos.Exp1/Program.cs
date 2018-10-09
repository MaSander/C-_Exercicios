using System;
using Senai.Metodos.Exemplo1.Classes;

namespace Senai.Metodos.Exp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Carro carro1 = new Carro();
            carro1.CapacidadeTanque = 45;
            carro1.KilometroPorLitro = 14;
            System.Console.WriteLine("informe o valor para abastecer:");
            carro1.abastecer(float.Parse(Console.ReadLine()));
            // carro1.abastecer(30);
            // carro1.abastecer(30);
            carro1.Ligar();
            System.Console.WriteLine(carro1.Ligado);
            carro1.Andar(120);
            carro1.Andar(260);
            carro1.Andar(80);
            carro1.Andar(1);
            System.Console.WriteLine(carro1.NivelTanque);
            System.Console.WriteLine($"total andado = {carro1.Odomedro}");
            float resultado = carro1.porcentagemNivelTanque();
            System.Console.WriteLine($"Niivel do tanque {resultado.ToString("n2")}%");
        }
    }
}
