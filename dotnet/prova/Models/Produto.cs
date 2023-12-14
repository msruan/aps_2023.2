namespace prova.Models
{
    public class Produto
{
    public int ProdutoId { get; set; }
    public string Nome { get; set; }
    public string Descricao { get; set; }
    public int Quantidade { get; set; }
    public double Preco { get; set; }

    public int MarcaId { get; set; }
    public Marca Marca { get; set; }

    public List<Item> Itens { get; set; }
}
}