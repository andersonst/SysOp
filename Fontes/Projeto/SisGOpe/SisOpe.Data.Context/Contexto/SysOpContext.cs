using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using SisOpe.Data.Mapping;
using SisOpe.Domain.Entidades;

namespace SisOpe.Data.Contexto
{
    public partial class SysOpContext : DbContext
    {
        static SysOpContext()
        {
            Database.SetInitializer<SysOpContext>(null);
        }

        public SysOpContext()
            : base("Name=SysOpContext")
        {
        }

        public DbSet<Acesso> Acessoes { get; set; }
        public DbSet<AcessoUsuario> AcessoUsuarios { get; set; }
        public DbSet<ArquivosOrdemServico> ArquivosOrdemServicoes { get; set; }
        public DbSet<Contato_PJ> Contato_PJ { get; set; }
        public DbSet<Cotacao> Cotacaos { get; set; }
        public DbSet<Departamento> Departamentoes { get; set; }
        public DbSet<Email> Emails { get; set; }
        public DbSet<Endereco> Enderecoes { get; set; }
        public DbSet<EntradaProduto> EntradaProdutoes { get; set; }
        public DbSet<EntradaProdutoNF> EntradaProdutoNFs { get; set; }
        public DbSet<EquipeOrdemServico> EquipeOrdemServicoes { get; set; }
        public DbSet<Finalidade> Finalidades { get; set; }
        public DbSet<FormaPagamento> FormaPagamentoes { get; set; }
        public DbSet<FornecedorCotacao> FornecedorCotacaos { get; set; }
        public DbSet<Funcionario> Funcionarios { get; set; }
        public DbSet<HistoricoOrdemServico> HistoricoOrdemServicoes { get; set; }
        public DbSet<HistoricoStatusCotacao> HistoricoStatusCotacaos { get; set; }
        public DbSet<ItemEntradaEstoque> ItemEntradaEstoques { get; set; }
        public DbSet<ItemEstoque> ItemEstoques { get; set; }
        public DbSet<ItemPedidoCompra> ItemPedidoCompras { get; set; }
        public DbSet<ItemPedidoCompraCotacao> ItemPedidoCompraCotacaos { get; set; }
        public DbSet<ItemProdutoNotaFiscal> ItemProdutoNotaFiscals { get; set; }
        public DbSet<ItemReservaProduto> ItemReservaProdutoes { get; set; }
        public DbSet<ItemReservaVendaProduto> ItemReservaVendaProdutoes { get; set; }
        public DbSet<ItemRetornoCotacao> ItemRetornoCotacaos { get; set; }
        public DbSet<ItemSolicitacaoCompra> ItemSolicitacaoCompras { get; set; }
        public DbSet<ItemSolicitacaoCompraCotacao> ItemSolicitacaoCompraCotacaos { get; set; }
        public DbSet<ItemTransferenciaEstoque> ItemTransferenciaEstoques { get; set; }
        public DbSet<ItemVendaEstoque> ItemVendaEstoques { get; set; }
        public DbSet<MarcaProduto> MarcaProdutoes { get; set; }
        public DbSet<NotaFiscal> NotaFiscals { get; set; }
        public DbSet<OrdemServico> OrdemServicoes { get; set; }
        public DbSet<PagamentoOrdemServico> PagamentoOrdemServicoes { get; set; }
        public DbSet<PagamentoPedidoCompra> PagamentoPedidoCompras { get; set; }
        public DbSet<PagamentoRetornoCotacao> PagamentoRetornoCotacaos { get; set; }
        public DbSet<PedidoCompra> PedidoCompras { get; set; }
        public DbSet<Pessoa> Pessoas { get; set; }
        public DbSet<PessoaFisica> PessoaFisicas { get; set; }
        public DbSet<PessoaJuridica> PessoaJuridicas { get; set; }
        public DbSet<Produto> Produtoes { get; set; }
        public DbSet<ProdutoCotacao> ProdutoCotacaos { get; set; }
        public DbSet<Profissao> Profissaos { get; set; }
        public DbSet<ProfissaoFuncionario> ProfissaoFuncionarios { get; set; }
        public DbSet<Reserva> Reservas { get; set; }
        public DbSet<SolicitacaoCompra> SolicitacaoCompras { get; set; }
        public DbSet<SolicitacaoPedidoCompra> SolicitacaoPedidoCompras { get; set; }
        public DbSet<StatusCotacao> StatusCotacaos { get; set; }
        public DbSet<StatusOrdemServico> StatusOrdemServicoes { get; set; }
        public DbSet<TabelaPreco> TabelaPrecoes { get; set; }
        public DbSet<Telefone> Telefones { get; set; }
        public DbSet<TipoProduto> TipoProdutoes { get; set; }
        public DbSet<TransferenciaEstoque> TransferenciaEstoques { get; set; }
        public DbSet<Unidade> Unidades { get; set; }
        public DbSet<UnidadeMedida> UnidadeMedidas { get; set; }
        public DbSet<Usuario> Usuarios { get; set; }
        public DbSet<VendaProduto> VendaProdutoes { get; set; }
        public DbSet<VendaProdutoNF> VendaProdutoNFs { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.Add(new AcessoMap());
            modelBuilder.Configurations.Add(new AcessoUsuarioMap());
            modelBuilder.Configurations.Add(new ArquivosOrdemServicoMap());
            modelBuilder.Configurations.Add(new Contato_PJMap());
            modelBuilder.Configurations.Add(new CotacaoMap());
            modelBuilder.Configurations.Add(new DepartamentoMap());
            modelBuilder.Configurations.Add(new EmailMap());
            modelBuilder.Configurations.Add(new EnderecoMap());
            modelBuilder.Configurations.Add(new EntradaProdutoMap());
            modelBuilder.Configurations.Add(new EntradaProdutoNFMap());
            modelBuilder.Configurations.Add(new EquipeOrdemServicoMap());
            modelBuilder.Configurations.Add(new FinalidadeMap());
            modelBuilder.Configurations.Add(new FormaPagamentoMap());
            modelBuilder.Configurations.Add(new FornecedorCotacaoMap());
            modelBuilder.Configurations.Add(new FuncionarioMap());
            modelBuilder.Configurations.Add(new HistoricoOrdemServicoMap());
            modelBuilder.Configurations.Add(new HistoricoStatusCotacaoMap());
            modelBuilder.Configurations.Add(new ItemEntradaEstoqueMap());
            modelBuilder.Configurations.Add(new ItemEstoqueMap());
            modelBuilder.Configurations.Add(new ItemPedidoCompraMap());
            modelBuilder.Configurations.Add(new ItemPedidoCompraCotacaoMap());
            modelBuilder.Configurations.Add(new ItemProdutoNotaFiscalMap());
            modelBuilder.Configurations.Add(new ItemReservaProdutoMap());
            modelBuilder.Configurations.Add(new ItemReservaVendaProdutoMap());
            modelBuilder.Configurations.Add(new ItemRetornoCotacaoMap());
            modelBuilder.Configurations.Add(new ItemSolicitacaoCompraMap());
            modelBuilder.Configurations.Add(new ItemSolicitacaoCompraCotacaoMap());
            modelBuilder.Configurations.Add(new ItemTransferenciaEstoqueMap());
            modelBuilder.Configurations.Add(new ItemVendaEstoqueMap());
            modelBuilder.Configurations.Add(new MarcaProdutoMap());
            modelBuilder.Configurations.Add(new NotaFiscalMap());
            modelBuilder.Configurations.Add(new OrdemServicoMap());
            modelBuilder.Configurations.Add(new PagamentoOrdemServicoMap());
            modelBuilder.Configurations.Add(new PagamentoPedidoCompraMap());
            modelBuilder.Configurations.Add(new PagamentoRetornoCotacaoMap());
            modelBuilder.Configurations.Add(new PedidoCompraMap());
            modelBuilder.Configurations.Add(new PessoaMap());
            modelBuilder.Configurations.Add(new PessoaFisicaMap());
            modelBuilder.Configurations.Add(new PessoaJuridicaMap());
            modelBuilder.Configurations.Add(new ProdutoMap());
            modelBuilder.Configurations.Add(new ProdutoCotacaoMap());
            modelBuilder.Configurations.Add(new ProfissaoMap());
            modelBuilder.Configurations.Add(new ProfissaoFuncionarioMap());
            modelBuilder.Configurations.Add(new ReservaMap());
            modelBuilder.Configurations.Add(new SolicitacaoCompraMap());
            modelBuilder.Configurations.Add(new SolicitacaoPedidoCompraMap());
            modelBuilder.Configurations.Add(new StatusCotacaoMap());
            modelBuilder.Configurations.Add(new StatusOrdemServicoMap());
            modelBuilder.Configurations.Add(new TabelaPrecoMap());
            modelBuilder.Configurations.Add(new TelefoneMap());
            modelBuilder.Configurations.Add(new TipoProdutoMap());
            modelBuilder.Configurations.Add(new TransferenciaEstoqueMap());
            modelBuilder.Configurations.Add(new UnidadeMap());
            modelBuilder.Configurations.Add(new UnidadeMedidaMap());
            modelBuilder.Configurations.Add(new UsuarioMap());
            modelBuilder.Configurations.Add(new VendaProdutoMap());
            modelBuilder.Configurations.Add(new VendaProdutoNFMap());
        }
    }
}
