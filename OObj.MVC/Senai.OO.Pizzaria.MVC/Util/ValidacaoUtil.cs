namespace Senai.OO.Pizzaria.MVC.Util {
    /// <summary>
    /// Classe responsavel pelas validações do sistema
    /// </summary>
    public class ValidacaoUtil {
        /// <summary>
        /// Metodo responsavel por validar o email
        /// </summary>
        /// <param name="email">Email a ser validado</param>
        public static bool ValidarEmail (string email) {
            if (email.Contains ('@') && email.Contains ('.')) return true;
            else return false;
        }
        /// <summary>
        /// Valida a senha informada
        /// </summary>
        /// <param name="senha">senha passada</param>
        public static bool ValidarSenha (string senha) {
            if (senha.Length >= 6) return true;
            else return false;
        }

        /// <summary>
        /// Valida a categoria informada do produto
        /// </summary>
        /// <param name="categoria">categora a ser informada</param>
        public static bool ValidaCategoria (string categoria) {
            if (categoria.ToLower () == "pizza" || categoria.ToLower () == "bebida") return true;
            else return false;
        }
    }
}