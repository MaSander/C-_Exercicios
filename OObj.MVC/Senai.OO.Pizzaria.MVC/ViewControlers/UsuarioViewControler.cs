using System;
using System.Collections.Generic;
using Senai.OO.Pizzaria.MVC.Repositorios;
using Senai.OO.Pizzaria.MVC.Util;
using Senai.OO.Pizzaria.MVC.ViewModels;

namespace Senai.OO.Pizzaria.MVC.ViewControlers {
    public static class UsuarioViewControler {
        /// <summary>
        /// Tela de cadastro de usuario
        /// </summary>
        public static void CadastrarUsuario () {
            string email, nome, senha;

            do {
                System.Console.WriteLine ("INFORME SEU NOME");
                nome = Console.ReadLine ();

                if (string.IsNullOrEmpty (nome)) {
                    System.Console.WriteLine ("Nome invalido");
                }

            } while (string.IsNullOrEmpty (nome));

            do {
                System.Console.WriteLine ("Informe seu email");
                email = Console.ReadLine ();

                if (!ValidacaoUtil.ValidarEmail (email)) {
                    System.Console.WriteLine (email);
                    System.Console.WriteLine ("Email invalido");
                }
            } while (!ValidacaoUtil.ValidarEmail (email));

            do {
                System.Console.WriteLine ("Informe a senha");
                senha = Console.ReadLine ();

                if (!ValidacaoUtil.ValidarSenha (senha)) {
                    System.Console.WriteLine ("senha invalida");
                }
            } while (!ValidacaoUtil.ValidarSenha (senha));

            #region controller
            // Criar um objeto do tipo UsuarioViewModel
            UsuarioViewModel usuarioviewmodel = new UsuarioViewModel ();
            //Atribui os valores as propriedades
            usuarioviewmodel.Nome = nome;
            usuarioviewmodel.Email = email;
            usuarioviewmodel.Senha = senha;

            //criar um objeto do tipo UsuarioRepositorio
            UsuarioRepositorio usuariorepositorio = new UsuarioRepositorio ();
            //Insirir um novo repositorio
            usuariorepositorio.inserir (usuarioviewmodel);

            //Mostra uma mensagem para o Usuario
            System.Console.WriteLine ("Usuario Cadastrado");
            #endregion

        }
        public static void Listar () {
            UsuarioRepositorio usuariorepositorio = new UsuarioRepositorio ();

            List<UsuarioViewModel> lsUsuarios = usuariorepositorio.Listar ();

            foreach (UsuarioViewModel item in lsUsuarios) {
                System.Console.WriteLine ($"{item.Id} - {item.Nome} - {item.Email}");
            }
        }

        public static UsuarioViewModel Logar () {
            string email, senha;

            #region View
            do {
                System.Console.WriteLine ("Informe seu email");
                email = Console.ReadLine ();

                if (!ValidacaoUtil.ValidarEmail (email)) {
                    System.Console.WriteLine (email);
                    System.Console.WriteLine ("Email invalido");
                }
            } while (!ValidacaoUtil.ValidarEmail (email));

            do {
                System.Console.WriteLine ("Informe a senha");
                senha = Console.ReadLine ();

                if (!ValidacaoUtil.ValidarSenha (senha)) {
                    System.Console.WriteLine ("senha invalida");
                }
            } while (!ValidacaoUtil.ValidarSenha (senha));
            #endregion

            #region Controler
            // Cria o usuario do tipo UsuarioRepositorio
            UsuarioRepositorio usuariorepositorio = new UsuarioRepositorio ();
            // Valida o email e senha do usuario
            UsuarioViewModel usuario = usuariorepositorio.Login (email, senha);

            //Vderifica se o email ou senha estao certos
            if (usuario != null) return usuario;
            else {
                //Se não existir mostra mensagem e retorna null
                System.Console.WriteLine ("E-mail ou senha invalido");
                return null;
            }
            #endregion
        }

    }
}