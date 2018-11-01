using System;
using Folha.de.Pagamento.classe;

namespace Folha.de.Pagamento {
    class Program {
        static Funcionarios[] funci;
        static int opcao;
        static int contador = 0;
        static int contE = 0, indice;
        static float TotalBruto;

        static void Main (string[] args) {
            funci = new Funcionarios[1000];

            do {
                MenuInicio ();
                switch (opcao) {
                    case 1:
                        {
                            CadastroFunci ();
                            break;
                        }

                    case 2:
                        {
                            FolhaPagamento ();
                            break;
                        }
                    case 3:
                        {
                            SalarioBrutoTotal ();
                            break;
                        }
                    case 4:
                        {
                            AumentoDeSalario ();
                            break;
                        }
                    case 5:
                        {
                            ExibeSalarioLQD ();
                            break;
                        }
                    default:
                        {
                            System.Console.WriteLine ("Opção invalida");
                            Console.Clear ();

                            break;
                        }
                }

            } while (opcao != 0);
        }

        #region menu inicial
        /// <summary>
        /// Exibiçao do menu inicial
        /// </summary>
        static void MenuInicio () {
            System.Console.WriteLine (@"
                Escolha uma das opções
            -------------------------------
            1 - Cadastrar Funcionario
            2 - Folha de pagamento
            3 - Total de Custos Bruto da Folha
            4 - Aumento de Salário
            5 - Total de Custos Líquido da Folha
            0 - Sair");
            while (true) {
                try {
                    opcao = int.Parse (Console.ReadLine ());
                    break;
                } catch (System.Exception) {
                    continue;
                }
            }
        }
        #endregion 

        #region cadastro de usuario
        /// <summary>
        /// Cadatro de funcionarios
        /// </summary>
        static void CadastroFunci () {
            funci[contador] = new Funcionarios ();

            Console.Clear ();

            System.Console.WriteLine ("Informe o nome do funcionario");
            funci[contador].Nome = Console.ReadLine ();

            System.Console.WriteLine ("Informe o salario do funcionario");
            funci[contador].Salario = float.Parse (Console.ReadLine ());

            System.Console.WriteLine ("Funcionario cadastrado com sucesso");
            contador++;
        }
        #endregion

        #region Exibição de folha de pagamento

        static void FolhaPagamento () {
            #region Exibição de funcionarios
            contE = 0;
            foreach (Funcionarios item in funci) {
                if (item != null) {
                    System.Console.WriteLine ($"Indice({contE}) / {item.Nome} / {item.Salario.ToString("c")}");
                    contE++;
                }
            }
            #endregion

            do {

                System.Console.WriteLine ("Digite o indice do funcionario desejado");
                indice = int.Parse (Console.ReadLine ());

                if (indice < 0 || funci[indice] == null) {
                    System.Console.WriteLine ("Este indice não tem nenhum funcionario cadastrado");
                } else {
                    foreach (Funcionarios item in funci) {
                        System.Console.WriteLine ($"funcionario : {funci[indice].Nome}");
                        System.Console.WriteLine ($"Salario bruto = {funci[indice].Salario.ToString("c")}");
                        System.Console.WriteLine ($"Desconto INSS = {funci[indice].INSS().ToString("c")}");
                        System.Console.WriteLine ($"Desconto IPRF = {funci[indice].IRFF().ToString("c")}");
                        System.Console.WriteLine ($"Vale transporte = {funci[indice].VALETRANS().ToString("c")}");
                        System.Console.WriteLine ($"Salario liquido = {funci[indice].SALARIOLQD().ToString("c")}");
                        break;
                    }
                }
            } while (indice < 0 || funci[indice] == null);

        }
        #endregion

        #region Exibe total de custo bruto da folha

        static void SalarioBrutoTotal () {
            TotalBruto = 0;
            foreach (Funcionarios item in funci) {
                if (item != null) {
                    TotalBruto += item.Salario;
                }
            }
            System.Console.WriteLine ($"Salario bruto total = {TotalBruto.ToString("c")}");
        }
        #endregion

        #region Aumento de salario
        static void AumentoDeSalario () {
            #region Exibição de funcionarios
            contE = 0;
            foreach (Funcionarios item in funci) {
                if (item != null) {
                    System.Console.WriteLine ($"Indice({contE}) / {item.Nome} / {item.Salario.ToString("c")}");
                    contE++;
                }
            }
            #endregion

            System.Console.WriteLine ("Insira o indice do funcionario");
            indice = int.Parse (Console.ReadLine ());

            if (indice < 0 || funci[indice] == null) {
                System.Console.WriteLine ("Indici nao encontrado");
            } else {

                if (funci[indice].Salario > 1669) {
                    funci[indice].Salario += (float) (funci[indice].Salario * 0.05);
                    System.Console.WriteLine ("Salario aumentado em 5%");
                } else if (funci[indice].Salario <= 1669) {
                    funci[indice].Salario += (float) (funci[indice].Salario * 0.10);
                    System.Console.WriteLine ("Salario aumentado em 10%");
                } else if (funci[indice].Salario <= 3338) {
                    funci[indice].Salario += (float) (funci[indice].Salario * 0.15);
                    System.Console.WriteLine ("Salario aumentado em 15%");
                } else if (funci[indice].Salario <= 6676) {
                    funci[indice].Salario += (float) (funci[indice].Salario * 0.8);
                    System.Console.WriteLine ("Salario aumentado em 8%");
                }

            }
        }
        #endregion

        #region Exibe total de salarios liquidos
        static void ExibeSalarioLQD () {
            double SalarioLqd = 0;
            foreach (Funcionarios item in funci) {
                if (item != null) {
                    SalarioLqd += item.SALARIOLQD ();
                }
            }
            System.Console.WriteLine ($"Salario liquido total = {SalarioLqd.ToString("c")}");

        }
        #endregion
    }

}