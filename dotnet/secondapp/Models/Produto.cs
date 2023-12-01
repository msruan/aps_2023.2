using System.ComponentModel.DataAnnotations;

namespace secondapp.Models {
    public class Produto {
       [Display(Name="Código")]
       public int Id { get; set; }
       public string ?Descricao;
       public string ?PathImagem;
       public decimal Preco;
       public int Quantidade;
       public int CategoriaId;
    }
}