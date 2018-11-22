using System;
using Senai.Exercicio1.classe;

namespace Senai.Exercicio1 {
    class Program {
        static void Main (string[] args) {
            Voos[] Passagem = new Voos[3];
            string escolha;
            int cont = 0, contE = 0;
            do {
                System.Console.WriteLine (@"
                        tudo sobre Passagem
                        ==================
                        para agendar digite - 1
                        para ver as Passagem digite - 2
                        para finalizar digite - 0");
                escolha = Console.ReadLine ();
                // estanciado
                Passagem[cont] = new Voos ();
                switch (escolha) {
                    case "1":
                        {
                            if (cont < 3) {
                                Passagem[cont].agendar ();
                                cont++;
                            } else {
                                System.Console.WriteLine ("Voo lotado.");
                            }
                            break;
                        }
                    case "2":
                        {
                            do {
                                // Passagem[contE] = new Voos();
                                Passagem[contE].Exibir ();  
                                contE++;
                            } while (contE < cont);
                            contE = 0;
                            break;
                        }
                }

            } while (escolha != "0");
        }

    }
}