using System;
using Senai.Metodos.Exc4.classe;

namespace Senai.Metodos.Exc4
{
    class Program
    {
        static void Main(string[] args)
        {
            Porta door = new Porta();

            string fase;

            do{
            Console.WriteLine(@" porta simulador
            abrir - 1
            fechar - 2
            sair - 3");
            fase = Console.ReadLine();
            

            switch(fase)
            {
                case "1":
                {
                    door.Abrir();
                    break;
                }
                case "2":{
                door.Fechar();
                break;
                }
            }

            }while(fase != "3");

        }
    }
}
