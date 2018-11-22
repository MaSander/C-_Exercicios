using System;

namespace Senai.Exc.Switch2 {
    class Program {
        static void Main (string[] args) {
            Console.WriteLine ("Informe o ultimo digito da placa de seu carro.");
            int digitoPlaca = int.Parse (Console.ReadLine ());

            switch (digitoPlaca) {
                case 1:
                case 2:
                    {
                        Console.WriteLine ("Segunda-feira");
                    }
                    break;

                case 3:
                case 4:
                    {
                        Console.WriteLine ("Terça-feira");
                    }
                    break;

                case 5:
                case 6:
                    {
                        Console.WriteLine ("Quarta-feira");
                    }
                    break;
                case 7:
                case 8:
                    {
                        System.Console.WriteLine ("Quinta-feira");
                    }
                    break;
                case 9:
                case 0:
                    {
                        System.Console.WriteLine ("Sexta-feira");
                    }
                    break;
                default:
                    {
                        System.Console.WriteLine ("Digito invalido");
                    }
                    break;

            }
        }
    }
}