using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using SisOpe.Data.Context.Models.Mapping;

namespace SisOpe.Data.Context.Models
{
    public partial class sysopContext : DbContext
    {
        static sysopContext()
        {
            Database.SetInitializer<sysopContext>(null);
        }

        public sysopContext()
            : base("Name=sysopContext")
        {
        }

        public DbSet<acesso> acessoes { get; set; }
        public DbSet<acessousuario> acessousuarios { get; set; }
        public DbSet<arquivosordemservico> arquivosordemservicoes { get; set; }
        public DbSet<banco> bancoes { get; set; }
        public DbSet<cfop> cfops { get; set; }
        public DbSet<cliente> clientes { get; set; }
        public DbSet<contato> contatoes { get; set; }
        public DbSet<contato_email> contato_email { get; set; }
        public DbSet<contato_pj> contato_pj { get; set; }
        public DbSet<contato_telefone> contato_telefone { get; set; }
        public DbSet<cotacao> cotacaos { get; set; }
        public DbSet<departamento> departamentoes { get; set; }
        public DbSet<ecf_caixa> ecf_caixa { get; set; }
        public DbSet<ecf_cheque_cliente> ecf_cheque_cliente { get; set; }
        public DbSet<ecf_configuracao> ecf_configuracao { get; set; }
        public DbSet<ecf_contador> ecf_contador { get; set; }
        public DbSet<ecf_dav_cabecalho> ecf_dav_cabecalho { get; set; }
        public DbSet<ecf_dav_detalhe> ecf_dav_detalhe { get; set; }
        public DbSet<ecf_documentos_emitidos> ecf_documentos_emitidos { get; set; }
        public DbSet<ecf_empresa> ecf_empresa { get; set; }
        public DbSet<ecf_funcionario> ecf_funcionario { get; set; }
        public DbSet<ecf_impressora> ecf_impressora { get; set; }
        public DbSet<ecf_movimento> ecf_movimento { get; set; }
        public DbSet<ecf_operador> ecf_operador { get; set; }
        public DbSet<ecf_posicao_componentes> ecf_posicao_componentes { get; set; }
        public DbSet<ecf_pre_venda_cabecalho> ecf_pre_venda_cabecalho { get; set; }
        public DbSet<ecf_pre_venda_detalhe> ecf_pre_venda_detalhe { get; set; }
        public DbSet<ecf_recebimento_nao_fiscal> ecf_recebimento_nao_fiscal { get; set; }
        public DbSet<ecf_resolucao> ecf_resolucao { get; set; }
        public DbSet<ecf_sangria> ecf_sangria { get; set; }
        public DbSet<ecf_suprimento> ecf_suprimento { get; set; }
        public DbSet<ecf_tipo_pagamento> ecf_tipo_pagamento { get; set; }
        public DbSet<ecf_total_tipo_pgto> ecf_total_tipo_pgto { get; set; }
        public DbSet<ecf_tributo_produto> ecf_tributo_produto { get; set; }
        public DbSet<ecf_turno> ecf_turno { get; set; }
        public DbSet<ecf_venda_cabecalho> ecf_venda_cabecalho { get; set; }
        public DbSet<ecf_venda_detalhe> ecf_venda_detalhe { get; set; }
        public DbSet<email> emails { get; set; }
        public DbSet<endereco> enderecoes { get; set; }
        public DbSet<endereco_2> endereco_2 { get; set; }
        public DbSet<entradaproduto> entradaprodutoes { get; set; }
        public DbSet<entradaprodutonf> entradaprodutonfs { get; set; }
        public DbSet<equipeordemservico> equipeordemservicoes { get; set; }
        public DbSet<ficha_tecnica> ficha_tecnica { get; set; }
        public DbSet<finalidade> finalidades { get; set; }
        public DbSet<formapagamento> formapagamentoes { get; set; }
        public DbSet<fornecedorcotacao> fornecedorcotacaos { get; set; }
        public DbSet<funcionario> funcionarios { get; set; }
        public DbSet<historicoordemservico> historicoordemservicoes { get; set; }
        public DbSet<historicostatuscotacao> historicostatuscotacaos { get; set; }
        public DbSet<itementradaestoque> itementradaestoques { get; set; }
        public DbSet<itemestoque> itemestoques { get; set; }
        public DbSet<itempedidocompra> itempedidocompras { get; set; }
        public DbSet<itempedidocompracotacao> itempedidocompracotacaos { get; set; }
        public DbSet<itemprodutonotafiscal> itemprodutonotafiscals { get; set; }
        public DbSet<itemretornocotacao> itemretornocotacaos { get; set; }
        public DbSet<itemsolicitacaocompra> itemsolicitacaocompras { get; set; }
        public DbSet<itemsolicitacaocompracotacao> itemsolicitacaocompracotacaos { get; set; }
        public DbSet<itemtransferenciaestoque> itemtransferenciaestoques { get; set; }
        public DbSet<itemvendaestoque> itemvendaestoques { get; set; }
        public DbSet<marcaproduto> marcaprodutoes { get; set; }
        public DbSet<nf2_cabecalho> nf2_cabecalho { get; set; }
        public DbSet<nf2_detalhe> nf2_detalhe { get; set; }
        public DbSet<notafiscal> notafiscals { get; set; }
        public DbSet<ordemservico> ordemservicoes { get; set; }
        public DbSet<pagamentoordemservico> pagamentoordemservicoes { get; set; }
        public DbSet<pagamentopedidocompra> pagamentopedidocompras { get; set; }
        public DbSet<pagamentoretornocotacao> pagamentoretornocotacaos { get; set; }
        public DbSet<pedidocompra> pedidocompras { get; set; }
        public DbSet<pessoa> pessoas { get; set; }
        public DbSet<pessoafisica> pessoafisicas { get; set; }
        public DbSet<pessoajuridica> pessoajuridicas { get; set; }
        public DbSet<produto> produtoes { get; set; }
        public DbSet<produto_2> produto_2 { get; set; }
        public DbSet<produto_promocao> produto_promocao { get; set; }
        public DbSet<produtocotacao> produtocotacaos { get; set; }
        public DbSet<profissao> profissaos { get; set; }
        public DbSet<profissaofuncionario> profissaofuncionarios { get; set; }
        public DbSet<r02> r02 { get; set; }
        public DbSet<r03> r03 { get; set; }
        public DbSet<r06> r06 { get; set; }
        public DbSet<r07> r07 { get; set; }
        public DbSet<reserva> reservas { get; set; }
        public DbSet<sintegra_60a> sintegra_60a { get; set; }
        public DbSet<sintegra_60m> sintegra_60m { get; set; }
        public DbSet<situacao_cli> situacao_cli { get; set; }
        public DbSet<solicitacaocompra> solicitacaocompras { get; set; }
        public DbSet<solicitacaopedidocompra> solicitacaopedidocompras { get; set; }
        public DbSet<statuscotacao> statuscotacaos { get; set; }
        public DbSet<statusordemservico> statusordemservicoes { get; set; }
        public DbSet<sysdiagram> sysdiagrams { get; set; }
        public DbSet<tabelapreco> tabelaprecoes { get; set; }
        public DbSet<telefone> telefones { get; set; }
        public DbSet<tipo_email> tipo_email { get; set; }
        public DbSet<tipo_telefone> tipo_telefone { get; set; }
        public DbSet<tipoproduto> tipoprodutoes { get; set; }
        public DbSet<transferenciaestoque> transferenciaestoques { get; set; }
        public DbSet<unidade> unidades { get; set; }
        public DbSet<unidade_produto> unidade_produto { get; set; }
        public DbSet<unidademedida> unidademedidas { get; set; }
        public DbSet<usuario> usuarios { get; set; }
        public DbSet<vendaproduto> vendaprodutoes { get; set; }
        public DbSet<vendaprodutonf> vendaprodutonfs { get; set; }

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
