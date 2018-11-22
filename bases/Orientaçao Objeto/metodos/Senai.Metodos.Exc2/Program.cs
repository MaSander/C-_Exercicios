using System;
using Senai.Metodos.Exc2.classe;

namespace Senai.Metodos.Exc2
{
    class Program
    {
        static void Main(string[] args)
        {
            Calculadora calcula1 = new Calculadora();

            Console.WriteLine("Digite o primeiro numero:");
            calcula1.Numero1 = double.Parse(Console.ReadLine());
            Console.WriteLine("Digite o segundo numero:");
            calcula1.Numero2 = double.Parse(Console.ReadLine());

            System.Console.WriteLine(@"
            1 para somar
            2 para subtrair
            3 para multiplicar
            4 para dividir");

            string escolha = Console.ReadLine();            
            
            switch (escolha){
                case "1":{
                    calcula1.Somar();
                    break;
                }
                case "2":{
                    calcula1.Subitrair();
                    break;
                }
                case "3":{
                    calcula1.Multiplicar();
                    break;
                }
                case "4":{
                    calcula1.Dividir();
                    break;
                }
                case "0":{
                    System.Console.WriteLine("FIM");
                    break;
                }
                default: {
                    System.Console.WriteLine("Incoreto");
                    break;
                }
            }
        }
    }
}
