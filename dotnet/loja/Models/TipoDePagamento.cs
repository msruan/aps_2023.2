namespace loja.Models {
    //[Table("TiposDePagamento")]
    public class TipoDePagamento
{
    public int TipoDePagamentoId { get; set; }
    public string NomeDoCobrado { get; set; }
    public string InformacoesAdicionais { get; set; }
}
}
