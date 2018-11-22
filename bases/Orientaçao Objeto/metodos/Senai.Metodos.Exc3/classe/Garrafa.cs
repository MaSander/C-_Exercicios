using System;

namespace Senai.Metodos.Exc3.classe
{
    public class Garrafa
    {
        // Atributo
        public float qnt {get; set;}
        public float cont {get; set;}

        // metodos
        public void Encher() {
            System.Console.WriteLine("Informe a quantidade que deseja encher em ml:");
            cont = float.Parse(Console.ReadLine());
            qnt += cont;
        }

        public void Esvaziar() {
            System.Console.WriteLine("Informe a quantidade que deseja esvaziar em ml:");
            cont = float.Parse(Console.ReadLine());
            qnt -= cont;
        }

            public float Exibir(){
                
                return qnt;
            }
        
    }
}