namespace prova.Models {

    public class Cliente {
        /*// Marca.cs
public class Marca
{
    public int MarcaId { get; set; }
    public string Nome { get; set; }
    public string Descricao { get; set; }
}

// Cliente.cs
public class Cliente
{
    public int ClienteId { get; set; }
    public string Nome { get; set; }
}

// Produto.cs
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

// Transportadora.cs
public class Transportadora
{
    public int TransportadoraId { get; set; }
    public string Nome { get; set; }
}

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

// PagamentoComCartao.cs
public class PagamentoComCartao : TipoDePagamento
{
    public string NumeroDoCartao { get; set; }
    public string Bandeira { get; set; }
}

// PagamentoComCheque.cs
public class PagamentoComCheque : TipoDePagamento
{
    public int Banco { get; set; }
    public string NomeDoBanco { get; set; }
}

// TipoDePagamento.cs
public class TipoDePagamento
{
    public int TipoDePagamentoId { get; set; }
    public string NomeDoCobrado { get; set; }
    public string InformacoesAdicionais { get; set; }
}

// Vendedor.cs
public class Vendedor
{
    public int VendedorId { get; set; }
    public string Nome { get; set; }
}

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