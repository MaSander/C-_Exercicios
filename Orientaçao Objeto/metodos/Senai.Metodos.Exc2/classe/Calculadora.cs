namespace Senai.Metodos.Exc2.classe
{
    public class Calculadora
    {  
        // Atributo
        public double Numero1, Numero2, Resultado;

        #region Metodos
        public void Somar() {
            Resultado = Numero1 + Numero2;
            System.Console.WriteLine($"{Resultado}");
        }

         public void Subitrair() {
            Resultado = Numero1 - Numero2;
            System.Console.WriteLine($"{Resultado}");
        }

         public void Multiplicar() {
             Resultado = Numero1 * Numero2;
             System.Console.WriteLine($"{Resultado}");
        }

         public void Dividir() {
             Resultado = Numero1 / Numero2;
             System.Console.WriteLine($"{Resultado}");
        }

        #endregion

    }
}