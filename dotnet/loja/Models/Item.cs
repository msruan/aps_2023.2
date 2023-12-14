namespace loja.Models {
    public class Item
{
    public int ItemId { get; set; }
    public double Preco { get; set; }
    public int Percentual { get; set; }
    public int Quantidade { get; set; }

    public int ProdutoId { get; set; }
    public Produto Produto { get; set; }

    public int NotaDeVendaId { get; set; }
    public NotaDeVenda NotaDeVenda { get; set; }
}
}