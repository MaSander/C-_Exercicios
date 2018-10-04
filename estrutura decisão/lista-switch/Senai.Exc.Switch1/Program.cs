using System;

namespace Senai.Exc.Switch1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Informe o dia da semana entre 1 a 7");
            int dia = int.Parse(Console.ReadLine());

            switch (dia)
            {
                case 1:{
                    System.Console.WriteLine("Domingo");
                }
                break;

                case 2:{
                    System.Console.WriteLine("Segunda-feira");
                }
                break;

                case 3:{
                    System.Console.WriteLine("Terça-feira");
                }
                break;

                case 4:{
                    System.Console.WriteLine("Quarta-feira");
                }
                break;

                case 5:{
                    System.Console.WriteLine("Quinta-feira");
                }
                break;

                case 6:{
                    System.Console.WriteLine("Sexta-feira");
                }
                break;

                case 7:{
                    System.Console.WriteLine("Sabado");
                }
                break;

                default:{
                    System.Console.WriteLine("Opção invalida");
                }
                break;
            }
        }
    }
}
