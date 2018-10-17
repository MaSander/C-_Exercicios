using System;
using Senai.Array.Exc2.classe;

namespace Senai.Array.Exc2 {
    class Program {
        static void Main (string[] args) {
            int NumeroUsuarios;

            Console.WriteLine ("Insira quantos Usuarios irá cadastrar");
            NumeroUsuarios = int.Parse (Console.ReadLine ());

            Cadastros[] Usuario = new Cadastros[NumeroUsuarios];

            for (int i = 0; i < Usuario.Length; i++) {
                // instanciando usuario
                Usuario[i] = new Cadastros ();

                // recebendo informações

                // nome
                System.Console.WriteLine ("Insira o nome do usuario");
                Usuario[i].Nome = Console.ReadLine ();

                // idade
                System.Console.WriteLine ("Insira a idade");
                Usuario[i].Idade = int.Parse (Console.ReadLine ());

                // endereço
                System.Console.WriteLine ("Insira o endereço da resedencia");
                Usuario[i].Endereco = Console.ReadLine ();
            }

            // exibindo informação
            for (int i = NumeroUsuarios - 1; i >= 0; i--) {
                System.Console.WriteLine ("----------------------------------------------------------");
                System.Console.WriteLine ($"{NumeroUsuarios - i}° :: {Usuario[i].Nome},{Usuario[i].Idade},{Usuario[i].Endereco}.");
            }
            System.Console.WriteLine ("----------------------------------------------------------");

        }
    }
}