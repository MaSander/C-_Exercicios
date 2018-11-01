using System;

namespace Folha.de.Pagamento.classe {
    public class Funcionarios {
        #region Nome Salario
        public string Nome { get; set; }
        public float Salario { get; set; }
        #endregion

        public double Inss;
        public double Irff;
        public double ValeTrans;
        public double SalarioLqd;

        #region Metodos de Exibição da folha

        public double INSS () {
            Inss = Salario * 0.11;
            return Inss;
        }

        public double IRFF () {
            Irff = Salario * 0.075;
            return Irff;
        }

        public double VALETRANS () {
            ValeTrans = Salario * 0.06;
            return ValeTrans;
        }

        public double SALARIOLQD () {
            SalarioLqd = Salario - (INSS() + IRFF() + VALETRANS());
            return SalarioLqd;
        }

        #endregion

    }
}