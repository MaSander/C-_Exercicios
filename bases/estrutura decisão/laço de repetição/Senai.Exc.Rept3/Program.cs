using System;

namespace Senai.Exc.Rept3 {
    class Program {
        static void Main (string[] args) {
            // declarando variaveis
            string nome;
            int escolha;
            int X = 0, Y = 0;

            escolha = 9;

            System.Console.WriteLine (@"
            ################################
            Insira seu nome
            ################################");
            nome = Console.ReadLine ();

            // laço
            while (escolha != 0) {

                Console.WriteLine ($@"
            ##########################################################
            CALCULADORA DE {nome}
            1 - Definir valores de X e Y
            2 - Soma
            3 - Subtração
            4 - Multiplicação
            5 - Divisão
            6 - Potência
            0 - sair
            ##########################################################");
                escolha = int.Parse (Console.ReadLine ());

                // definindo escolha
                switch (escolha) {
                    case 1:
                        {
                            System.Console.WriteLine ("Define os valores de X e Y");
                            X = int.Parse (Console.ReadLine ());
                            Y = int.Parse (Console.ReadLine ());

                            System.Console.WriteLine ("Precione qualquer tecla para voltar.");
                            Console.ReadLine ();

                            break;
                        }

                    case 2:
                        {
                            System.Console.WriteLine ($"soma {X}+{Y} = {X + Y}");

                            System.Console.WriteLine ("Precione qualquer tecla para voltar.");
                            Console.ReadLine ();
                            break;
                        }

                    case 3:
                        {
                            System.Console.WriteLine ($"Subtração {X}-{Y} = {X - Y}");

                            System.Console.WriteLine ("Precione qualquer tecla para voltar.");
                            Console.ReadLine ();
                            break;
                        }

                    case 4:
                        {
                            System.Console.WriteLine ($"Multiplicação {X}X{Y} = {X * Y}");

                            System.Console.WriteLine ("Precione qualquer tecla para voltar.");
                            Console.ReadLine ();
                            break;
                        }

                    case 5:
                        {
                            System.Console.WriteLine ($"Divisão {X}/{Y} = {X / Y}");

                            System.Console.WriteLine ("Precione qualquer tecla para voltar.");
                            Console.ReadLine ();
                            break;
                        }

                    case 6:
                        {
                            System.Console.WriteLine ($"Potência {X} elevado {Y} = {Math.Pow( X, Y )}");

                            System.Console.WriteLine ("Precione qualquer tecla para voltar.");
                            Console.ReadLine ();
                            break;
                        }

                    case 0:
                        {
                            System.Console.WriteLine ("Fim");
                            break;
                        }

                    default:
                        {
                            System.Console.WriteLine ("Comando não identificado");
                            break;
                        }
                }
            }
        }
    }
}