using System.ComponentModel.DataAnnotations;

namespace estoque.Models {

    public class Transportadora
{
    [Display(Name="Código Transportadora")]

    public int TransportadoraId { get; set; }
    public string Nome { get; set; }
}
}