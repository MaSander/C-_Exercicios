using System;
using System.Collections.Generic;
using Senai.OO.Pizzaria.MVC.ViewModels;

namespace Senai.OO.Pizzaria.MVC.Repositorios
{
    /// <summary>
    /// Classe responsavel pela gravação e leitura do produto
    /// </summary>
    public class ProdutoRepositorio
    {
        /// <summary>
        /// Insere um novo produto
        /// </summary>
        /// <param name="produto">Dados do produto</param>
        /// <returns>Retorna o produto atualizado</returns>
        static List<ProdutoViewModel> lsProduto = new List<ProdutoViewModel>();

        public ProdutoViewModel Inserir(ProdutoViewModel produto)
        {
            //Atribui ao Id a quantidade de itens da lista + 1
            produto.Id = lsProduto.Count + 1;
            //Atribui a data de criaçao ao objeto
            produto.DataCriacao = DateTime.Now;
            //Adiciona o produto na lista
            lsProduto.Add(produto);
            //Retorna o produto
            return produto;
        }

        /// <summary>
        /// Retorna a lista de produtos
        /// </summary>
        /// <returns>Retorna um List</returns>
        public List<ProdutoViewModel> listar(){
            return lsProduto;
        }

        /// <summary>
        /// Busca um produto pelo seu id
        /// </summary>
        /// <param name="id">Id do produto</param>
        /// <returns>Retornar um produto</returns>
        public ProdutoViewModel BuscarPorId(int id){
            foreach (ProdutoViewModel item in lsProduto)
            {
                if(item.Id == id){
                    return item;
                }
            }
            return null;
        }
    }
}