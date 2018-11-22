using System;
using Senai.OO.Exc1.classes;

namespace Senai.OO.Exc1 {

    class Program {
        static void Main (string[] args) {
            pessoa pessoa = new pessoa ();
            Console.WriteLine ("Informe o nome da pessoa 1:");
            pessoa.Nome = Console.ReadLine ();

            Console.WriteLine ("Informe a altura da pessoa 1:");
            pessoa.Altura = float.Parse (Console.ReadLine ());

            Console.WriteLine ("Informe o peso da pessoa 1:");
            pessoa.Peso = float.Parse (Console.ReadLine ());

            Console.WriteLine ($"O nome da pessoa é {pessoa.Nome}, seu peso é {pessoa.Peso}, e sua altura {pessoa.Altura}, imc = { pessoa.Peso / Math.Pow(pessoa.Altura, 2) }");

        }
    }
}