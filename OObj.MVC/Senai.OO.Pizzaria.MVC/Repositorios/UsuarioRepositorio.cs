using System;
using System.Collections.Generic;
using Senai.OO.Pizzaria.MVC.ViewModels;

namespace Senai.OO.Pizzaria.MVC.Repositorios
{
    /// <summary>
    /// Classe responsavel pela leitura e gravação dos dados referentes ao usuario
    /// </summary>
    public class UsuarioRepositorio
    {
        // Criação do objeto List<UsuarioViewModel> que faz parte
        static List<UsuarioViewModel> lsUsuario = new List<UsuarioViewModel>();

/// <summary>
/// Metodo para inserir um novo usuario
/// </summary>
/// <param name="usuario">Objeto UsuarioViewModel(Nome, Email, Senha)</param>
/// <returns>Retorna um UsuarioViewModel atualizado</returns>
        public UsuarioViewModel inserir(UsuarioViewModel usuario){
            //Atribui um valor ao ID, verifica a quantidade de itens na lista e soma 1
            usuario.Id = lsUsuario.Count + 1;
            //Atribui a Data e Hora Atual do sistem
            usuario.DataCriacao = DateTime.Now;
            //Atribui o usuario a lista
            lsUsuario.Add(usuario);
            //retorna o usuario
            return usuario;
        }
        /// <summary>
        /// Lista todos os usuarios
        /// </summary>
        /// <returns>Retorna um list</returns>
        public List<UsuarioViewModel> Listar(){
            return lsUsuario;
        }

        public UsuarioViewModel Login(string email, string senha){
            //Percorre a lista de Usuarios
            foreach (UsuarioViewModel item in lsUsuario)
            {
                //Verifica se o item/obj email e senha são iguais aos valores passados
                //Como paremetro
                if(item.Email == email && item.Senha == senha){
                    //Retorna o item/obj 
                    return item;
                }
            }
            //Caso não encontre o usuario retorna null
            return null;
        }

    }
}