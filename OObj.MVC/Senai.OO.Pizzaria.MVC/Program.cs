using System;
using Senai.OO.Pizzaria.MVC.Repositorios;
using Senai.OO.Pizzaria.MVC.Util;
using Senai.OO.Pizzaria.MVC.ViewControlers;
using Senai.OO.Pizzaria.MVC.ViewModels;

namespace Senai.OO.Pizzaria.MVC
{
    class Program
    {
        static void Main(string[] args)
        {
            int opcaoDeslogado = 0, opcaologado = 0;

            do {
                MenuUtil.MenuDeslogado();

                opcaoDeslogado = int.Parse(Console.ReadLine());

                switch (opcaoDeslogado) {

                    case 1:
                    {
                        UsuarioViewControler.CadastrarUsuario();
                        break;
                    }

                    case 2:
                    {
                        //Vai para a tela de login e retorna o usuario caso valido
                        UsuarioViewModel usuarioviewmodel = UsuarioViewControler.Logar();

                        //Verifica se o usuario é valido
                        if (usuarioviewmodel != null){
                            System.Console.WriteLine("Seja bem vindo" + usuarioviewmodel.Nome);
                            do {
                                //Mostra o menu do usuario logado
                                MenuUtil.MenuLogado();
                                //aguarda a opçao do usuario
                                opcaologado = int.Parse(Console.ReadLine());
                                //escolhe a opçao do usuario
                                switch (opcaologado){
                                    case 1:{
                                        ProdutoViewController.CadastrarProduto();
                                        break;
                                    }
                                    case 2:{
                                        ProdutoViewController.ListarProdutos();
                                        break;
                                    }
                                    case 0:{
                                        System.Console.WriteLine("Tchau");
                                        break;
                                    }
                                    default:{
                                        break;
                                    }
                                }
                            } while (opcaologado != 0);

                        }
                        break;
                    }

                    case 3:
                    {
                        UsuarioViewControler.Listar();
                        break;
                    }

                    case 0:
                    {
                        System.Console.WriteLine("Finalizado.");
                        break;
                    }
                    
                    default:
                    {
                        System.Console.WriteLine("Opção invalida");
                        break;
                    }

                }

            } while(opcaoDeslogado != 0);

        }
    }
}
