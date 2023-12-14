using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;
namespace estoque.Models {

    public class PagamentoComCheque : TipoDePagamento
{
    public int Banco { get; set; }
    public string NomeDoBanco { get; set; }
}
}