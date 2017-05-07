using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using SisOpe.Data.Context.Models.Mapping;

namespace SisOpe.Data.Context.Models
{
    public partial class SysopContext : DbContext
    {
        static SysopContext()
        {
            Database.SetInitializer<SysopContext>(null);
        }

        public SysopContext()
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
        public DbSet<ProdutocCotacao> produtocotacaos { get; set; }
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
        public DbSet<Solicitacaocompra> solicitacaocompras { get; set; }
        public DbSet<Solicitacaopedidocompra> solicitacaopedidocompras { get; set; }
        public DbSet<StatusCotacao> statuscotacaos { get; set; }
        public DbSet<StatusOrdemServico> statusordemservicoes { get; set; }
        public DbSet<sysdiagram> sysdiagrams { get; set; }
        public DbSet<Tabelapreco> tabelaprecoes { get; set; }
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
            modelBuilder.Configurations.Add(new acessoMap());
            modelBuilder.Configurations.Add(new acessousuarioMap());
            modelBuilder.Configurations.Add(new arquivosordemservicoMap());
            modelBuilder.Configurations.Add(new bancoMap());
            modelBuilder.Configurations.Add(new cfopMap());
            modelBuilder.Configurations.Add(new clienteMap());
            modelBuilder.Configurations.Add(new contatoMap());
            modelBuilder.Configurations.Add(new contato_emailMap());
            modelBuilder.Configurations.Add(new contato_pjMap());
            modelBuilder.Configurations.Add(new contato_telefoneMap());
            modelBuilder.Configurations.Add(new cotacaoMap());
            modelBuilder.Configurations.Add(new departamentoMap());
            modelBuilder.Configurations.Add(new ecf_caixaMap());
            modelBuilder.Configurations.Add(new ecf_cheque_clienteMap());
            modelBuilder.Configurations.Add(new ecf_configuracaoMap());
            modelBuilder.Configurations.Add(new ecf_contadorMap());
            modelBuilder.Configurations.Add(new ecf_dav_cabecalhoMap());
            modelBuilder.Configurations.Add(new ecf_dav_detalheMap());
            modelBuilder.Configurations.Add(new ecf_documentos_emitidosMap());
            modelBuilder.Configurations.Add(new ecf_empresaMap());
            modelBuilder.Configurations.Add(new ecf_funcionarioMap());
            modelBuilder.Configurations.Add(new ecf_impressoraMap());
            modelBuilder.Configurations.Add(new ecf_movimentoMap());
            modelBuilder.Configurations.Add(new ecf_operadorMap());
            modelBuilder.Configurations.Add(new ecf_posicao_componentesMap());
            modelBuilder.Configurations.Add(new ecf_pre_venda_cabecalhoMap());
            modelBuilder.Configurations.Add(new ecf_pre_venda_detalheMap());
            modelBuilder.Configurations.Add(new ecf_recebimento_nao_fiscalMap());
            modelBuilder.Configurations.Add(new ecf_resolucaoMap());
            modelBuilder.Configurations.Add(new ecf_sangriaMap());
            modelBuilder.Configurations.Add(new ecf_suprimentoMap());
            modelBuilder.Configurations.Add(new ecf_tipo_pagamentoMap());
            modelBuilder.Configurations.Add(new ecf_total_tipo_pgtoMap());
            modelBuilder.Configurations.Add(new ecf_tributo_produtoMap());
            modelBuilder.Configurations.Add(new ecf_turnoMap());
            modelBuilder.Configurations.Add(new ecf_venda_cabecalhoMap());
            modelBuilder.Configurations.Add(new ecf_venda_detalheMap());
            modelBuilder.Configurations.Add(new emailMap());
            modelBuilder.Configurations.Add(new enderecoMap());
            modelBuilder.Configurations.Add(new endereco_2Map());
            modelBuilder.Configurations.Add(new entradaprodutoMap());
            modelBuilder.Configurations.Add(new entradaprodutonfMap());
            modelBuilder.Configurations.Add(new equipeordemservicoMap());
            modelBuilder.Configurations.Add(new ficha_tecnicaMap());
            modelBuilder.Configurations.Add(new finalidadeMap());
            modelBuilder.Configurations.Add(new formapagamentoMap());
            modelBuilder.Configurations.Add(new fornecedorcotacaoMap());
            modelBuilder.Configurations.Add(new funcionarioMap());
            modelBuilder.Configurations.Add(new historicoordemservicoMap());
            modelBuilder.Configurations.Add(new historicostatuscotacaoMap());
            modelBuilder.Configurations.Add(new itementradaestoqueMap());
            modelBuilder.Configurations.Add(new itemestoqueMap());
            modelBuilder.Configurations.Add(new itempedidocompraMap());
            modelBuilder.Configurations.Add(new itempedidocompracotacaoMap());
            modelBuilder.Configurations.Add(new itemprodutonotafiscalMap());
            modelBuilder.Configurations.Add(new itemretornocotacaoMap());
            modelBuilder.Configurations.Add(new itemsolicitacaocompraMap());
            modelBuilder.Configurations.Add(new itemsolicitacaocompracotacaoMap());
            modelBuilder.Configurations.Add(new itemtransferenciaestoqueMap());
            modelBuilder.Configurations.Add(new itemvendaestoqueMap());
            modelBuilder.Configurations.Add(new marcaprodutoMap());
            modelBuilder.Configurations.Add(new nf2_cabecalhoMap());
            modelBuilder.Configurations.Add(new nf2_detalheMap());
            modelBuilder.Configurations.Add(new notafiscalMap());
            modelBuilder.Configurations.Add(new ordemservicoMap());
            modelBuilder.Configurations.Add(new pagamentoordemservicoMap());
            modelBuilder.Configurations.Add(new pagamentopedidocompraMap());
            modelBuilder.Configurations.Add(new pagamentoretornocotacaoMap());
            modelBuilder.Configurations.Add(new pedidocompraMap());
            modelBuilder.Configurations.Add(new pessoaMap());
            modelBuilder.Configurations.Add(new pessoafisicaMap());
            modelBuilder.Configurations.Add(new pessoajuridicaMap());
            modelBuilder.Configurations.Add(new produtoMap());
            modelBuilder.Configurations.Add(new produto_2Map());
            modelBuilder.Configurations.Add(new produto_promocaoMap());
            modelBuilder.Configurations.Add(new produtocotacaoMap());
            modelBuilder.Configurations.Add(new profissaoMap());
            modelBuilder.Configurations.Add(new profissaofuncionarioMap());
            modelBuilder.Configurations.Add(new r02Map());
            modelBuilder.Configurations.Add(new r03Map());
            modelBuilder.Configurations.Add(new r06Map());
            modelBuilder.Configurations.Add(new r07Map());
            modelBuilder.Configurations.Add(new reservaMap());
            modelBuilder.Configurations.Add(new sintegra_60aMap());
            modelBuilder.Configurations.Add(new sintegra_60mMap());
            modelBuilder.Configurations.Add(new situacao_cliMap());
            modelBuilder.Configurations.Add(new solicitacaocompraMap());
            modelBuilder.Configurations.Add(new solicitacaopedidocompraMap());
            modelBuilder.Configurations.Add(new statuscotacaoMap());
            modelBuilder.Configurations.Add(new statusordemservicoMap());
            modelBuilder.Configurations.Add(new sysdiagramMap());
            modelBuilder.Configurations.Add(new tabelaprecoMap());
            modelBuilder.Configurations.Add(new telefoneMap());
            modelBuilder.Configurations.Add(new tipo_emailMap());
            modelBuilder.Configurations.Add(new tipo_telefoneMap());
            modelBuilder.Configurations.Add(new tipoprodutoMap());
            modelBuilder.Configurations.Add(new transferenciaestoqueMap());
            modelBuilder.Configurations.Add(new unidadeMap());
            modelBuilder.Configurations.Add(new unidade_produtoMap());
            modelBuilder.Configurations.Add(new unidademedidaMap());
            modelBuilder.Configurations.Add(new usuarioMap());
            modelBuilder.Configurations.Add(new vendaprodutoMap());
            modelBuilder.Configurations.Add(new vendaprodutonfMap());
        }
    }
}
