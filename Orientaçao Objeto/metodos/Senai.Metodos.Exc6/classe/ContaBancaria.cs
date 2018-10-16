using System;

namespace Senai.Metodos.Exc6.classe
{
    public class ContaBancaria
    {
        #region Atributos
        public string Nome {get; set;}
        public string Cpf {get; set;}
        public float Saldo = 0, vS = 0, vD = 0;
        #endregion

        #region metodos
            public void Sacar(){
                System.Console.WriteLine("Insira o valor desejado para sacar.");
                vS = float.Parse(Console.ReadLine());
                if(Saldo >= vS){
                    Saldo -= vS;
                    System.Console.WriteLine($"Saldo de {vS} concluido.");
                }else {
                    System.Console.WriteLine("Saldo bancario insuficiente para saque.");
                }
            }
            public void Depositar(){
                System.Console.WriteLine("Insira o valor para depositar");
                vD = float.Parse(Console.ReadLine());
                Saldo +=vD;
                System.Console.WriteLine($"Deposido de {vD} concluido");
                
            }
            public float mostraSaldo() => Saldo;

        #endregion
    }
}