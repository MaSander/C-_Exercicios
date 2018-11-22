using System;
using Senai.OO.Exc3.classe;

namespace Senai.OO.Exc3
{
    class Program
    {
        static void Main(string[] args)
        {
            Conta c1 = new Conta();
            Conta c2 = new Conta();
            Conta c3 = new Conta();

// conta 1
            #region cliente 1
            Console.WriteLine("------------------------------------");

            Console.WriteLine("Informe o nome do primeiro cliente:");
            c1.nome = Console.ReadLine();

            Console.WriteLine("Informe o número da conta do mesmo:");
            c1.numero = int.Parse(Console.ReadLine());

            Console.WriteLine("Informe o saldo da conta do mesmo:");
            c1.saldo = float.Parse(Console.ReadLine());
            #endregion

// conta 2
            #region cliente 2
             Console.WriteLine("------------------------------------");

            Console.WriteLine("Informe o nome do segunda cliente:");
            c2.nome = Console.ReadLine();

            Console.WriteLine("Informe o número da conta do mesmo:");
            c2.numero = int.Parse(Console.ReadLine());

            Console.WriteLine("Informe o saldo da conta do mesmo:");
            c2.saldo = float.Parse(Console.ReadLine());
            #endregion

// conta 3
            #region  cliente 3
             Console.WriteLine("------------------------------------");

            Console.WriteLine("Informe o nome do terceira cliente:");
            c3.nome = Console.ReadLine();

            Console.WriteLine("Informe o número da conta do mesmo:");
            c3.numero = int.Parse(Console.ReadLine());

            Console.WriteLine("Informe o saldo da conta do mesmo:");
            c3.saldo = float.Parse(Console.ReadLine());
            #endregion

            Console.Clear();
            Console.WriteLine("------------------------------------");

            Console.WriteLine($"Conta {c1.numero}");
            Console.WriteLine($"Nome do dono {c1.nome}");
            Console.WriteLine($"Saldo de ={c1.saldo}");

            Console.WriteLine("------------------------------------");

            Console.WriteLine($"Conta {c2.numero}");
            Console.WriteLine($"Nome do dono {c2.nome}");
            Console.WriteLine($"Saldo de ={c2.saldo}");
            
            Console.WriteLine("------------------------------------");

            Console.WriteLine($"Conta {c3.numero}");
            Console.WriteLine($"Nome do dono {c3.nome}");
            Console.WriteLine($"Saldo de ={c3.saldo}");

            Console.WriteLine("------------------------------------");

        }
    }
}
