using System;

namespace Senai.Exc.doWhile2 {
    class Program {
        static void Main (string[] args) {

            float numero = 0, soma = 0;
            int cont = 0;

            do {
                Console.WriteLine ($@"
            Insira um numero
            para finalizar digite 0");
                numero = int.Parse (Console.ReadLine ());

                soma += numero;

                cont++;

            }while(numero != 0);

            System.Console.WriteLine($@"
            #############################################
            soma dos numero digitados: {soma}.
            quantidade de numeros digitados: {cont - 1}
            Media dos numero:{soma / (cont-1)}
            #############################################");
        }
    }
}