using System;

namespace Senai.Operadores.Exrc1_ {
    class Program {
        static void Main (string[] args) {

            // captura de dados pessoa 1
            #region pessoa 1
            Console.WriteLine ("Informe o peso da primeira pessoa");
            float pesoPessoa = float.Parse (Console.ReadLine ());

            Console.WriteLine ("Informe a altura da primeira pessoa");
            float alturaPessoa = float.Parse (Console.ReadLine ());

            float imcPessoa = pesoPessoa / (alturaPessoa * alturaPessoa);
            #endregion

            // captura de dados pessoa 2
            #region pessoa 2
            Console.WriteLine ("Informe o pesso da segunda pessoa");
            float pesoPessoa2 = float.Parse (Console.ReadLine ());

            Console.WriteLine ("Informe a altura da segunda pessoa");
            float alturaPessoa2 = float.Parse (Console.ReadLine ());

            // foi importado o "Math" e usado a tarefa "Pow" porem essa terafa é convertida em "double" que é o dobro do floatentão com isso devemos converter para float como foi feito depois do " = "
            float imcPessoa2 = (float) (pesoPessoa2 / Math.Pow (alturaPessoa2, 2));
            #endregion

            Console.Clear ();

            #region pessoa 1 resultados
            // resultado pessoa 1
            Console.WriteLine ("-----------------------------");
            Console.WriteLine ("Primeirs pessoa");
            Console.WriteLine ("-----------------------------");
            Console.WriteLine ("Peso:" + pesoPessoa);
            Console.WriteLine ("Altura:" + alturaPessoa);
            Console.WriteLine ("IMC:" + imcPessoa);
            Console.WriteLine ("---------------------------------------------------------------");
            #endregion

            #region pessoa 2 resultados
            // resultado pessoa 2
            Console.WriteLine ("-----------------------------");
            Console.WriteLine ("Segunda pessoa");
            Console.WriteLine ("-----------------------------");
            Console.WriteLine ($"Peso: {pesoPessoa2}");
            Console.WriteLine($"Altura: {alturaPessoa2}");
            Console.WriteLine($"IMC {imcPessoa2}");
            Console.WriteLine ("---------------------------------------------------------------");
            #endregion
        }
    }
}