using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace estoque.Models {

    public class NotaDeVenda
{
    [Display(Name="Nota Fiscal")]

    public int NotaDeVendaId { get; set; }
    public DateTime Data { get; set; }
    public bool Tipo { get; set; }
    [Display(Name="Código Cliente")]
    public int ClienteId { get; set; }
    public Cliente Cliente { get; set; }

    [Display(Name="Código Vendedor")]
    public int VendedorId { get; set; }
    public Vendedor Vendedor { get; set; }

    [Display(Name="Código Transportadora")]
    public int? TransportadoraId { get; set; }
    public Transportadora Transportadora { get; set; }

    public virtual ICollection<Item> Itens { get; set; } = new List<Item>();

    public virtual ICollection<Pagamento> Pagamentos { get; set; } = new List<Pagamento>();
}
}