using Microsoft.Practices.Unity;
using SisOpe.Application;
using SisOpe.Application.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Mvc;
using Unity.Mvc5;


namespace SisOpe.CrossCuting.IoC.Modules
{
    public static class ApplicationUnitModule
    {
        public static void RegisterComponents()
        {


            var container = new UnityContainer();

            container.RegisterType<IUnitOfWorkAppService, UnitOfWorkApp>();
            container.RegisterType<IAcessoAppService, AcessoApp>();
            container.RegisterType<IAcessoUsuarioAppService, AcessoUsuarioApp>();
            container.RegisterType<IArquivosOrdemServicoAppService, ArquivosOrdemServicoApp>();
            container.RegisterType<IContato_PJAppService, Contato_PJApp>();
            container.RegisterType<ICotacaoAppService, CotacaoApp>();
            container.RegisterType<IDepartamentoAppService, DepartamentoApp>();
            container.RegisterType<IEmailAppService, EmailApp>();
            container.RegisterType<IEnderecoAppService, EnderecoApp>();
            container.RegisterType<IEntradaProdutoNFAppService, EntradaProdutoNFApp>();
            container.RegisterType<IEntradaProdutoAppService, EntradaProdutoApp>();
            container.RegisterType<IEquipeOrdemServicoAppService, EquipeOrdemServicoApp>();
            container.RegisterType<IFinalidadeAppService, FinalidadeApp>();
            container.RegisterType<IFormaPagamentoAppService, FormaPagamentoApp>();
            container.RegisterType<IFornecedorCotacaoAppService, FornecedorCotacaoApp>();
            container.RegisterType<IFuncionarioAppService, FuncionarioApp>();
            container.RegisterType<IHistoricoOrdemServicoAppService, HistoricoOrdemServicoApp>();
            container.RegisterType<IHistoricoStatusCotacaoAppService, HistoricoStatusCotacaoApp>();
            container.RegisterType<IItemEntradaEstoqueAppService, ItemEntradaEstoqueApp>();
            container.RegisterType<IItemEstoqueAppService, ItemEstoqueApp>();
            container.RegisterType<IItemPedidoCompraCotacaoAppService, ItemPedidoCompraCotacaoApp>();
            container.RegisterType<IItemPedidoCompraAppService, ItemPedidoCompraApp>();
            container.RegisterType<IItemProdutoNotaFiscalAppService, ItemProdutoNotaFiscalApp>();
            container.RegisterType<IItemReservaVendaProdutoAppService, ItemReservaVendaProdutoApp>();
            container.RegisterType<IItemRetornoCotacaoAppService, ItemRetornoCotacaoApp>();
            container.RegisterType<IItemSolicitacaoCompraCotacaoAppService, ItemSolicitacaoCompraCotacaoApp>();
            container.RegisterType<IItemSolicitacaoCompraAppService, ItemSolicitacaoCompraApp>();
            container.RegisterType<IItemTransferenciaEstoqueAppService, ItemTransferenciaEstoqueApp>();
            container.RegisterType<IItemVendaEstoqueAppService, ItemVendaApp>();
            container.RegisterType<IMarcaProdutoAppService, MarcaProdutoApp>();
            container.RegisterType<INotaFiscalAppService, NotaFiscalApp>();
            container.RegisterType<IOrdemServicoAppService, OrdemServicoApp>();
            container.RegisterType<IPagamentoOrdemServicoAppService, PagamentoOrdemServicoApp>();
            container.RegisterType<IPagamentoPedidoCompraAppService, PagamentoPedidoCompraApp>();
            container.RegisterType<IPagamentoRetornoCotacaoAppService, PagamentoRetornoCotacaoApp>();
            container.RegisterType<IPedidoCompraAppService, PedidoCompraApp>();
            container.RegisterType<IPessoaFisicaAppService, PessoaFisicaApp>();
            container.RegisterType<IPessoaJuridicaAppService, PessoaJuridicaApp>();
            container.RegisterType<IPessoaAppService, PessoaApp>();
            container.RegisterType<IProdutoCotacaoAppService, ProdutoCotacaoApp>();
            container.RegisterType<IProdutoAppService, ProdutoApp>();
            container.RegisterType<IProfissaoFuncionarioAppService, ProfissaoFuncionarioApp>();
            container.RegisterType<IProfissaoAppService, ProfissaoApp>();
            container.RegisterType<IReservaAppService, ReservaApp>();
            container.RegisterType<ISolicitacaoCompraAppService, SolicitacaoCompraApp>();
            container.RegisterType<ISolicitacaoPedidoCompraAppService, SolicitacaoPedidoCompraApp>();
            container.RegisterType<IStatusCotacaoAppService, StatusCotacaoApp>();
            container.RegisterType<IStatusOrdemServicoAppService, StatusOrdemServicoApp>();
            container.RegisterType<ITabelaPrecoAppService, TabelaPrecoApp>();
            container.RegisterType<ITelefoneAppService, TelefoneApp>();
            container.RegisterType<ITipoProdutoAppService, TipoProdutoApp>();
            container.RegisterType<ITransferenciaEstoqueAppService, TransferenciaEstoqueApp>();
            container.RegisterType<IStatusCotacaoAppService, StatusCotacaoApp>();
            container.RegisterType<IStatusOrdemServicoAppService, StatusOrdemServicoApp>();
            container.RegisterType<ITabelaPrecoAppService, TabelaPrecoApp>();
            container.RegisterType<ITelefoneAppService, TelefoneApp>();
            container.RegisterType<ITipoProdutoAppService, TipoProdutoApp>();
            container.RegisterType<IUnidadeMedidaAppService, UnidadeMedidaApp>();
            container.RegisterType<IUnidadeAppService, UnidadeApp>();
            container.RegisterType<IUsuarioAppService, UsuarioApp>();
            container.RegisterType<IVendaProdutoNFAppService, VendaProdutoNFApp>();
            container.RegisterType<IVendaProdutoAppService, VendaProdutoApp>();
            container.RegisterType<IUnidadeMedidaAppService, UnidadeMedidaApp>();
            container.RegisterType<IUnidadeAppService, UnidadeApp>();
            container.RegisterType<IUsuarioAppService, UsuarioApp>();
            container.RegisterType<IVendaProdutoNFAppService, VendaProdutoNFApp>();
            container.RegisterType<IVendaProdutoAppService, VendaProdutoApp>();

            DependencyResolver.SetResolver(new UnityDependencyResolver(container));


        }
    }
}
