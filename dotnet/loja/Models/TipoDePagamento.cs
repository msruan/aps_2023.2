using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;
namespace loja.Models {
    //[Table("TiposDePagamento")]
    [NotMapped]
    public class TipoDePagamento
{
    public virtual int TipoDePagamentoId { get; set; }
    public string NomeDoCobrado { get; set; }
    public string InformacoesAdicionais { get; set; }
}
}
