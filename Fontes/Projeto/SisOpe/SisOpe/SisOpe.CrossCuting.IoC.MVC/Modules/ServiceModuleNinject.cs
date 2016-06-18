using Ninject.Modules;
using SisOpe.Domain.Interfaces.Services;
using SisOpe.Domain.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SisOpe.CrossCuting.IoC.Modules
{
    public class ServiceModuleNinject : NinjectModule
    {
        public override void Load()
        {
            Bind(typeof(IServiceBase<>)).To(typeof(ServiceBase<>));
            Bind<IAcessoService>().To<AcessoService>();
            Bind<IAcessoUsuarioService>().To<AcessoUsuarioService>();
            Bind<IArquivosOrdemServicoService>().To<ArquivosOrdemServicoService>();

            Bind<IContato_PJService>().To<Contato_PJService>();
            Bind<ICotacaoService>().To<CotacaoService>();

            Bind<IDepartamentoService>().To<DepartamentoService>();

            Bind<IEmailService>().To<EmailService>();
            Bind<IEnderecoService>().To<EnderecoService>();
            Bind<IEntradaProdutoNFService>().To<EntradaProdutoNFService>();
            Bind<IEntradaProdutoService>().To<EntradaProdutoService>();
            Bind<IEquipeOrdemServicoService>().To<EquipeOrdemServicoService>();

            Bind<IFinalidadeService>().To<FinalidadeService>();
            Bind<IFormaPagamentoService>().To<FormaPagamentoservice>();
            Bind<IFornecedorCotacaoService>().To<FornecedorCotacaoService>();
            Bind<IFuncionarioService>().To<FuncionarioService>();

            Bind<IHistoricoOrdemServicoService>().To<HistoricoOrdemServicoService>();
            Bind<IHistoricoStatusCotacaoService>().To<HistoricoStatusCotacaoService>();

            Bind<IItemEntradaEstoqueService>().To<ItemEntradaEstoqueService>();
            Bind<IItemEstoqueService>().To<ItemEstoqueService>();
            Bind<IItemPedidoCompraCotacaoService>().To<ItemPedidoCompraCotacaoService>();
            Bind<IItemPedidoCompraService>().To<ItemPedidoCompraService>();
            Bind<IItemProdutoNotaFiscalService>().To<ItemProdutoNotaFiscalService>();
            Bind<IItemReservaVendaProdutoService>().To<ItemReservaVendaProdutoService>();
            Bind<IItemRetornoCotacaoService>().To<ItemRetornoCotacaoService>();
            Bind<IItemSolicitacaoCompraCotacaoService>().To<ItemSolicitacaoCompraCotacaoService>();
            Bind<IItemSolicitacaoCompraService>().To<ItemSolicitacaoCompraService>();
            Bind<IItemTransferenciaEstoqueService>().To<ItemTransferenciaEstoqueService>();
            Bind<IItemVendaEstoqueService>().To<ItemVendaEstoqueService>();

            Bind<IMarcaProdutoService>().To<MarcaProdutoService>();

            Bind<INotaFiscalService>().To<NotaFiscalService>();

            Bind<IOrdemServicoService>().To<OrdemServicoService>();

            Bind<IPagamentoOrdemServicoService>().To<PagamentoOrdemServicoService>();
            Bind<IPagamentoPedidoCompraService>().To<PagamentoPedidoCompraService>();
            Bind<IPagamentoRetornoCotacaoService>().To<PagamentoRetornoCotacaoService>();
            Bind<IPedidoCompraService>().To<PedidoCompraService>();
            Bind<IPessoaFisicaService>().To<PessoaFisicaService>();
            Bind<IPessoaJuridicaService>().To<PessoaJuridicaService>();
            Bind<IPessoaService>().To<PessoaService>();
            Bind<IProdutoCotacaoService>().To<ProdutoCotacaoService>();
            Bind<IProdutoService>().To<ProdutoService>();
            Bind<IProfissaoFuncionarioService>().To<ProfissaoFuncionarioService>();
            Bind<IProfissaoService>().To<ProfissaoService>();

            Bind<IReservaService>().To<ReservaService>();

            Bind<ISolicitacaoCompraService>().To<SolicitacaoCompraService>();
            Bind<ISolicitacaoPedidoCompraService>().To<SolicitacaoPedidoCompraService>();
            Bind<IStatusCotacaoService>().To<StatusCotacaoService>();
            Bind<IStatusOrdemServicoService>().To<StatusOrdemServicoService>();

            Bind<ITabelaPrecoService>().To<TabelaPrecoService>();
            Bind<ITelefoneService>().To<TelefoneService>();
            Bind<ITipoProdutoService>().To<TipoProdutoService>();
            Bind<ITransferenciaEstoqueService>().To<TransferenciaEstoqueService>();

            Bind<IUnidadeMedidaService>().To<UnidadeMedidaService>();
            Bind<IUnidadeService>().To<UnidadeService>();
            Bind<IUsuarioService>().To<UsuarioService>();

            Bind<IVendaProdutoNFService>().To<VendaProdutoNFService>();
            Bind<IVendaProdutoService>().To<VendaProdutoService>();


        }
    }
}