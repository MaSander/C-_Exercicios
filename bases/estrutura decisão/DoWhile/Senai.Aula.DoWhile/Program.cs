using System;

namespace Senai.Aula.DoWhile {
    class Program {
        static void Main (string[] args) {

            // Requisitar a senha do usuario

            string senha;

            do {
                Console.WriteLine ("Insira sua senha!");
                senha = Console.ReadLine ();
            }while(senha != "123");

            System.Console.WriteLine("Benvinute");

        }
    }
}