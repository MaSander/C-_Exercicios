using System;

namespace Senai.Exemplos.Variaveis
{
    class Program
    {
        static void Main(string[] args)
        {
            // declaração das Variaveis com seus nomes

            string Nome;
            byte Idade;
            float Altura;
            char Sexo;
            DateTime dataNacimento;

            Console.Clear();

            Console.WriteLine("Informe seu nome");
            Nome = Console.ReadLine();

            Console.WriteLine("Informe sua idade");
            Idade = Convert.ToByte(Console.ReadLine());

            Console.WriteLine("Informe sua altura?");
            Altura = float.Parse(Console.ReadLine());

            Console.WriteLine("informe seu sexo");
            Sexo = char.Parse(Console.ReadLine());

            Console.WriteLine("Informe sua data de nacimento");
            dataNacimento = Convert.ToDateTime(Console.ReadLine());

            Console.Clear();

            Console.WriteLine("Nome: " + Nome + ", Idade:" + Idade + ", altura" + Altura + ", Sexo:" + Sexo + ", Sua idade:" + dataNacimento.ToShortDateString());




        }
    }
}
