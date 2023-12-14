namespace estoque.Models {

    public class Marca
    /*// Marca.c


// Cliente.cs, Vendedor.cs, Transportadora.cs permanecem inalterados

// Pagamento.cs
public class Pagamento
{
    public int PagamentoId { get; set; }
    public DateTime DataLimite { get; set; }
    public double Valor { get; set; }
    public bool Pago { get; set; }

    public int NotaDeVendaId { get; set; }
    public NotaDeVenda NotaDeVenda { get; set; }

    public int TipoDePagamentoId { get; set; }
    public TipoDePagamento TipoDePagamento { get; set; }
}

// PagamentoComCartao.cs, PagamentoComCheque.cs, TipoDePagamento.cs permanecem inalterados
*/
{
    public int MarcaId { get; set; }
    public string Nome { get; set; }
    public string Descricao { get; set; }
    
    public virtual ICollection<Produto> Produtos { get; set; } = new List<Produto>();
}
}