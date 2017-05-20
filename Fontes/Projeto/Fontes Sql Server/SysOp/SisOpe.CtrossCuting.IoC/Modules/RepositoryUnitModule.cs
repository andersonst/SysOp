using Microsoft.Practices.Unity;
using SisOpe.Application;
using SisOpe.Application.Interfaces;
using SisOpe.Data.Repository.Repositories;
using SisOpe.Domain.Interfaces.Repositories;
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

            #region Service


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

            #endregion

            #region  App


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

            #endregion

            DependencyResolver.SetResolver(new UnityDependencyResolver(container));
            
        }
    }
}
