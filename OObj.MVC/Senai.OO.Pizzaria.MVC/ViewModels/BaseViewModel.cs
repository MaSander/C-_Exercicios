using System;

namespace Senai.OO.Pizzaria.MVC.ViewModels
{
    /// <summary>
    /// Classe base que sera herdada pelas outras classes
    /// Definida como abstract para não ser instanciada
    /// </summary>
    public abstract class BaseViewModel
    {
        /// <summary>
        /// Id do objeto
        /// </summary>
        public int Id { get; set; }
        /// <summary>
        /// Nome do objeto-
        /// </summary>
        public string Nome { get; set; }
        /// <summary>
        /// Data de criaçao do objeto
        /// </summary>
        public DateTime DataCriacao { get; set; }
    }
}