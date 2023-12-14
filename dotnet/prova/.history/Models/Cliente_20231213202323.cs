namespace prova.Models {

    public class Cliente {
        public int ClienteId { get; set; }
        public string Nome { get; set; }
        /*// Marca.cs



// Produto.cs


// NotaDeVenda.cs
public class NotaDeVenda
{
    public int NotaDeVendaId { get; set; }
    public DateTime Data { get; set; }
    public bool Tipo { get; set; }

    public int ClienteId { get; set; }
    public Cliente Cliente { get; set; }

    public int VendedorId { get; set; }
    public Vendedor Vendedor { get; set; }

    public int? TransportadoraId { get; set; }
    public Transportadora Transportadora { get; set; }

    public List<Item> Itens { get; set; }

    public List<Pagamento> Pagamentos { get; set; }
}

// Item.cs

---------------------------------------------------------------------------

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
*/
    }
}