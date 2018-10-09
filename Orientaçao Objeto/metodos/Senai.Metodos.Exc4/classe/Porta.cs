namespace Senai.Metodos.Exc4.classe
{
    public class Porta
    {
        bool status = false;

        public void Abrir() {
            if (status){
                System.Console.WriteLine("Não precisa se esforçar pra nada");
            }
            else {
                status = true;
                System.Console.WriteLine("A porta abriu");
            }
        }

        public void Fechar() {
            if(status){
                status = false;
                System.Console.WriteLine("A porta fechou");
            }
            else {
                System.Console.WriteLine("Porta já esta fechada");
            }
        }
    }
}