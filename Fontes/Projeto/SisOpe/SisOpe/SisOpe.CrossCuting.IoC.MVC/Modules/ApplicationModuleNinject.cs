using Ninject.Modules;
using SisOpe.Application;
using SisOpe.Application.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SisOpe.CrossCuting.IoC.Modules
{
    public class ApplicationModuleNinject : NinjectModule
    {
        public override void Load()
        {
            Bind(typeof(IAppServiceBase<>)).To(typeof(AppServiceBase<>));
            Bind<IAcessoAppService>().To<AcessoAppService>();
            Bind<IAcessoUsuarioAppService>().To<AcessoUsuarioAppService>();
            Bind<IArquivosOrdemServicoAppService>().To<ArquivosOrdemServicoAppService>();

            Bind<IContato_PJAppService>().To<Contato_PJAppService>();
            Bind<ICotacaoAppService>().To<CotacaoAppService>();

            Bind<IDepartamentoAppService>().To<DepartamentoAppService>();

            Bind<IEmailAppService>().To<EmailAppService>();
            Bind<IEnderecoAppService>().To<EnderecoAppService>();
            Bind<IEntradaProdutoAppService>().To<EntradaProdutoAppService>();
            Bind<IEntradaProdutoNFAppService>().To<EntradaProdutoNFAppService>();
            Bind<IEquipeOrdemServicoAppService>().To<IEquipeOrdemServicoAppService>();

            Bind<IFinalidadeAppService>().To<FinalidadeAppService>();
            Bind<IFormaPagamentoAppService>().To<FormaPagamentoservice>();
            Bind<IFornecedorCotacaoAppService>().To<FornecedorCotacaoAppService>();
            Bind<IFuncionarioAppService>().To<FuncionarioAppService>();

            Bind<IHistoricoOrdemServicoAppService>().To<HistoricoOrdemServicoAppService>();
            Bind<IHistoricoStatusCotacaoAppService>().To<HistoricoStatusCotacaoAppService>();

            Bind<IItemEntradaEstoqueAppService>().To<ItemEntradaEstoqueAppService>();
            Bind<IItemEstoqueAppService>().To<ItemEstoqueAppService>();
            Bind<IItemPedidoCompraAppService>().To<ItemPedidoCompraAppService>();
            Bind<IItemPedidoCompraCotacaoAppService>().To<IItemPedidoCompraCotacaoAppService>();
            Bind<IItemProdutoNotaFiscalAppService>().To<ItemProdutoNotaFiscalAppService>();
            Bind<IItemReservaVendaProdutoAppService>().To<ItemReservaVendaProdutoAppService>();
            Bind<IItemRetornoCotacaoAppService>().To<ItemRetornoCotacaoAppService>();
            Bind<IItemSolicitacaoCompraAppService>().To<ItemSolicitacaoCompraAppService>();
            Bind<IItemSolicitacaoCompraCotacaoAppService>().To<ItemSolicitacaoCompraCotacaoAppService>();
            Bind<IItemTransferenciaEstoqueAppService>().To<ItemTransferenciaEstoqueAppService>();
            Bind<IItemVendaEstoqueAppService>().To<ItemVendaAppService>();

            Bind<IMarcaProdutoAppService>().To<MarcaProdutoAppService>();

            Bind<INotaFiscalAppService>().To<NotaFiscalAppService>();

            Bind<IOrdemServicoAppService>().To<OrdemServicoAppService>();

            Bind<IPagamentoOrdemServicoAppService>().To<PagamentoOrdemServicoAppService>();
            Bind<IPagamentoPedidoCompraAppService>().To<PagamentoPedidoCompraAppService>();
            Bind<IPagamentoRetornoCotacaoAppService>().To<PagamentoRetornoCotacaoAppService>();
            Bind<IPedidoCompraAppService>().To<IPedidoCompraAppService>();
            Bind<IPessoaAppService>().To<PessoaAppService>();
            Bind<IPessoaFisicaAppService>().To<PessoaFisicaAppService>();
            Bind<IPessoaJuridicaAppService>().To<PessoaJuridicaAppService>();
            Bind<IProdutoAppService>().To<ProdutoAppService>();
            Bind<IProdutoCotacaoAppService>().To<ProdutoCotacaoAppService>();
            Bind<IProfissaoAppService>().To<ProfissaoAppService>();
            Bind<IProfissaoFuncionarioAppService>().To<ProfissaoFuncionarioAppService>();

            Bind<IReservaAppService>().To<ReservaAppService>();

            Bind<ISolicitacaoCompraAppService>().To<SolicitacaoCompraAppService>();
            Bind<ISolicitacaoPedidoCompraAppService>().To<SolicitacaoPedidoCompraAppService>();
            Bind<IStatusCotacaoAppService>().To<StatusCotacaoAppService>();
            Bind<IStatusOrdemServicoAppService>().To<StatusOrdemServicoAppService>();

            Bind<ITabelaPrecoAppService>().To<TabelaPrecoAppService>();
            Bind<ITelefoneAppService>().To<TelefoneAppService>();
            Bind<ITipoProdutoAppService>().To<TipoProdutoAppService>();
            Bind<ITransferenciaEstoqueAppService>().To<TransferenciaEstoqueAppService>();

            Bind<IUnidadeAppService>().To<UnidadeAppService>();
            Bind<IUnidadeMedidaAppService>().To<UnidadeMedidaAppService>();
            Bind<IUsuarioAppService>().To<UsuarioAppService>();

            Bind<IVendaProdutoAppService>().To<VendaProdutoAppService>();
            Bind<IVendaProdutoNFAppService>().To<VendaProdutoNFAppService>();
        }
    }
}