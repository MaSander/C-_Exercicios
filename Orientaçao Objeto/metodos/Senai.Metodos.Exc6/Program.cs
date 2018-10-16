using System;
using Senai.Metodos.Exc6.classe;

namespace Senai.Metodos.Exc6 {
    class Program {
        static void Main (string[] args) {
            ContaBancaria conta1 = new ContaBancaria ();
            string escolha;
            System.Console.WriteLine ("Informe seu nome");
            conta1.Nome = Console.ReadLine ();
            System.Console.WriteLine ("Informe seu cpf");
            conta1.Cpf = Console.ReadLine ();

            do {
                System.Console.WriteLine (@"
                Para sacar digite - 1
                Para depositar digite - 2
                Para saber o saldo bancario digite - 3
                Para finalizar digite - 0");
                escolha = Console.ReadLine ();
                switch (escolha) {
                    case "1":
                        {
                            conta1.Sacar();
                            break;
                        }
                    case "2":
                    {
                        conta1.Depositar();
                        break;
                    }
                    case "3":
                    {
                        System.Console.WriteLine(conta1.mostraSaldo());
                        break;
                    }

                }

            } while (escolha != "0");
        }
    }
}