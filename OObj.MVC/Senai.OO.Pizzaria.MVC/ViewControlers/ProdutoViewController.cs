using System;
using System.Collections.Generic;
using Senai.OO.Pizzaria.MVC.Repositorios;
using Senai.OO.Pizzaria.MVC.Util;
using Senai.OO.Pizzaria.MVC.ViewModels;

namespace Senai.OO.Pizzaria.MVC.ViewControlers {
    /// <summary>
    /// Classe responsavel pelo View e Controller do produto
    /// </summary>
    public class ProdutoViewController {
        //Cria o objeto ProdutoRepositorio
        static ProdutoRepositorio produtorepositorio = new ProdutoRepositorio ();

        /// <summary>
        /// Cadastra um novo produto
        /// </summary>
        public static void CadastrarProduto () {
            string nome, descricao, preco, categoria;

            #region View
            //Recebe o nome do produto
            do {
                System.Console.WriteLine ("Informe o nome do produto");
                nome = Console.ReadLine ();
                if (string.IsNullOrEmpty (nome)) {
                    System.Console.WriteLine ("Nome do produto invalido");
                }

            } while (string.IsNullOrEmpty (nome));

            //Recebe a descriçao do produto
            do {
                System.Console.WriteLine ("descreva o produto");
                descricao = Console.ReadLine ();
                if (string.IsNullOrEmpty (descricao)) {
                    System.Console.WriteLine ("descrição invalida");
                }

                //Recebe o preço do produto
            } while (string.IsNullOrEmpty (descricao));

            do {
                System.Console.WriteLine ("Informe o preço do produto");
                preco = Console.ReadLine ();
                if (string.IsNullOrEmpty (preco)) {
                    System.Console.WriteLine ("preço invalido");
                }

            } while (string.IsNullOrEmpty (preco));

            //Recebe a categoria
            do {
                System.Console.WriteLine ("Informe a categoria do produto");
                categoria = Console.ReadLine ();

                if (!ValidacaoUtil.ValidaCategoria (categoria)) {
                    System.Console.WriteLine ("Categoria Invalida");
                }

            } while (!ValidacaoUtil.ValidaCategoria (categoria));

            #endregion

            #region Controller
            //Cria o objeto produtoviewmodel
            ProdutoViewModel produtoviewmodel = new ProdutoViewModel ();
            //Atribui os valores ao objeto produtoviewmodel
            produtoviewmodel.Nome = nome;
            produtoviewmodel.Descricao = descricao;
            produtoviewmodel.Preco = decimal.Parse (preco);
            produtoviewmodel.Categoria = categoria;

            //Insere o produto a lista
            produtorepositorio.Inserir (produtoviewmodel);

            //Mostra mensagem de conclusão
            System.Console.WriteLine ("Produto cadastrado");
            #endregion
        }

        /// <summary>
        /// Lista os produtos
        /// </summary>
        public static void ListarProdutos () {
            List<ProdutoViewModel> lsProdutos = produtorepositorio.listar ();

            foreach (ProdutoViewModel item in lsProdutos) {
                System.Console.WriteLine ($"{item.Id} - {item.Nome} - {item.Preco.ToString("N2")}");
            }

            System.Console.WriteLine ("Informe o Id do produto para mais informações ou 0 para sair.");

            int idProduto = 0;

            do {
                idProduto = int.Parse (Console.ReadLine ());

                if (idProduto == 0) {
                    break;
                }

                // declara um objeto produtoview model e busca pelo id
                ProdutoViewModel produtoviewmodel = produtorepositorio.BuscarPorId (idProduto);

                //verifica se o produto existe
                if (produtoviewmodel != null) {
                    System.Console.WriteLine ($@"- {produtoviewmodel.Id} 
                                                -  {produtoviewmodel.Nome} 
                                                -  {produtoviewmodel.Descricao}
                                                -  {produtoviewmodel.Preco.ToString("c")} 
                                                -  {produtoviewmodel.Categoria} 
                                                -  {produtoviewmodel.DataCriacao}");
                } else System.Console.WriteLine("Produto não encontrado");

            } while (idProduto != 0);
        }

    }
}