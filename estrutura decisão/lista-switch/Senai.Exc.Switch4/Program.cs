using System;

namespace Senai.Exc.Switch4 {
    class Program {
        static void Main (string[] args) {
            string nome;
            float salario;
            int codigo;

            Console.WriteLine ("Digite o nome do funcionario");
            nome = Console.ReadLine ();
            System.Console.WriteLine (@"
            Digite o codigo de cargo
            ________________________
            1 - Escriturário
            2 - Secretário
            3 - Caixa
            4 - Gerente
            5 - Diretor");
            codigo = int.Parse(Console.ReadLine());
            System.Console.WriteLine("Informe o salario do funcionario");
            salario = float.Parse(Console.ReadLine());
            Console.Clear ();

            switch (codigo)

            {
                case 1:
                {
                    System.Console.WriteLine($@"
                    {nome}
                    Salario - R${salario}
                    Cargo - Escriturário
                    Porcentual aumentado - 50%
                    Salario com aumento - {salario * 1.5}");
                    break;
                }

                case 2:{
                    System.Console.WriteLine($@"
                    {nome}
                    Salario - R${salario}
                    Cargo - Secretário
                    Porcentual aumentado - 35%
                    Salario com aumento - {salario * 1.35}");
                    break;
                }
                
                case 3:{
                    System.Console.WriteLine($@"
                    {nome}
                    Salario - R${salario}
                    Cargo - Caixa
                    Porcentual aumentado - 20%
                    Salario com aumento - {salario * 1.2}");
                    break;
                }

                case 4:{
                    System.Console.WriteLine($@"
                    {nome}
                    Salario - R${salario}
                    Cargo - Gerente
                    Porcentual aumentado - 10%
                    Salario com aumento - {salario * 1.1}");
                    break;
                }

                case 5:{
                    System.Console.WriteLine($@"
                    {nome}
                    Salario - R${salario}
                    Cargo - Diretor
                    Insento de aumento");
                    break;
                }

            }
            // fim do switch
        }
    }
}