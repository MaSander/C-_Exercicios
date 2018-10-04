using System;
using Senai.Exc.Switch5.classe;
namespace Senai.Exc.Switch5
{
    class Program
    {
        private static object salarioMin;

        static void Main(string[] args)
        {
            operario op1 = new operario();

            Console.WriteLine("Informe o salario minimo");
            op1.salarioMin = float.Parse(Console.ReadLine());

            System.Console.WriteLine("Informe sua Horas trabalhadas");
            op1.hTrabalho = float.Parse(Console.ReadLine());

            System.Console.WriteLine("Informe sua Horas extras");
            op1.hExtra = float.Parse(Console.ReadLine());

            System.Console.WriteLine("Informe quantos dependentes tem");
            op1.dependente = int.Parse(Console.ReadLine());

        }
    }
}
