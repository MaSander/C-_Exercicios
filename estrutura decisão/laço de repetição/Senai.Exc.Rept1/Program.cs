using System;

namespace Senai.Exc.Rept1 {
    class Program {
        static void Main (string[] args) {
            // receba o fator da tabuada
            Console.WriteLine ("Insira o fator");
            int fator = int.Parse (Console.ReadLine ());

            // inicia o contador como 0
            int contador;
            contador = 0;

            Console.Clear ();
            // laço de repitição
            while (contador >= 0) {

                Console.WriteLine ($"{fator} X {contador} = {contador * fator}");

                contador++;
            }

        }
    }
}