using System;
using Senai.Metodos.Exc7.classe;

namespace Senai.Metodos.Exc7 {
    class Program {
        static void Main (string[] args) {
            Conta conta1 = new Conta ();
            bool saida = false;

            do {
                Console.WriteLine ("Insira seu nome:");
                conta1.Nome = Console.ReadLine ();
                System.Console.WriteLine ("Insira seu email:");
                conta1.Usuario = Console.ReadLine ();
                System.Console.WriteLine ("Insira a senha:");
                conta1.Senha = Console.ReadLine ();

                if (conta1.Login())
                {
                    saida = true;
                } else {
                    System.Console.WriteLine("Senha ou usuario invalido digite [QUALQUER] tecla para volta");
                    Console.ReadKey();
                }
            } while (saida != true);
            System.Console.WriteLine($"{conta1.Nome} Ola. Seja bem vindo ao email.");
        }
    }
}