using System;

namespace Codingdojo._2 {
    class Program {
        static void Main (string[] args) {

            float dividendo, divisor;

            int contador = 0;
            

            Console.WriteLine ("Informe o dividendo:");
            dividendo = float.Parse (Console.ReadLine ());

            Console.WriteLine ("Insira o divisor:");
            divisor = float.Parse (Console.ReadLine ());

            if ( dividendo > 0) {
                do{
                dividendo -= divisor;

                contador++;
            }while (dividendo >= 0 );

            System.Console.WriteLine($"{contador - 1}");
            } 
            else if (dividendo < 0) 
            {
                do{
                dividendo -= divisor;

                contador++;
            }while (dividendo >= 0 );

            System.Console.WriteLine($"-{contador}");
            }
            else if (divisor == 0);
            {
                System.Console.WriteLine("Erro");
            }
            else if (dividendo == 0);
            {
                System.Console.WriteLine("0");
            }
            

            

            

            
        }
    }
}