using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ruan.Models {
    public class Produto {
       [Display(Name="Código")]
       public int Id { get; set; }
       public string ?Descricao;
       public string ?PathImagem;
       public decimal Preco;
       public int Quantidade;
       public virtual Categoria? Categoria {get; set;}
    }
}