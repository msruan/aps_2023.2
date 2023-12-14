using System.ComponentModel.DataAnnotations;

namespace estoque.Models {

    public class Transportadora
{
    [Display(Name="Código Cliente")]

    public int TransportadoraId { get; set; }
    public string Nome { get; set; }
}
}