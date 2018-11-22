using System;

namespace Senai.Exercicio5 {
    class Program {
        static void Main (string[] args) {
            int a, b, c;

            Console.WriteLine ("Informe 3 numeros distintos");
            a = int.Parse (Console.ReadLine ());
            b = int.Parse (Console.ReadLine ());
            c = int.Parse (Console.ReadLine ());

            if (a < b && a < c) {
                if (b < c)
                    System.Console.WriteLine ($"{a}, {b} e {c}");
                else {
                    System.Console.WriteLine ($"{a}, {c} e {b}");
                }
            } else if (b < a && b < c) {
                if (a < c)
                    System.Console.WriteLine ($"{b}, {a} e {c}");
                else {
                    System.Console.WriteLine ($"{b}, {c} e {a}");
                }
            } else if (a < b)
                System.Console.WriteLine ($"{c}, {a} e {b}");
            else {
                System.Console.WriteLine ($"{c}, {b} e {a}");
            }

        }
    }
}