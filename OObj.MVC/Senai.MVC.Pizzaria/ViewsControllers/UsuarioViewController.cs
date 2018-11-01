using System;
using System.Collections.Generic;
using System.IO;
using Senai.MVC.Pizzaria.Models;

namespace Senai.MVC.Pizzaria.ViewsControllers
{
    public class UsuarioViewController
    {
    int contador = 1;
        public void Cadastrar(){
            #region View
                System.Console.WriteLine("informe seu nome:");
                string nome = Console.ReadLine();
                
                System.Console.WriteLine("informe o seu email:");
                string email = Console.ReadLine();
                
                System.Console.WriteLine("Infome a sua senha");
                string senha = Console.ReadLine();
            #endregion

            #region Controller
                UsuarioViewModel usuarioViewModel = new UsuarioViewModel();

                List<UsuarioViewModel> lsUsuarios = ListarUsuarios();

                usuarioViewModel.Id = lsUsuarios.Count + 1;
                usuarioViewModel.Nome = nome;
                usuarioViewModel.Email = email;
                usuarioViewModel.Senha = senha;
                usuarioViewModel.DataCriacao = DateTime.Now;
                

                using(StreamWriter SW = new StreamWriter
                ("usuarios.csv",true)){
                    SW.WriteLine($"{usuarioViewModel.Id};{usuarioViewModel.Nome};{usuarioViewModel.Email};{usuarioViewModel.Senha};{usuarioViewModel.DataCriacao}");
                }

                System.Console.WriteLine("Usúario cadastrado");
                contador++;
            #endregion
        }

        public void Logar(){
            #region View    
            System.Console.WriteLine("Informe seu e-mail");
            string email = Console.ReadLine();
            
            System.Console.WriteLine("Informe sua senha");
            string senha = Console.ReadLine();
            #endregion

            #region controller

                List<UsuarioViewModel> lsUsuarios = ListarUsuarios();


                foreach (UsuarioViewModel item in lsUsuarios)
                {

                    if(item.Email == email && item.Senha == senha){
                        System.Console.WriteLine("Acesso liberado");
                        break;
                    }
                }

            #endregion
        }

        public void Listar(){
            #region controller
                List<UsuarioViewModel> lsUsuarios = ListarUsuarios();
            #endregion

            #region View
                foreach (UsuarioViewModel item in lsUsuarios)
                {
                    System.Console.WriteLine($"{item.Id} - {item.Nome} - {item.Email} - {item.DataCriacao}");
                }
            #endregion
        }

        private List<UsuarioViewModel> ListarUsuarios(){
            List<UsuarioViewModel> lsUsuarios = new List<UsuarioViewModel>();
                UsuarioViewModel usuario;

                string[] linhas = File.ReadAllLines("usuarios.csv");

                foreach (string item in linhas)
                {
                    string[] dados = item.Split(";");

                    usuario = new UsuarioViewModel();
                    usuario.Id = int.Parse(dados[0]);
                    usuario.Nome = dados[1];
                    usuario.Email = dados[2];
                    usuario.DataCriacao = DateTime.Parse(dados[4]);
                    lsUsuarios.Add(usuario);
                }
            return lsUsuarios;
        }
    }
}