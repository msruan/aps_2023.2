using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;
namespace estoque.Models {

    [NotMapped]
    public class TipoDePagamento
{
    public virtual int TipoDePagamentoId { get; set; }
    public string NomeDoCobrado { get; set; }
    public string InformacoesAdicionais { get; set; }
}
}
