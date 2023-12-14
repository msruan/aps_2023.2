using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;
namespace estoque.Models {

    public class PagamentoComCartao : TipoDePagamento
{
    public string NumeroDoCartao { get; set; }
    public string Bandeira { get; set; }
}
}