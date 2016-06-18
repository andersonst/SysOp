using Ninject.Modules;
using SisOpe.Data.Repository.Repositories;
using SisOpe.Domain.Interfaces.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SisOpe.CrossCuting.IoC.Modules
{
    public class RepositoryModuleNinject : NinjectModule
    {
        public override void Load()
        {
            Bind(typeof(IRepositoryBase<>)).To(typeof(RepositoryBase<>));
            Bind<IAcessoRepository>().To<AcessoRepository>();
            Bind<IAcessoUsuarioRepository>().To<AcessoUsuarioRepository>();
            Bind<IArquivosOrdemServicoRepository>().To<ArquivosOrdemServicoRepository>();

            Bind<IContato_PJRepository>().To<Contato_PJRepository>();
            Bind<ICotacaoRepository>().To<CotacaoRepository>();

            Bind<IDepartamentoRepository>().To<DepartamentoRepository>();

            Bind<IEmailRepository>().To<EmailRepository>();
            Bind<IEnderecoRepository>().To<EnderecoRepository>();
            Bind<IEntradaProdutoNFRepository>().To<EntradaProdutoNFRepository>();
            Bind<IEntradaProdutoRepository>().To<EntradaProdutoRepository>();
            Bind<IEquipeOrdemServicoRepository>().To<EquipeOrdemServicoRepository>();

            Bind<IFinalidadeRepository>().To<FinalidadeRepository>();
            Bind<IFormaPagamentoRepository>().To<FormaPagamentoRepository>();
            Bind<IFornecedorCotacaoRepository>().To<FornecedorCotacaoRepository>();
            Bind<IFuncionarioRepository>().To<FuncionarioRepository>();

            Bind<IHistoricoOrdemServicoRepository>().To<IHistoricoOrdemServicoRepository>();
            Bind<IHistoricoStatusCotacaoRepository>().To<IHistoricoStatusCotacaoRepository>();

            Bind<IItemEntradaEstoqueRepository>().To<ItemEntradaEstoqueRepository>();
            Bind<IItemEstoqueRepository>().To<ItemEstoqueRepository>();
            Bind<IItemPedidoCompraCotacaoRepository>().To<ItemPedidoCompraCotacaoRepository>();
            Bind<IItemPedidoCompraRepository>().To<ItemPedidoCompraRepository>();
            Bind<IItemProdutoNotaFiscalRepository>().To<ItemProdutoNotaFiscalRepository>();
            Bind<IItemReservaVendaProdutoRepository>().To<ItemReservaVendaProdutoRepository>();
            Bind<IItemRetornoCotacaoRepository>().To<ItemRetornoCotacaoRepository>();
            Bind<IItemSolicitacaoCompraCotacaoRepository>().To<ItemSolicitacaoCompraCotacaoRepository>();
            Bind<IItemSolicitacaoCompraRepository>().To<ItemSolicitacaoCompraRepository>();
            Bind<IItemTransferenciaEstoqueRepository>().To<ItemTransferenciaEstoqueRepository>();
            Bind<IItemVendaEstoqueRepository>().To<ItemVendaEstoqueRepository>();

            Bind<IMarcaProdutoRepository>().To<MarcaProdutoRepository>();

            Bind<INotaFiscalRepository>().To<NotaFiscalRepository>();

            Bind<IOrdemServicoRepository>().To<OrdemServicoRepository>();

            Bind<IPagamentoOrdemServicoRepository>().To<PagamentoOrdemServicoRepository>();
            Bind<IPagamentoPedidoCompraRepository>().To<PagamentoPedidoCompraRepository>();
            Bind<IPagamentoRetornoCotacaoRepository>().To<PagamentoRetornoCotacaoRepository>();
            Bind<IPedidoCompraRepository>().To<PedidoCompraRepository>();
            Bind<IPessoaFisicaRepository>().To<PessoaFisicaRepository>();
            Bind<IPessoaJuridicaRepository>().To<PessoaJuridicaRepository>();
            Bind<IPessoaRepository>().To<PessoaRepository>();
            Bind<IProdutoCotacaoRepository>().To<ProdutoCotacaoRepository>();
            Bind<IProdutoRepository>().To<ProdutoRepository>();
            Bind<IProfissaoFuncionarioRepository>().To<ProfissaoFuncionarioRepository>();
            Bind<IProfissaoRepository>().To<ProfissaoRepository>();

            Bind<IReservaRepository>().To<ReservaRepository>();

            Bind<ISolicitacaoCompraRepository>().To<SolicitacaoCompraRepository>();
            Bind<ISolicitacaoPedidoCompraRepository>().To<SolicitacaoPedidoCompraRepository>();
            Bind<IStatusCotacaoRepository>().To<StatusCotacaoRepository>();
            Bind<IStatusOrdemServicoRepository>().To<StatusOrdemServicoRepository>();

            Bind<ITabelaPrecoRepository>().To<TabelaPrecoRepository>();
            Bind<ITelefoneRepository>().To<TelefoneRepository>();
            Bind<ITipoProdutoRepository>().To<TipoProdutoRepository>();
            Bind<ITransferenciaEstoqueRepository>().To<TransferenciaEstoqueRepository>();

            Bind<IUnidadeMedidaRepository>().To<UnidadeMedidaRepository>();
            Bind<IUnidadeRepository>().To<UnidadeRepository>();
            Bind<IUsuarioRepository>().To<UsuarioRepository>();

            Bind<IVendaProdutoNFRepository>().To<VendaProdutoNFRepository>();
            Bind<IVendaProdutoRepository>().To<VendaProdutoRepository>();
          //  Bind<>


        }
    }
}