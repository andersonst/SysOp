using Microsoft.Practices.Unity;
using SisOpe.Domain.Interfaces.Services;
using SisOpe.Domain.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Mvc;
using Unity.Mvc5;

namespace SisOpe.CrossCuting.IoC.Modules
{
    public static class ServiceUnitModule
    {
        public static void RegisterComponents()
        {


            var container = new UnityContainer();

            container.RegisterType<IUnitOfWorkService, UnitOfWorkService>();
            container.RegisterType<IAcessoService, AcessoService>();
            container.RegisterType<IAcessoUsuarioService, AcessoUsuarioService>();
            container.RegisterType<IArquivosOrdemServicoService, ArquivosOrdemServicoService>();
            container.RegisterType<IContato_PJService, Contato_PJService>();
            container.RegisterType<ICotacaoService, CotacaoService>();
            container.RegisterType<IDepartamentoService, DepartamentoService>();
            container.RegisterType<IEmailService, EmailService>();
            container.RegisterType<IEnderecoService, EnderecoService>();
            container.RegisterType<IEntradaProdutoNFService, EntradaProdutoNFService>();
            container.RegisterType<IEntradaProdutoService, EntradaProdutoService>();
            container.RegisterType<IEquipeOrdemServicoService, EquipeOrdemServicoService>();
            container.RegisterType<IFinalidadeService, FinalidadeService>();
            container.RegisterType<IFormaPagamentoService, FormaPagamentoService>();
            container.RegisterType<IFornecedorCotacaoService, FornecedorCotacaoService>();
            container.RegisterType<IFuncionarioService, FuncionarioService>();
            container.RegisterType<IHistoricoOrdemServicoService, HistoricoOrdemServicoService>();
            container.RegisterType<IHistoricoStatusCotacaoService, HistoricoStatusCotacaoService>();
            container.RegisterType<IItemEntradaEstoqueService, ItemEntradaEstoqueService>();
            container.RegisterType<IItemEstoqueService, ItemEstoqueService>();
            container.RegisterType<IItemPedidoCompraCotacaoService, ItemPedidoCompraCotacaoService>();
            container.RegisterType<IItemPedidoCompraService, ItemPedidoCompraService>();
            container.RegisterType<IItemProdutoNotaFiscalService, ItemProdutoNotaFiscalService>();
            container.RegisterType<IItemReservaVendaProdutoService, ItemReservaVendaProdutoService>();
            container.RegisterType<IItemRetornoCotacaoService, ItemRetornoCotacaoService>();
            container.RegisterType<IItemSolicitacaoCompraCotacaoService, ItemSolicitacaoCompraCotacaoService>();
            container.RegisterType<IItemSolicitacaoCompraService, ItemSolicitacaoCompraService>();
            container.RegisterType<IItemTransferenciaEstoqueService, ItemTransferenciaEstoqueService>();
            container.RegisterType<IItemVendaEstoqueService, ItemVendaService>();
            container.RegisterType<IMarcaProdutoService, MarcaProdutoService>();
            container.RegisterType<INotaFiscalService, NotaFiscalService>();
            container.RegisterType<IOrdemServicoService, OrdemServicoService>();
            container.RegisterType<IPagamentoOrdemServicoService, PagamentoOrdemServicoService>();
            container.RegisterType<IPagamentoPedidoCompraService, PagamentoPedidoCompraService>();
            container.RegisterType<IPagamentoRetornoCotacaoService, PagamentoRetornoCotacaoService>();
            container.RegisterType<IPedidoCompraService, PedidoCompraService>();
            container.RegisterType<IPessoaFisicaService, PessoaFisicaService>();
            container.RegisterType<IPessoaJuridicaService, PessoaJuridicaService>();
            container.RegisterType<IPessoaService, PessoaService>();
            container.RegisterType<IProdutoCotacaoService, ProdutoCotacaoService>();
            container.RegisterType<IProdutoService, ProdutoService>();
            container.RegisterType<IProfissaoFuncionarioService, ProfissaoFuncionarioService>();
            container.RegisterType<IProfissaoService, ProfissaoService>();
            container.RegisterType<IReservaService, ReservaService>();
            container.RegisterType<ISolicitacaoCompraService, SolicitacaoCompraService>();
            container.RegisterType<ISolicitacaoPedidoCompraService, SolicitacaoPedidoCompraService>();
            container.RegisterType<IStatusCotacaoService, StatusCotacaoService>();
            container.RegisterType<IStatusOrdemServicoService, StatusOrdemServicoService>();
            container.RegisterType<ITabelaPrecoService, TabelaPrecoService>();
            container.RegisterType<ITelefoneService, TelefoneService>();
            container.RegisterType<ITipoProdutoService, TipoProdutoService>();
            container.RegisterType<ITransferenciaEstoqueService, TransferenciaEstoqueService>();
            container.RegisterType<IStatusCotacaoService, StatusCotacaoService>();
            container.RegisterType<IStatusOrdemServicoService, StatusOrdemServicoService>();
            container.RegisterType<ITabelaPrecoService, TabelaPrecoService>();
            container.RegisterType<ITelefoneService, TelefoneService>();
            container.RegisterType<ITipoProdutoService, TipoProdutoService>();
            container.RegisterType<IUnidadeMedidaService, UnidadeMedidaService>();
            container.RegisterType<IUnidadeService, UnidadeService>();
            container.RegisterType<IUnitOfWorkService, UnitOfWorkService>();
            container.RegisterType<IUsuarioService, UsuarioService>();
            container.RegisterType<IVendaProdutoNFService, VendaProdutoNFService>();
            container.RegisterType<IVendaProdutoService, VendaProdutoService>();
            container.RegisterType<IUnidadeMedidaService, UnidadeMedidaService>();
            container.RegisterType<IUnidadeService, UnidadeService>();
            container.RegisterType<IUsuarioService, UsuarioService>();
            container.RegisterType<IVendaProdutoNFService, VendaProdutoNFService>();
            container.RegisterType<IVendaProdutoService, VendaProdutoService>();

            DependencyResolver.SetResolver(new UnityDependencyResolver(container));

        }
    }
}
