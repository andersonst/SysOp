using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using SisOpe.Data.Context.Models.Mapping;
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
            : base("Name=SysOpConnection")
        {
        }

        public DbSet<Acesso> acessoes { get; set; }
        public DbSet<AcessoUsuario> acessousuarios { get; set; }
        public DbSet<ArquivosOrdemServico> arquivosordemservicoes { get; set; }
        public DbSet<Banco> bancoes { get; set; }
        public DbSet<Cfop> cfops { get; set; }
        public DbSet<Cliente> clientes { get; set; }
        public DbSet<Contato> contatoes { get; set; }
        public DbSet<Contato_email> contato_email { get; set; }
        public DbSet<Contato_PJ> contato_pj { get; set; }
        public DbSet<Contato_Telefone> contato_telefone { get; set; }
        public DbSet<Cotacao> cotacaos { get; set; }
        public DbSet<Departamento> departamentoes { get; set; }
        public DbSet<Ecf_Caixa> ecf_caixa { get; set; }
        public DbSet<Ecf_Cheque_Cliente> ecf_cheque_cliente { get; set; }
        public DbSet<Ecf_Configuracao> ecf_configuracao { get; set; }
        public DbSet<Ecf_Contador> ecf_contador { get; set; }
        public DbSet<Ecf_Dav_Cabecalho> ecf_dav_cabecalho { get; set; }
        public DbSet<Ecf_Dav_Detalhe> ecf_dav_detalhe { get; set; }
        public DbSet<Ecf_Documentos_Emitidos> ecf_documentos_emitidos { get; set; }
        public DbSet<Ecf_Empresa> ecf_empresa { get; set; }
        public DbSet<Ecf_Funcionario> ecf_funcionario { get; set; }
        public DbSet<Ecf_Impressora> ecf_impressora { get; set; }
        public DbSet<Ecf_Movimento> ecf_movimento { get; set; }
        public DbSet<Ecf_Operador> ecf_operador { get; set; }
        public DbSet<Ecf_Posicao_Componentes> ecf_posicao_componentes { get; set; }
        public DbSet<Ecf_Pre_Venda_Cabecalho> ecf_pre_venda_cabecalho { get; set; }
        public DbSet<Ecf_Pre_Venda_Detalhe> ecf_pre_venda_detalhe { get; set; }
        public DbSet<Ecf_Recebimento_Nao_Fiscal> ecf_recebimento_nao_fiscal { get; set; }
        public DbSet<Ecf_Resolucao> ecf_resolucao { get; set; }
        public DbSet<Ecf_Sangria> ecf_sangria { get; set; }
        public DbSet<Ecf_Suprimento> ecf_suprimento { get; set; }
        public DbSet<Ecf_Tipo_Pagamento> ecf_tipo_pagamento { get; set; }
        public DbSet<Ecf_Total_Tipo_Pgto> ecf_total_tipo_pgto { get; set; }
        public DbSet<Ecf_Tributo_Produto> ecf_tributo_produto { get; set; }
        public DbSet<Ecf_Turno> ecf_turno { get; set; }
        public DbSet<Ecf_Venda_Cabecalho> ecf_venda_cabecalho { get; set; }
        public DbSet<Ecf_Venda_Detalhe> ecf_venda_detalhe { get; set; }
        public DbSet<Email> emails { get; set; }
        public DbSet<Endereco> enderecoes { get; set; }
        public DbSet<Endereco_2> endereco_2 { get; set; }
        public DbSet<EntradaProduto> entradaprodutoes { get; set; }
        public DbSet<EntradaProdutoNF> entradaprodutonfs { get; set; }
        public DbSet<EquipeOrdemServico> equipeordemservicoes { get; set; }
        public DbSet<Ficha_Tecnica> ficha_tecnica { get; set; }
        public DbSet<Finalidade> finalidades { get; set; }
        public DbSet<FormaPagamento> formapagamentoes { get; set; }
        public DbSet<FornecedorCotacao> fornecedorcotacaos { get; set; }
        public DbSet<Funcionario> funcionarios { get; set; }
        public DbSet<HistoricoOrdemServico> historicoordemservicoes { get; set; }
        public DbSet<HistoricoStatusCotacao> historicostatuscotacaos { get; set; }
        public DbSet<ItemEntradaEstoque> itementradaestoques { get; set; }
        public DbSet<ItemEstoque> itemestoques { get; set; }
        public DbSet<ItemPedidoCompra> itempedidocompras { get; set; }
        public DbSet<ItemPedidoCompraCotacao> itempedidocompracotacaos { get; set; }
        public DbSet<ItemProdutoNotaFiscal> itemprodutonotafiscals { get; set; }
        public DbSet<ItemRetornoCotacao> itemretornocotacaos { get; set; }
        public DbSet<ItemSolicitacaoCompra> itemsolicitacaocompras { get; set; }
        public DbSet<ItemSolicitacaoCompraCotacao> itemsolicitacaocompracotacaos { get; set; }
        public DbSet<ItemTransferenciaEstoque> itemtransferenciaestoques { get; set; }
        public DbSet<ItemVendaEstoque> itemvendaestoques { get; set; }
        public DbSet<MarcaProduto> marcaprodutoes { get; set; }
        public DbSet<Nf2_Cabecalho> nf2_cabecalho { get; set; }
        public DbSet<Nf2_Detalhe> nf2_detalhe { get; set; }
        public DbSet<NotaFiscal> notafiscals { get; set; }
        public DbSet<OrdemServico> ordemservicoes { get; set; }
        public DbSet<PagamentoOrdemServico> pagamentoordemservicoes { get; set; }
        public DbSet<PagamentoPedidoCompra> pagamentopedidocompras { get; set; }
        public DbSet<PagamentoRetornoCotacao> pagamentoretornocotacaos { get; set; }
        public DbSet<PedidoCompra> pedidocompras { get; set; }
        public DbSet<Pessoa> pessoas { get; set; }
        public DbSet<PessoaFisica> pessoafisicas { get; set; }
        public DbSet<PessoaJuridica> pessoajuridicas { get; set; }
        public DbSet<Produto> produtoes { get; set; }
        public DbSet<Produto_2> produto_2 { get; set; }
        public DbSet<Produto_Promocao> produto_promocao { get; set; }
        public DbSet<ProdutoCotacao> produtocotacaos { get; set; }
        public DbSet<Profissao> profissaos { get; set; }
        public DbSet<ProfissaoFuncionario> profissaofuncionarios { get; set; }
        public DbSet<R02> r02 { get; set; }
        public DbSet<R03> r03 { get; set; }
        public DbSet<R06> r06 { get; set; }
        public DbSet<R07> r07 { get; set; }
        public DbSet<Reserva> reservas { get; set; }
        public DbSet<Sintegra_60a> sintegra_60a { get; set; }
        public DbSet<Sintegra_60m> sintegra_60m { get; set; }
        public DbSet<Situacao_cli> situacao_cli { get; set; }
        public DbSet<SolicitacaoCompra> solicitacaocompras { get; set; }
        public DbSet<SolicitacaoPedidoCompra> solicitacaopedidocompras { get; set; }
        public DbSet<StatusCotacao> statuscotacaos { get; set; }
        public DbSet<StatusOrdemServico> statusordemservicoes { get; set; }
       // public DbSet<sysdiagram> sysdiagrams { get; set; }
        public DbSet<TabelaPreco> tabelaprecoes { get; set; }
        public DbSet<Telefone> telefones { get; set; }
        public DbSet<Tipo_Email> tipo_email { get; set; }
        public DbSet<Tipo_Telefone> tipo_telefone { get; set; }
        public DbSet<TipoProduto> tipoprodutoes { get; set; }
        public DbSet<TransferenciaEstoque> transferenciaestoques { get; set; }
        public DbSet<Unidade> unidades { get; set; }
        public DbSet<Unidade_Produto> unidade_produto { get; set; }
        public DbSet<UnidadeMedida> unidademedidas { get; set; }
        public DbSet<Usuario> usuarios { get; set; }
        public DbSet<VendaProduto> vendaprodutoes { get; set; }
        public DbSet<VendaProdutoNF> vendaprodutonfs { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.Add(new AcessoMap());
            modelBuilder.Configurations.Add(new AcessoUsuarioMap());
            modelBuilder.Configurations.Add(new ArquivosOrdemServicoMap());
            modelBuilder.Configurations.Add(new BancoMap());
            modelBuilder.Configurations.Add(new CfopMap());
            modelBuilder.Configurations.Add(new ClienteMap());
            modelBuilder.Configurations.Add(new ContatoMap());
            modelBuilder.Configurations.Add(new Contato_EmailMap());
            modelBuilder.Configurations.Add(new Contato_PJMap());
            modelBuilder.Configurations.Add(new Contato_TelefoneMap());
            modelBuilder.Configurations.Add(new CotacaoMap());
            modelBuilder.Configurations.Add(new DepartamentoMap());
            modelBuilder.Configurations.Add(new Ecf_CaixaMap());
            modelBuilder.Configurations.Add(new Ecf_Cheque_ClienteMap());
            modelBuilder.Configurations.Add(new Ecf_ConfiguracaoMap());
            modelBuilder.Configurations.Add(new Ecf_ContadorMap());
            modelBuilder.Configurations.Add(new Ecf_Dav_CabecalhoMap());
            modelBuilder.Configurations.Add(new Ecf_Dav_DetalheMap());
            modelBuilder.Configurations.Add(new Ecf_Documentos_EmitidosMap());
            modelBuilder.Configurations.Add(new Ecf_EmpresaMap());
            modelBuilder.Configurations.Add(new Ecf_FuncionarioMap());
            modelBuilder.Configurations.Add(new Ecf_ImpressoraMap());
            modelBuilder.Configurations.Add(new Ecf_MovimentoMap());
            modelBuilder.Configurations.Add(new Ecf_OperadorMap());
            modelBuilder.Configurations.Add(new Ecf_Posicao_ComponentesMap());
            modelBuilder.Configurations.Add(new Ecf_Pre_Venda_CabecalhoMap());
            modelBuilder.Configurations.Add(new Ecf_Pre_Venda_DetalheMap());
            modelBuilder.Configurations.Add(new Ecf_Recebimento_Nao_FiscalMap());
            modelBuilder.Configurations.Add(new Ecf_ResolucaoMap());
            modelBuilder.Configurations.Add(new Ecf_SangriaMap());
            modelBuilder.Configurations.Add(new Ecf_SuprimentoMap());
            modelBuilder.Configurations.Add(new Ecf_Tipo_PagamentoMap());
            modelBuilder.Configurations.Add(new Ecf_Total_Tipo_PgtoMap());
            modelBuilder.Configurations.Add(new Ecf_Tributo_ProdutoMap());
            modelBuilder.Configurations.Add(new Ecf_TurnoMap());
            modelBuilder.Configurations.Add(new Ecf_Venda_CabecalhoMap());
            modelBuilder.Configurations.Add(new Ecf_Venda_DetalheMap());
            modelBuilder.Configurations.Add(new EmailMap());
            modelBuilder.Configurations.Add(new EnderecoMap());
            modelBuilder.Configurations.Add(new Endereco_2Map());
            modelBuilder.Configurations.Add(new EntradaProdutoMap());
            modelBuilder.Configurations.Add(new EntradaProdutoNFMap());
            modelBuilder.Configurations.Add(new EquipeOrdemServicoMap());
            modelBuilder.Configurations.Add(new Ficha_TecnicaMap());
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
            modelBuilder.Configurations.Add(new ItemRetornoCotacaoMap());
            modelBuilder.Configurations.Add(new ItemSolicitacaoCompraMap());
            modelBuilder.Configurations.Add(new ItemSolicitacaoCompraCotacaoMap());
            modelBuilder.Configurations.Add(new ItemTransferenciaEstoqueMap());
            modelBuilder.Configurations.Add(new ItemVendaEstoqueMap());
            modelBuilder.Configurations.Add(new MarcaProdutoMap());
            modelBuilder.Configurations.Add(new Nf2_CabecalhoMap());
            modelBuilder.Configurations.Add(new Nf2_DetalheMap());
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
            modelBuilder.Configurations.Add(new Produto_2Map());
            modelBuilder.Configurations.Add(new Produto_PromocaoMap());
            modelBuilder.Configurations.Add(new ProdutoCotacaoMap());
            modelBuilder.Configurations.Add(new ProfissaoMap());
            modelBuilder.Configurations.Add(new ProfissaoFuncionarioMap());
            modelBuilder.Configurations.Add(new R02Map());
            modelBuilder.Configurations.Add(new R03Map());
            modelBuilder.Configurations.Add(new R06Map());
            modelBuilder.Configurations.Add(new R07Map());
            modelBuilder.Configurations.Add(new ReservaMap());
            modelBuilder.Configurations.Add(new Sintegra_60aMap());
            modelBuilder.Configurations.Add(new Sintegra_60mMap());
            modelBuilder.Configurations.Add(new Situacao_CliMap());
            modelBuilder.Configurations.Add(new SolicitacaoCompraMap());
            modelBuilder.Configurations.Add(new SolicitacaoPedidoCompraMap());
            modelBuilder.Configurations.Add(new StatusCotacaoMap());
            modelBuilder.Configurations.Add(new StatusOrdemServicoMap());
            modelBuilder.Configurations.Add(new sysdiagramMap());
            modelBuilder.Configurations.Add(new TabelaPrecoMap());
            modelBuilder.Configurations.Add(new TelefoneMap());
            modelBuilder.Configurations.Add(new Tipo_EmailMap());
            modelBuilder.Configurations.Add(new Tipo_TelefoneMap());
            modelBuilder.Configurations.Add(new TipoProdutoMap());
            modelBuilder.Configurations.Add(new TransferenciaEstoqueMap());
            modelBuilder.Configurations.Add(new UnidadeMap());
            modelBuilder.Configurations.Add(new Unidade_ProdutoMap());
            modelBuilder.Configurations.Add(new UnidadeMedidaMap());
            modelBuilder.Configurations.Add(new UsuarioMap());
            modelBuilder.Configurations.Add(new VendaProdutoMap());
            modelBuilder.Configurations.Add(new VendaProdutoNFMap());
        }
    }
}
