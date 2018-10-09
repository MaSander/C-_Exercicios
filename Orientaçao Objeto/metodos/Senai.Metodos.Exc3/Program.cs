using System;
using Senai.Metodos.Exc3.classe;

namespace Senai.Metodos.Exc3 {
    class Program {
        static void Main (string[] args) {

            Garrafa grf1 = new Garrafa ();

            string escolha;

            do {

                Console.WriteLine (@"
            Para encher a garrafa digite - 1
            Para esvaziar a garrafa digite - 2
            para saber a quantidade digite - 3
            para finalizar digite - 0");
                escolha = Console.ReadLine ();

                switch (escolha) {
                    case "1":
                        {
                            grf1.Encher ();
                            break;
                        }
                    case "2":
                        {
                            grf1.Esvaziar ();
                            break;
                        }
                        case "3":
                        {
                            System.Console.WriteLine($"Quantidade atual = {grf1.Exibir()}ml");
                            // grf1.Exibir();
                            break;
                        }
                    case "0":
                        {
                            System.Console.WriteLine ($"Finalizando");
                            break;
                        }

                }
            }
            while (escolha != "0");

        }
    }
}