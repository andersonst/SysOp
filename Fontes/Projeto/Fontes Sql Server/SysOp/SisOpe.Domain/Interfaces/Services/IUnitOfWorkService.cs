
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SisOpe.Domain.Interfaces.Services
{
    public interface IUnitOfWorkService  : IDisposable
    {
        #region propriedades
        IAcessoService AcessoService { get; }
        IAcessoUsuarioService AcessoUsuarioService { get; }
        IArquivosOrdemServicoService ArquivosOrdemServicoService { get; }
        IContato_PJService Contato_PJService { get; }
        ICotacaoService CotacaoService { get; }
        IDepartamentoService DepartamentoService { get; }
        IEmailService EmailService { get; }
        IEnderecoService EnderecoService { get; }
        IEntradaProdutoNFService EntradaProdutoNFService { get; }
        IEntradaProdutoService EntradaProdutoService { get; }
        IEquipeOrdemServicoService EquipeOrdemServicoService { get; }
        IFinalidadeService FinalidadeService { get; }
        IFormaPagamentoService FormaPagamentoService { get; }
        IFornecedorCotacaoService FornecedorCotacaoService { get; }
        IFuncionarioService FuncionarioService { get; }
        IHistoricoOrdemServicoService HistoricoOrdemServicoService { get; }

        IHistoricoStatusCotacaoService HistoricoStatusCotacaoService { get; }

        IItemEntradaEstoqueService ItemEntradaEstoqueService { get; }
        IItemEstoqueService ItemEstoqueService { get; }
        IItemPedidoCompraCotacaoService ItemPedidoCompraCotacaoService { get; }
        IItemPedidoCompraService ItemPedidoCompraService { get; }
        IItemProdutoNotaFiscalService ItemProdutoNotaFiscalService { get; }
        IItemReservaVendaProdutoService ItemReservaVendaProdutoService { get; }
        IItemRetornoCotacaoService ItemRetornoCotacaoService { get; }
        IItemSolicitacaoCompraCotacaoService ItemSolicitacaoCompraCotacaoService { get; }
        IItemSolicitacaoCompraService ItemSolicitacaoCompraService { get; }
        IItemTransferenciaEstoqueService ItemTransferenciaEstoqueService { get; }
        IItemVendaEstoqueService ItemVendaEstoqueService { get; }
        IMarcaProdutoService MarcaProdutoService { get; }
        INotaFiscalService NotaFiscalService { get; }
        IOrdemServicoService OrdemServicoService { get; }
        IPagamentoOrdemServicoService PagamentoOrdemServicoService { get; }
        IPagamentoPedidoCompraService PagamentoPedidoCompraService { get; }
        IPagamentoRetornoCotacaoService PagamentoRetornoCotacaoService { get; }
        IPedidoCompraService PedidoCompraService { get; }
        IPessoaFisicaService PessoaFisicaService { get; }
        IPessoaJuridicaService PessoaJuridicaService { get; }

        IPessoaService PessoaService { get; }
        IProdutoCotacaoService ProdutoCotacaoService { get; }
        IProdutoService ProdutoService { get; }
        IProfissaoFuncionarioService ProfissaoFuncionarioService { get; }
        IProfissaoService ProfissaoService { get; }
        IReservaService ReservaService { get; }
        ISolicitacaoCompraService SolicitacaoCompraService { get; }
        ISolicitacaoPedidoCompraService SolicitacaoPedidoCompraService { get; }
        IStatusCotacaoService StatusCotacaoService { get; }
        IStatusOrdemServicoService StatusOrdemServicoService { get; }
        ITabelaPrecoService TabelaPrecoService { get; }
        ITelefoneService TelefoneService { get; }
        ITipoProdutoService TipoProdutoService { get; }
        ITransferenciaEstoqueService TransferenciaEstoqueService { get; }
        IUnidadeMedidaService UnidadeMedidaService { get; }
        IUnidadeService UnidadeService { get; }
        IUsuarioService UsuarioService { get; }
        IVendaProdutoNFService VendaProdutoNFService { get; }
        IVendaProdutoService VendaProdutoService { get; }

        #endregion
    }
}
