namespace Senai.OO.Pizzaria.MVC.ViewModels
{
    /// <summary>
    /// Classe responsavel pelas informaçoes do usuario
    /// </summary>
    public class UsuarioViewModel : BaseViewModel
    {
        /// <summary>
        /// Email do usuario
        /// </summary>
        public string Email { get; set; }
        /// <summary>
        /// Senha do usuario
        /// </summary>
        public string Senha { get; set; }
    }
}