using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SisOpe.Application.Interfaces
{
    public interface IUnitOfWorkAppService 
    {
        #region propriedades
        IAcessoAppService AcessoApp { get; }
        IAcessoUsuarioAppService AcessoUsuarioApp { get; }
        IArquivosOrdemServicoAppService ArquivosOrdemServicoApp { get; }
        IContato_PJAppService Contato_PJApp { get; }
        ICotacaoAppService CotacaoApp { get; }
        IDepartamentoAppService DepartamentoApp { get; }
        IEmailAppService EmailApp { get; }
        IEnderecoAppService EnderecoApp { get; }
        IEntradaProdutoNFAppService EntradaProdutoNFApp { get; }
        IEntradaProdutoAppService EntradaProdutoApp { get; }
        IEquipeOrdemServicoAppService EquipeOrdemServicoApp { get; }
        IFinalidadeAppService FinalidadeApp { get; }
        IFormaPagamentoAppService FormaPagamentoApp { get; }
        IFornecedorCotacaoAppService FornecedorCotacaoApp { get; }
        IFuncionarioAppService FuncionarioApp { get; }
        IHistoricoOrdemServicoAppService HistoricoOrdemServicoApp { get; }
        IHistoricoStatusCotacaoAppService HistoricoStatusCotacaoApp { get; }
        IItemEntradaEstoqueAppService ItemEntradaEstoqueApp { get; }
        IItemEstoqueAppService ItemEstoqueApp { get; }
        IItemPedidoCompraCotacaoAppService ItemPedidoCompraCotacaoApp { get; }
        IItemPedidoCompraAppService ItemPedidoCompraApp { get; }
        IItemProdutoNotaFiscalAppService ItemProdutoNotaFiscalApp { get; }
        IItemReservaVendaProdutoAppService ItemReservaVendaProdutoApp { get; }
        IItemRetornoCotacaoAppService ItemRetornoCotacaoApp { get; }
        IItemSolicitacaoCompraCotacaoAppService ItemSolicitacaoCompraCotacaoApp { get; }
        IItemSolicitacaoCompraAppService ItemSolicitacaoCompraApp { get; }
        IItemTransferenciaEstoqueAppService ItemTransferenciaEstoqueApp { get; }
        IItemVendaEstoqueAppService ItemVendaEstoqueApp { get; }
        IMarcaProdutoAppService MarcaProdutoApp { get; }
        INotaFiscalAppService NotaFiscalApp { get; }
        IOrdemServicoAppService OrdemServicoApp { get; }
        IPagamentoOrdemServicoAppService PagamentoOrdemServicoApp { get; }
        IPagamentoPedidoCompraAppService PagamentoPedidoCompraApp { get; }
        IPagamentoRetornoCotacaoAppService PagamentoRetornoCotacaoApp { get; }
        IPedidoCompraAppService PedidoCompraApp { get; }
        IPessoaFisicaAppService PessoaFisicaApp { get; }
        IPessoaJuridicaAppService PessoaJuridicaApp { get; }

        IPessoaAppService PessoaApp { get; }
        IProdutoCotacaoAppService ProdutoCotacaoApp { get; }
        IProdutoAppService ProdutoApp { get; }
        IProfissaoFuncionarioAppService ProfissaoFuncionarioApp { get; }
        IProfissaoAppService ProfissaoApp { get; }
        IReservaAppService ReservaApp { get; }
        ISolicitacaoCompraAppService SolicitacaoCompraApp { get; }
        ISolicitacaoPedidoCompraAppService SolicitacaoPedidoCompraApp { get; }
        IStatusCotacaoAppService StatusCotacaoApp { get; }
        IStatusOrdemServicoAppService StatusOrdemServicoApp { get; }
        ITabelaPrecoAppService TabelaPrecoApp { get; }
        ITelefoneAppService TelefoneApp { get; }
        ITipoProdutoAppService TipoProdutoApp { get; }
        ITransferenciaEstoqueAppService TransferenciaEstoqueApp { get; }
        IUnidadeMedidaAppService UnidadeMedidaApp { get; }
        IUnidadeAppService UnidadeApp { get; }
        IUsuarioAppService UsuarioApp { get; }
        IVendaProdutoNFAppService VendaProdutoNFApp { get; }
        IVendaProdutoAppService VendaProdutoApp { get; }

        #endregion
    }
}
