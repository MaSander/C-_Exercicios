namespace Senai.Metodos.Exc7.classe
{
    public class Conta
    {
        // atributo
        public string Nome, Usuario, Senha;

        // metodos
        public bool Login(){
            if(Usuario == "senai@sp.senai.br")
            {
                if(Senha == "1234")
                {
                    return true;
                } else {
                    return false;
                }
            } else {
                return false;
            }

        }
    }
}