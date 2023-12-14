using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace ruan.Models {

    public class Carrinho {
        [Display(Name="Código")]
        public int Id {get; set;}
        [ForeignKey("Usuario")]
        public virtual int UsuarioId {get; set;}
        public virtual Usuario? Usuario { get; set;}
        public virtual ICollection<Produto>? Produtos {get; set;}
    }
}
