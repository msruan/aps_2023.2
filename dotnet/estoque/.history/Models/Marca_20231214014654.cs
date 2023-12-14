using System.ComponentModel.DataAnnotations;
namespace estoque.Models {

    public class Marca
    
{
    [DisplayName=("Código da Marca")]
    public int MarcaId { get; set; }
    public string Nome { get; set; }
    public string Descricao { get; set; }
    
    public virtual ICollection<Produto> Produtos { get; set; } = new List<Produto>();
}
}