using System;
using Senai.MVC.Pizzaria.ViewsControllers;

namespace Senai.MVC.Pizzaria
{
    class Program
    {
        static void Main(string[] args)
        {
            UsuarioViewController usuarioView = new UsuarioViewController();    

            usuarioView.Cadastrar();

            // usuarioView.Logar();

            usuarioView.Listar();
        }
    }
}
