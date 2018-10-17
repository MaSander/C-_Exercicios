using System;
using Senai.CadastroEmail.Exc3.classe;

namespace Senai.CadastroEmail.Exc3 {
    class Program {
        static void Main (string[] args) {
            int tecla, cont = 0;
            Cadastro[] usuario = new Cadastro[10];

            do {
                System.Console.WriteLine (@"
                1 - Cadastra novo usuario
                2 - Listar todos usuarios
                3 - Acessar Email");
                tecla = int.Parse (Console.ReadLine ());

                switch (tecla) {
                    case 1:
                        {
                            usuario[cont] = new Cadastro ();
                            System.Console.WriteLine ("Informe seu nome");
                            usuario[cont].Nome = Console.ReadLine ();

                            usuario[cont].VerficEmail ();

                            usuario[cont].VerficSenha ();

                            cont++;
                            break;
                        }
                }

            } while (tecla != 0);
        }
    }
}