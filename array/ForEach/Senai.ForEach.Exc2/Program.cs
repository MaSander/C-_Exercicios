using System;
using Senai.ForEach.Exc2.classe;

namespace Senai.ForEach.Exc2
{
    class Program
    {
        static Produtos[] comercio; // declaraçao de array 

        static float porcentagem;
        static string indentifica;
        static void Main(string[] args)
        {
            System.Console.WriteLine("Informe a quantidade de produtos");
            int qntProd = int.Parse(Console.ReadLine());
            
            comercio = new Produtos[qntProd];

            int opcao;

            do{

                opcao = int.Parse(Console.ReadLine());
                switch (opcao){
                    case 1:{
                        MontarMenu();
                        opcao = int.Parse(Console.ReadLine());
                        break;
                    }
                    case 2:{
                        ListarProd();
                        break;
                    }
                    case 3:{
                        break;
                    }
                    case 4:{
                        break:
                    }
                }

            }while(opcao != 0);

        }

        #region Menu do sistema
    
        /// <summary>
        /// menu do sistema
        /// </summary>
        static void MontarMenu(){
            System.Console.WriteLine(@"
            1 - Cadastrar novo produto
            2 - Listar produtos
            3 - Aumentar valor de produto
            4 - Quantidade e valor de produtos total");
        }
        #endregion

        #region lista produtos
        static void ListarProd(){
        foreach (Produtos item in comercio)
        {
            if(item != null){
                System.Console.WriteLine($@"{item.Id}, {item.Nome}, {item.Valor}.");
            }
        }
        }
        #endregion

        #region Aumenta valor
            static void AlteraValor(){
                System.Console.WriteLine("Informe um numero para ser alterado em porcentagem");
                porcentagem = float.Parse(Console.ReadLine());

                foreach (Produtos item in comercio)
                {
                    do{
                        System.Console.WriteLine("Informe o ID do produto que deseja altera");
                        indentifica = Console.ReadLine();

                        if(indentifica == item.Id){
                            System.Console.WriteLine("Produto alterado");
                        } else {
                            System.Console.WriteLine("ID não identificado");
                        }
                                                
                    }while(indentifica == item.Id);
                }
            }
        #endregion

        #region Informa quantidade e valores total somado

        #endregion
    }
}
