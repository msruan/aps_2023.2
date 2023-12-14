using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace ruan.Models {

    public class Categoria {

        [Display(Name="Código")]
        public int Id { get; set; }
        public string ?Nome {get; set; }
        public virtual ICollection<Produto>? Produtos {get; set;}
    }
}