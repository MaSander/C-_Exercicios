using System;

namespace Senai.CadastroEmail.Exc3.classe
{
    public class Cadastro
    {
        public string Nome, Email, Senha;

        public void VerficEmail(){
            do{
                System.Console.WriteLine("Crie um email (use '@')");
                Email = Console.ReadLine();
                
            }while(Email.Contains('@')==false);
        }

        public void VerficSenha(){
            do{
            System.Console.WriteLine("Crie uma senha");
            Senha = Console.ReadLine();
            }while(Senha.Length < 4);
            
        }
    }
}