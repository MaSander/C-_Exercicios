namespace Senai.Metodos.Exemplo1.Classes {
    /// <summary>
    /// Calcula a quantidade de Kilometros por Litro do que o carro percorre;
    /// </summary>
    public class Carro {
        #region Atributos
        public float KilometroPorLitro;
        public int CapacidadeTanque;
        // o atributo pode ser lido pelo usuario mas não pode ser alterado por ele
        public float NivelTanque { get; private set; }
        public bool Ligado;
        public float Odomedro {get; private set;}

        

        #endregion

        #region Metodos
        /// <summary>
        /// Ligar o carro, altera o valor da variável bool 'Ligado' para 'true'.
        /// </summary>
        public void Ligar () {
            System.Console.WriteLine ("Carro ligado!");
            Ligado = true;
        }

        public void abastecer (float quantidade) {
            if (NivelTanque + quantidade <= CapacidadeTanque) {
                NivelTanque += quantidade;
            } else {
                System.Console.WriteLine ("tanque cheio");
            }
        }

        public void Andar (float Kilometragem) {
            if (Ligado) {
                float consumo = Kilometragem / KilometroPorLitro;
                System.Console.WriteLine ($"Carro vai consumir {consumo} litros");

                // verificando se o tanque possui combustivel suf. p/ consumo
                if (NivelTanque >= consumo)
                {
                    Odomedro += Kilometragem;
                    NivelTanque -= consumo;
                } else {
                    System.Console.WriteLine ("##Conbustivel insuficiente##");
                }

            } else {
                System.Console.WriteLine ("ligue o carro");
            }
        }
            public float porcentagemNivelTanque() {
                float porcentagem = (NivelTanque / CapacidadeTanque) * 100;
                return porcentagem;
            }
        #endregion
    }
}