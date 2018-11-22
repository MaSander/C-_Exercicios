using System;

namespace Senai.Exercicio7 {
    class Program {
        static void Main (string[] args) {
            Console.WriteLine ("Informe a quantidades de lados de um poligono");
            int qtd = int.Parse (Console.ReadLine ());

            if (qtd == 3) {

                System.Console.WriteLine ("Informe o tamanho dos lados");
                int medida = int.Parse (Console.ReadLine ());

                int areaT = (int) ((medida * medida) * Math.Sqrt (3) / 4);
                int areaQ = (int) (medida * medida);

                System.Console.WriteLine ($@"
                _______________
                Triangulo
                Area = {areaT}");
            } else if (qtd == 4) {

                System.Console.WriteLine ("Informe o tamanho dos lados");
                int medida = int.Parse (Console.ReadLine ());

                int areaT = (int) (Math.Sqrt (3) / 4 * (medida * medida));
                int areaQ = (int) (medida * medida);

                System.Console.WriteLine ($@"
                _______________
                Quadrado
                Area = {areaQ}");
            } else if (qtd == 5) {
                System.Console.WriteLine ($@"
                _______________
                Pentagono");
            } else {
                System.Console.WriteLine ("poligono invalido");
            }

        }
    }
}