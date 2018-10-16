using System;

namespace Senai.For.Exercicio5
{
    class Program
    {
        static void Main(string[] args)
        {
            int usuarios, idade, menor=0, maior=0;
            Console.WriteLine("Informe o numero de usuarios");
            usuarios = int.Parse(Console.ReadLine());

            for(int cont = 0; cont < usuarios; cont++){
                System.Console.WriteLine($"Informe a idade do {cont +1}º usuario");
                idade = int.Parse(Console.ReadLine());

                if (idade < 18){
                    menor++;
                }
                if (idade > 50){
                    maior++;
                }
            }
            System.Console.WriteLine($@"
            Menores de 18 anos {menor} usuario
            Maiores de 50 anos {maior} usuario");
        }
    }
}
