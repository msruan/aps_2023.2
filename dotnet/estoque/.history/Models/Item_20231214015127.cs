using System.ComponentModel.DataAnnotations;

namespace estoque.Models {

    public class Item
{
    [Display(Name="Código Item")]
    public int ItemId { get; set; }
    public double Preco { get; set; }
    public int Percentual { get; set; }
    public int Quantidade { get; set; }
    [Display(Name="Código de Barras")]
    public int ProdutoId { get; set; }
    public Produto Produto { get; set; }
    [Display(Name="Código Cliente")]

    public int NotaDeVendaId { get; set; }
    public NotaDeVenda NotaDeVenda { get; set; }
}
}