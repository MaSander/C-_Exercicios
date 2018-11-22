using System;

namespace Senai.Exc.doWhile1 {
    class Program {
        static void Main (string[] args) {
            string nome, decisao;
            int idade, telefone;

            do {
                Console.WriteLine ("Insira seu nome:");
                nome = Console.ReadLine ();

                Console.WriteLine ("Insira sua idade:");
                idade = int.Parse (Console.ReadLine ());

                Console.WriteLine ("Insira seu telefone:");
                telefone = int.Parse (Console.ReadLine ());

                System.Console.WriteLine (@"Deseja recadastra?
                Precione [ s ] para recadastra.
                Para não precione ENTER.");
                decisao = Console.ReadLine();

            } while (decisao.ToUpper() == "s");

            Console.Clear();

            System.Console.WriteLine($@"
            ################################
            cadastro feito com sucesso!!!
            ################################
            nome: {nome}.
            idade: {idade}.
            telefone: {telefone}.
            ################################");
        }
    }
}