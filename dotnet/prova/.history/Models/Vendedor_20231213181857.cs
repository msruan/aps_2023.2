namespace prova.Models
{
        // ApplicationDbContext.cs
public class ApplicationDbContext : DbContext
{
    public DbSet<Marca> Marcas { get; set; }
    public DbSet<Cliente> Clientes { get; set; }
    public DbSet<Produto> Produtos { get; set; }
    public DbSet<NotaDeVenda> NotasDeVenda { get; set; }
    public DbSet<Item> Itens { get; set; }
    public DbSet<Transportadora> Transportadoras { get; set; }
    public DbSet<Pagamento> Pagamentos { get; set; }
    public DbSet<PagamentoComCartao> PagamentosComCartao { get; set; }
    public DbSet<PagamentoComCheque> PagamentosComCheque { get; set; }
    public DbSet<TipoDePagamento> TiposDePagamento { get; set; }
    public DbSet<Vendedor> Vendedores { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseMySql("sua-string-de-conexao-aqui");
    }
}

}