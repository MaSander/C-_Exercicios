using System;

namespace Senai.Exercicio1.classe
{
    public class Voos
    {
        // atributos  
        public string Nome, numeroPassagem;
        public DateTime datavoo;

        // metodos
        public void agendar(){
            System.Console.WriteLine("Informe o nome:");
            Nome = Console.ReadLine();
            System.Console.WriteLine("Informe o numero da passagem:");
            numeroPassagem = Console.ReadLine();
            System.Console.WriteLine("Informe a data da viaem");
            datavoo = DateTime.Parse(Console.ReadLine());

        }
        public void Exibir(){
            System.Console.WriteLine($@"
            nome passageiro: {Nome}
            Numero da viagem: {numeroPassagem}
            Data do voo: {datavoo.ToShortDateString()}");
        }
    }
}