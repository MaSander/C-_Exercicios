using System;
using Senai.Exercicio1.classe;

namespace Senai.Exercicio1
{
    class Program
    {
        static void Main(string[] args)
        {
            Voos[] viagens = new Voos[5];
            string escolha;
            int cont = 0, contE = 0;
            do{
                System.Console.WriteLine(@"
                        tudo sobre viagens
                        ==================
                        para agendar digite - 1
                        para ver as viagens digite - 2
                        para finalizar digite - 0");
                escolha = Console.ReadLine();
                viagens[cont] = new Voos();
                switch(escolha){
                    case "1":
                    {
                        if(cont == 5){
                            System.Console.WriteLine("Voo lotado.");
                        }else{
                        viagens[cont].agendar();
                        cont++;
                        }
                        break;
                    }
                    case "2":
                    {
                        do{
                        // viagens[contE] = new Voos();
                        viagens[contE].Exibir();
                        contE++;
                        }while(contE < cont);
                        contE = 0;
                        break;
                    }
                }

            }while(escolha != "0");
        }

    }
}