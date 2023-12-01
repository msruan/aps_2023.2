using System.ComponentModel.DataAnnotations;
namespace secondapp.Models {

    public class Carrinho {
        [Display(Name="Código")]
        public int Id;
        [Display(Name="UsuárioID")]
        public int UsuarioId;
    }
}