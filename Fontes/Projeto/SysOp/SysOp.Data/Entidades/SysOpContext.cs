using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using SysOp.Data.Entidades.Mapping;

namespace SysOp.Data.Entidades
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

        public DbSet<AcessoEnt> Acessoes { get; set; }
        public DbSet<AcessoUsuarioEnt> AcessoUsuarios { get; set; }
        public DbSet<ArquivosOrdemServicoEnt> ArquivosOrdemServicoes { get; set; }
        public DbSet<Contato_PJEnt> Contato_PJ { get; set; }
        public DbSet<CotacaoEnt> Cotacaos { get; set; }
        public DbSet<DepartamentoEnt> Departamentoes { get; set; }
        public DbSet<EmailEnt> Emails { get; set; }
        public DbSet<EnderecoEnt> Enderecoes { get; set; }
        public DbSet<EntradaProdutoEnt> EntradaProdutoes { get; set; }
        public DbSet<EntradaProdutoNFEnt> EntradaProdutoNFs { get; set; }
        public DbSet<EquipeOrdemServicoEnt> EquipeOrdemServicoes { get; set; }
        public DbSet<FinalidadeEnt> Finalidades { get; set; }
        public DbSet<FormaPagamentoEnt> FormaPagamentoes { get; set; }
        public DbSet<FornecedorCotacaoEnt> FornecedorCotacaos { get; set; }
        public DbSet<FuncionarioEnt> Funcionarios { get; set; }
        public DbSet<HistoricoOrdemServicoEnt> HistoricoOrdemServicoes { get; set; }
        public DbSet<HistoricoStatusCotacaoEnt> HistoricoStatusCotacaos { get; set; }
        public DbSet<ItemEntradaEstoqueEnt> ItemEntradaEstoques { get; set; }
        public DbSet<ItemEstoqueEnt> ItemEstoques { get; set; }
        public DbSet<ItemPedidoCompraEnt> ItemPedidoCompras { get; set; }
        public DbSet<ItemPedidoCompraCotacaoEnt> ItemPedidoCompraCotacaos { get; set; }
        public DbSet<ItemProdutoNotaFiscalEnt> ItemProdutoNotaFiscals { get; set; }
        public DbSet<ItemReservaProdutoEnt> ItemReservaProdutoes { get; set; }
        public DbSet<ItemReservaVendaProdutoEnt> ItemReservaVendaProdutoes { get; set; }
        public DbSet<ItemRetornoCotacaoEnt> ItemRetornoCotacaos { get; set; }
        public DbSet<ItemSolicitacaoCompraEnt> ItemSolicitacaoCompras { get; set; }
        public DbSet<ItemSolicitacaoCompraCotacaoEnt> ItemSolicitacaoCompraCotacaos { get; set; }
        public DbSet<ItemTransferenciaEstoqueEnt> ItemTransferenciaEstoques { get; set; }
        public DbSet<ItemVendaEstoqueEnt> ItemVendaEstoques { get; set; }
        public DbSet<MarcaProdutoEnt> MarcaProdutoes { get; set; }
        public DbSet<NotaFiscalEnt> NotaFiscals { get; set; }
        public DbSet<OrdemServicoEnt> OrdemServicoes { get; set; }
        public DbSet<PagamentoOrdemServicoEnt> PagamentoOrdemServicoes { get; set; }
        public DbSet<PagamentoPedidoCompraEnt> PagamentoPedidoCompras { get; set; }
        public DbSet<PagamentoRetornoCotacaoEnt> PagamentoRetornoCotacaos { get; set; }
        public DbSet<PedidoCompraEnt> PedidoCompras { get; set; }
        public DbSet<PessoaEnt> Pessoas { get; set; }
        public DbSet<PessoaFisicaEnt> PessoaFisicas { get; set; }
        public DbSet<PessoaJuridicaEnt> PessoaJuridicas { get; set; }
        public DbSet<ProdutoEnt> Produtoes { get; set; }
        public DbSet<ProdutoCotacaoEnt> ProdutoCotacaos { get; set; }
        public DbSet<ProfissaoEnt> Profissaos { get; set; }
        public DbSet<ProfissaoFuncionarioEnt> ProfissaoFuncionarios { get; set; }
        public DbSet<ReservaEnt> Reservas { get; set; }
        public DbSet<SolicitacaoCompraEnt> SolicitacaoCompras { get; set; }
        public DbSet<SolicitacaoPedidoCompraEnt> SolicitacaoPedidoCompras { get; set; }
        public DbSet<StatusCotacaoEnt> StatusCotacaos { get; set; }
        public DbSet<StatusOrdemServicoEnt> StatusOrdemServicoes { get; set; }
        public DbSet<TabelaPrecoEnt> TabelaPrecoes { get; set; }
        public DbSet<TelefoneEnt> Telefones { get; set; }
        public DbSet<TipoProdutoEnt> TipoProdutoes { get; set; }
        public DbSet<TransferenciaEstoqueEnt> TransferenciaEstoques { get; set; }
        public DbSet<UnidadeEnt> Unidades { get; set; }
        public DbSet<UnidadeMedidaEnt> UnidadeMedidas { get; set; }
        public DbSet<UsuarioEnt> Usuarios { get; set; }
        public DbSet<VendaProdutoEnt> VendaProdutoes { get; set; }
        public DbSet<VendaProdutoNFEnt> VendaProdutoNFs { get; set; }

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
