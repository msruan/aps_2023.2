using System.ComponentModel.DataAnnotations;
namespace ruan.Models {

    public class Carrinho {
        [Display(Name="Código")]
        [Key]
        public int Id {get; set;}
        [Required]
        public int UsuarioId {get; set;}
        public virtual Usuario Usuario { get; set;}
        public virtual ICollection<Produto>? Produtos {get; set;}
    }
}