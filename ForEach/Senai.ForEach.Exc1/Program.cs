﻿using System;
using Senai.ForEach.Exc1.classe;

namespace Senai.ForEach.Exc1 {
    class Program {
        static Usuario[] arrayUsuario;
        static int contador = 0;
        static void Main (string[] args) {
            Console.WriteLine ("Infrme a qunatidade de usuarios");
            int quantidadeNumeros = int.Parse (Console.ReadLine ());

            // Instancio e passo a quantidade de posições
            arrayUsuario = new Usuario[quantidadeNumeros];

            int opcao = 0;

            do {
                MontarMenu ();
                opcao = int.Parse (Console.ReadLine ());

                switch (opcao) {
                    case 1:
                        {
                            CadastrarUsuario ();
                            break;
                        }

                    case 2:
                        {
                            ListarUsuario ();
                            break;
                        }

                    default:
                        {
                            System.Console.WriteLine ("Opção invalida");
                            break;
                        }
                }

            } while (opcao != 0);

        }

        /// <summary>
        /// Monta o menu do sistema
        /// </summary>
        static void MontarMenu () {
            System.Console.WriteLine ("Menu de opções");
            System.Console.WriteLine ("1 - Cadastrar");
            System.Console.WriteLine ("2 - Listar");
            System.Console.WriteLine ("0 - Sair");
        }

        static void CadastrarUsuario () {
            arrayUsuario[contador] = new Usuario ();

            System.Console.WriteLine ("Informe o nome");
            arrayUsuario[contador].Nome = Console.ReadLine ();

            #region Email
            bool emailValido = false;
            string email;

            do {

                System.Console.WriteLine ("Informe seu email");
                email = Console.ReadLine ();

                if (email.Contains ('@')) {
                    emailValido = true;
                    arrayUsuario[contador].Email = email;
                    break;
                } else {
                    System.Console.WriteLine ("E-mail Invalido");
                }

            } while (!emailValido);
            #endregion

            #region Senha
            bool senhaValida = false;
            string senha;

            do {
                System.Console.WriteLine ("Informe a senha");
                senha = Console.ReadLine ();

                if (senha.Length >= 4) {
                    arrayUsuario[contador].Senha = senha;
                    break;
                } else {
                    System.Console.WriteLine ("senha invalida");
                }

            } while (!senhaValida);

            #endregion
            Console.Clear ();
            System.Console.WriteLine ("Usuario cadastrado!");
            contador++;
        }

        static void ListarUsuario () {
            foreach (Usuario item in arrayUsuario) {

                if(item != null){
                System.Console.WriteLine ($"{item.Nome} - {item.Email}");
                }
            }
        }
    }
}