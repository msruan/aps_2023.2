using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace estoque.Models {

    public class NotaDeVenda
{
    public int NotaDeVendaId { get; set; }
    public DateTime Data { get; set; }
    public bool Tipo { get; set; }

    public int ClienteId { get; set; }
    public Cliente Cliente { get; set; }

    public int VendedorId { get; set; }
    public Vendedor Vendedor { get; set; }

    public int? TransportadoraId { get; set; }
    public Transportadora Transportadora { get; set; }

    public virtual ICollection<Item> Itens { get; set; } = new List<Item>();

    public virtual ICollection<Pagamento> Pagamentos { get; set; } = new List<Pagamento>();
}
}