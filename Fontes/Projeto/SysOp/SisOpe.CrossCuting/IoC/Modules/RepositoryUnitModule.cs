using Microsoft.Practices.Unity;
using SisOpe.Data.Repository.Repositories;
using SisOpe.Domain.Interfaces.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Mvc;
using Unity.Mvc5;

namespace SisOpe.CrossCuting.IoC.Modules
{
    public static class RepositoryUnitModule
    {
        public static void RegisterComponents()
        {

            
            var container = new UnityContainer();

            container.RegisterType<IUnitOfWork, UnitOfWork>();
            container.RegisterType<IAcessoRepository, AcessoRepository>();
            container.RegisterType<IAcessoUsuarioRepository, AcessoUsuarioRepository>();
            container.RegisterType<IArquivosOrdemServicoRepository, ArquivosOrdemServicoRepository>();
            container.RegisterType<IContato_PJRepository, Contato_PJRepository>();
            container.RegisterType<ICotacaoRepository, CotacaoRepository>();
            container.RegisterType<IDepartamentoRepository, DepartamentoRepository>();
            container.RegisterType<IEmailRepository, EmailRepository>();
            container.RegisterType<IEnderecoRepository, EnderecoRepository>();
            container.RegisterType<IEntradaProdutoNFRepository, EntradaProdutoNFRepository>();
            container.RegisterType<IEntradaProdutoRepository, EntradaProdutoRepository>();
            container.RegisterType<IEquipeOrdemServicoRepository, EquipeOrdemServicoRepository>();
            container.RegisterType<IFinalidadeRepository, FinalidadeRepository>();
            container.RegisterType<IFormaPagamentoRepository, FormaPagamentoRepository>();
            container.RegisterType<IFornecedorCotacaoRepository, FornecedorCotacaoRepository>();
            container.RegisterType<IFuncionarioRepository, FuncionarioRepository>();
            container.RegisterType<IHistoricoOrdemServicoRepository, HistoricoOrdemServicoRepository>();
            container.RegisterType<IHistoricoStatusCotacaoRepository, HistoricoStatusCotacaoRepository>();
            container.RegisterType<IItemEntradaEstoqueRepository, ItemEntradaEstoqueRepository>();
            container.RegisterType<IItemEstoqueRepository, ItemEstoqueRepository>();
            container.RegisterType<IItemPedidoCompraCotacaoRepository, ItemPedidoCompraCotacaoRepository>();
            container.RegisterType<IItemPedidoCompraRepository, ItemPedidoCompraRepository>();
            container.RegisterType<IItemProdutoNotaFiscalRepository, ItemProdutoNotaFiscalRepository>();
            container.RegisterType<IItemReservaVendaProdutoRepository, ItemReservaVendaProdutoRepository>();
            container.RegisterType<IItemRetornoCotacaoRepository, ItemRetornoCotacaoRepository>();
            container.RegisterType<IItemSolicitacaoCompraCotacaoRepository, ItemSolicitacaoCompraCotacaoRepository>();
            container.RegisterType<IItemSolicitacaoCompraRepository, ItemSolicitacaoCompraRepository>();
            container.RegisterType<IItemTransferenciaEstoqueRepository, ItemTransferenciaEstoqueRepository>();
            container.RegisterType<IItemVendaEstoqueRepository, ItemVendaRepository>();
            container.RegisterType<IMarcaProdutoRepository, MarcaProdutoRepository>();
            container.RegisterType<INotaFiscalRepository, NotaFiscalRepository>();
            container.RegisterType<IOrdemServicoRepository, OrdemServicoRepository>();
            container.RegisterType<IPagamentoOrdemServicoRepository, PagamentoOrdemServicoRepository>();
            container.RegisterType<IPagamentoPedidoCompraRepository, PagamentoPedidoCompraRepository>();
            container.RegisterType<IPagamentoRetornoCotacaoRepository, PagamentoRetornoCotacaoRepository>();
            container.RegisterType<IPedidoCompraRepository, PedidoCompraRepository>();
            container.RegisterType<IPessoaFisicaRepository, PessoaFisicaRepository>();
            container.RegisterType<IPessoaJuridicaRepository, PessoaJuridicaRepository>();
            container.RegisterType<IPessoaRepository, PessoaRepository>();
            container.RegisterType<IProdutoCotacaoRepository, ProdutoCotacaoRepository>();
            container.RegisterType<IProdutoRepository, ProdutoRepository>();
            container.RegisterType<IProfissaoFuncionarioRepository, ProfissaoFuncionarioRepository>();
            container.RegisterType<IProfissaoRepository, ProfissaoRepository>();
            container.RegisterType<IReservaRepository, ReservaRepository>();
            container.RegisterType<ISolicitacaoCompraRepository, SolicitacaoCompraRepository>();
            container.RegisterType<ISolicitacaoPedidoCompraRepository, SolicitacaoPedidoCompraRepository>();
            container.RegisterType<IStatusCotacaoRepository, StatusCotacaoRepository>();
            container.RegisterType<IStatusOrdemServicoRepository, StatusOrdemServicoRepository>();
            container.RegisterType<ITabelaPrecoRepository, TabelaPrecoRepository>();
            container.RegisterType<ITelefoneRepository, TelefoneRepository>();
            container.RegisterType<ITipoProdutoRepository, TipoProdutoRepository>();
            container.RegisterType<ITransferenciaEstoqueRepository, TransferenciaEstoqueRepository>();
            container.RegisterType<IStatusCotacaoRepository, StatusCotacaoRepository>();
            container.RegisterType<IStatusOrdemServicoRepository, StatusOrdemServicoRepository>();
            container.RegisterType<ITabelaPrecoRepository, TabelaPrecoRepository>();
            container.RegisterType<ITelefoneRepository, TelefoneRepository>();
            container.RegisterType<ITipoProdutoRepository, TipoProdutoRepository>();
            container.RegisterType<IUnidadeMedidaRepository, UnidadeMedidaRepository>();
            container.RegisterType<IUnidadeRepository, UnidadeRepository>();
            container.RegisterType<IUnitOfWork, UnitOfWork>();
            container.RegisterType<IUsuarioRepository, UsuarioRepository>();
            container.RegisterType<IVendaProdutoNFRepository, VendaProdutoNFRepository>();
            container.RegisterType<IVendaProdutoRepository, VendaProdutoRepository>();
            container.RegisterType<IUnidadeMedidaRepository, UnidadeMedidaRepository>();
            container.RegisterType<IUnidadeRepository, UnidadeRepository>();
            container.RegisterType<IUsuarioRepository, UsuarioRepository>();
            container.RegisterType<IVendaProdutoNFRepository, VendaProdutoNFRepository>();
            container.RegisterType<IVendaProdutoRepository, VendaProdutoRepository>();

            DependencyResolver.SetResolver(new UnityDependencyResolver(container));
            
        }
    }
}
