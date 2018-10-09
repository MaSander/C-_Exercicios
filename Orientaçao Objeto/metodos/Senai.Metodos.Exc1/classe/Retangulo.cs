namespace Senai.Metodos.Exc1.classe
{
    public class Retangulo
    {
        #region Atributos
            public float LadoA, LadoB;
        #endregion

        #region Metodos
            public void CalcularArea () {
                float Area = LadoA * LadoB;
                System.Console.WriteLine($"Area = {Area}");
            } 

            // perimetro em forma de LAMBDA
            public double CalcularPerimetro () => (LadoA + LadoB) * 2;
                
        #endregion
    }
}