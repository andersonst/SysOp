using SisOpe.Application.Interfaces;
using SisOpe.Domain.Interfaces.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace SisOpe.Application
{
    public class UnitOfWorkApp : IUnitOfWorkAppService
    {
        #region propriedades
        private IAcessoAppService _acessoApp;
        private IAcessoUsuarioAppService _acessoUsuarioApp;
        private IArquivosOrdemServicoAppService _arquivosOrdemServicoApp;
        private IContato_PJAppService _contato_PJApp;
        private ICotacaoAppService _cotacaoApp;
        private IDepartamentoAppService _departamentoApp;
        private IEmailAppService _emailApp;
        private IEnderecoAppService _enderecoApp;
        private IEntradaProdutoNFAppService _entradaProdutoNFApp;
        private IEntradaProdutoAppService _entradaProdutoApp;
        private IEquipeOrdemServicoAppService _equipeOrdemServicoApp;
        private IFinalidadeAppService _finalidadeApp;
        private IFormaPagamentoAppService _formaPagamentoApp;
        private IFornecedorCotacaoAppService _fornecedorCotacaoApp;
        private IFuncionarioAppService _funcionarioApp;
        private IHistoricoOrdemServicoAppService _historicoOrdemServicoApp;
        private IHistoricoStatusCotacaoAppService _historicoStatusCotacaoApp;
        private IItemEntradaEstoqueAppService _itemEntradaEstoqueApp;
        private IItemEstoqueAppService _itemEstoqueApp;
        private IItemPedidoCompraCotacaoAppService _itemPedidoCompraCotacaoApp;
        private IItemPedidoCompraAppService _itemPedidoCompraApp;
        private IItemProdutoNotaFiscalAppService _itemProdutoNotaFiscalApp;
        private IItemReservaVendaProdutoAppService _itemReservaVendaProdutoApp;
        private IItemRetornoCotacaoAppService _itemRetornoCotacaoApp;
        private IItemSolicitacaoCompraCotacaoAppService _itemSolicitacaoCompraCotacaoApp;
        private IItemSolicitacaoCompraAppService _itemSolicitacaoCompraApp;
        private IItemTransferenciaEstoqueAppService _itemTransferenciaEstoqueApp;
        private IItemVendaEstoqueAppService _itemVendaEstoqueApp;
        private IMarcaProdutoAppService _marcaProdutoApp;
        private INotaFiscalAppService _notaFiscalApp;
        private IOrdemServicoAppService _ordemServicoApp;
        private IPagamentoOrdemServicoAppService _pagamentoOrdemServicoApp;
        private IPagamentoPedidoCompraAppService _pagamentoPedidoCompraApp;
        private IPagamentoRetornoCotacaoAppService _pagamentoRetornoCotacaoApp;
        private IPedidoCompraAppService _pedidoCompraApp;
        private IPessoaFisicaAppService _pessoaFisicaApp;
        private IPessoaJuridicaAppService _pessoaJuridicaApp;
        private IPessoaAppService _pessoaApp;
        private IProdutoCotacaoAppService _produtoCotacaoApp;
        private IProdutoAppService _produtoApp;
        private IProfissaoFuncionarioAppService _profissaoFuncionarioApp;
        private IProfissaoAppService _profissaoApp;
        private IReservaAppService _reservaApp;
        private ISolicitacaoCompraAppService _solicitacaoCompraApp;
        private ISolicitacaoPedidoCompraAppService _solicitacaoPedidoCompraApp;
        private IStatusCotacaoAppService _statusCotacaoApp;
        private IStatusOrdemServicoAppService _statusOrdemServicoApp;
        private ITabelaPrecoAppService _tabelaPrecoApp;
        private ITelefoneAppService _telefoneApp;
        private ITipoProdutoAppService _tipoProdutoApp;
        private ITransferenciaEstoqueAppService _transferenciaEstoqueApp;
        private IUnidadeMedidaAppService _unidadeMedidaApp;
        private IUnidadeAppService _unidadeApp;
        private IUsuarioAppService _usuarioApp;
        private IVendaProdutoNFAppService _vendaProdutoNFApp;
        private IVendaProdutoAppService _vendaProdutoApp;

        private IEcf_CaixaAppService _ecf_CaixaApp;
        private IEcf_ConfiguracaoAppService _ecf_ConfiguracaoApp;
        private IEcf_ImpressoraAppService _ecf_ImpressoraApp;
        private IEcf_MovimentoAppService _ecf_MovimentoApp;
        private IEcf_OperadorAppService _ecf_OperadorApp;
        private IEcf_ResolucaoAppService _ecf_ResolucaoApp;

        #endregion

        

        private readonly IUnitOfWorkService _db;

        public UnitOfWorkApp(IUnitOfWorkService db)
        {
            _db = db;
        }

        //public UnitOfWorkApp()
        //{
        //    //_db = new UnitOfWork();
        //}

        #region Metodos

        public IAcessoAppService AcessoApp
        {
            get { return _acessoApp ??  (_acessoApp = new AcessoApp(_db.AcessoService)); }
        }

        public IAcessoUsuarioAppService  AcessoUsuarioApp
        {
            get { return _acessoUsuarioApp ?? (_acessoUsuarioApp = new AcessoUsuarioApp(_db.AcessoUsuarioService)); }

        }

        public  IArquivosOrdemServicoAppService  ArquivosOrdemServicoApp
        {
            get { return _arquivosOrdemServicoApp ?? (_arquivosOrdemServicoApp = new ArquivosOrdemServicoApp(_db.ArquivosOrdemServicoService)); }
        }

        public IContato_PJAppService Contato_PJApp
        {
            get { return _contato_PJApp ?? (_contato_PJApp = new Contato_PJApp(_db.Contato_PJService)); }
        }

        public ICotacaoAppService CotacaoApp
        {
            get { return _cotacaoApp ?? (_cotacaoApp = new CotacaoApp(_db.CotacaoService)); }
        }

        public IDepartamentoAppService  DepartamentoApp
        {
            get { return _departamentoApp ?? (_departamentoApp = new DepartamentoApp(_db.DepartamentoService)); }

        }

        public IEmailAppService EmailApp
        {
            get { return _emailApp ?? (_emailApp = new EmailApp(_db.EmailService)); }
        }

        public IEnderecoAppService EnderecoApp
        {
            get { return _enderecoApp ?? (_enderecoApp = new EnderecoApp(_db.EnderecoService)); }
        }

        public IEntradaProdutoNFAppService  EntradaProdutoNFApp
        {
            get { return _entradaProdutoNFApp ?? (_entradaProdutoNFApp = new EntradaProdutoNFApp(_db.EntradaProdutoNFService)); }
        }

        public IEntradaProdutoAppService EntradaProdutoApp
        {
            get { return _entradaProdutoApp ?? (_entradaProdutoApp = new EntradaProdutoApp(_db.EntradaProdutoService)); }
        }
        public IEquipeOrdemServicoAppService EquipeOrdemServicoApp
        {
            get { return _equipeOrdemServicoApp ?? (_equipeOrdemServicoApp = new EquipeOrdemServicoApp(_db.EquipeOrdemServicoService)); }
        }
        public IFinalidadeAppService FinalidadeApp
        {
            get { return _finalidadeApp ?? (_finalidadeApp = new FinalidadeApp(_db.FinalidadeService)); }
        }
        public IFormaPagamentoAppService  FormaPagamentoApp
        {
            get { return _formaPagamentoApp ?? (_formaPagamentoApp = new FormaPagamentoApp(_db.FormaPagamentoService));  }
        }

        public IFornecedorCotacaoAppService  FornecedorCotacaoApp
        {
            get { return _fornecedorCotacaoApp ?? (_fornecedorCotacaoApp = new FornecedorCotacaoApp(_db.FornecedorCotacaoService)); }
        }

        public IFuncionarioAppService FuncionarioApp
        {
            get { return _funcionarioApp ?? (_funcionarioApp = new FuncionarioApp(_db.FuncionarioService)); }
        }

        public IHistoricoOrdemServicoAppService HistoricoOrdemServicoApp
        {
            get { return _historicoOrdemServicoApp ?? (_historicoOrdemServicoApp = new HistoricoOrdemServicoApp(_db.HistoricoOrdemServicoService)); }
        }

        public IHistoricoStatusCotacaoAppService HistoricoStatusCotacaoApp
        {
            get { return _historicoStatusCotacaoApp ?? (_historicoStatusCotacaoApp = new HistoricoStatusCotacaoApp(_db.HistoricoStatusCotacaoService)); }
        }
        public IItemEntradaEstoqueAppService ItemEntradaEstoqueApp
        {
            get { return _itemEntradaEstoqueApp ?? (_itemEntradaEstoqueApp = new ItemEntradaEstoqueApp(_db.ItemEntradaEstoqueService)); }
        }
        public IItemEstoqueAppService ItemEstoqueApp
        {
            get { return _itemEstoqueApp ?? (_itemEstoqueApp = new ItemEstoqueApp(_db.ItemEstoqueService)); }
        }
        public IItemPedidoCompraCotacaoAppService ItemPedidoCompraCotacaoApp
        {
            get { return _itemPedidoCompraCotacaoApp ?? (_itemPedidoCompraCotacaoApp = new ItemPedidoCompraCotacaoApp(_db.ItemPedidoCompraCotacaoService)); }
        }
        public IItemPedidoCompraAppService ItemPedidoCompraApp
        {
            get { return _itemPedidoCompraApp ?? (_itemPedidoCompraApp = new ItemPedidoCompraApp(_db.ItemPedidoCompraService)); }
        }

        public IItemProdutoNotaFiscalAppService ItemProdutoNotaFiscalApp
        {
            get { return _itemProdutoNotaFiscalApp ?? (_itemProdutoNotaFiscalApp = new ItemProdutoNotaFiscalApp(_db.ItemProdutoNotaFiscalService)); }
        }

        public IItemReservaVendaProdutoAppService ItemReservaVendaProdutoApp
        {
            get { return _itemReservaVendaProdutoApp ?? (_itemReservaVendaProdutoApp = new ItemReservaVendaProdutoApp(_db.ItemReservaVendaProdutoService)); }
        }

        public IItemRetornoCotacaoAppService ItemRetornoCotacaoApp
        {
            get { return _itemRetornoCotacaoApp ?? (_itemRetornoCotacaoApp = new ItemRetornoCotacaoApp(_db.ItemRetornoCotacaoService)); }
        }
        public IItemSolicitacaoCompraCotacaoAppService ItemSolicitacaoCompraCotacaoApp
        {
            get { return _itemSolicitacaoCompraCotacaoApp ?? (_itemSolicitacaoCompraCotacaoApp = new ItemSolicitacaoCompraCotacaoApp(_db.ItemSolicitacaoCompraCotacaoService)); }
        }

        public IItemSolicitacaoCompraAppService ItemSolicitacaoCompraApp
        {
            get { return _itemSolicitacaoCompraApp ?? (_itemSolicitacaoCompraApp = new ItemSolicitacaoCompraApp(_db.ItemSolicitacaoCompraService)); }
        }
        public IItemTransferenciaEstoqueAppService ItemTransferenciaEstoqueApp
        {
            get { return _itemTransferenciaEstoqueApp ?? (_itemTransferenciaEstoqueApp = new ItemTransferenciaEstoqueApp(_db.ItemTransferenciaEstoqueService)); }
        }
        public IItemVendaEstoqueAppService ItemVendaEstoqueApp
        {
            get { return _itemVendaEstoqueApp ?? (_itemVendaEstoqueApp = new ItemVendaEstoqueApp(_db.ItemVendaEstoqueService)); }
        }

        public IMarcaProdutoAppService MarcaProdutoApp
        {
            get { return _marcaProdutoApp ?? (_marcaProdutoApp = new MarcaProdutoApp(_db.MarcaProdutoService)); }
        }

        public INotaFiscalAppService NotaFiscalApp
        {
            get { return _notaFiscalApp ?? (_notaFiscalApp = new NotaFiscalApp(_db.NotaFiscalService)); }
        }

        public IOrdemServicoAppService OrdemServicoApp
        {
            get { return _ordemServicoApp ?? (_ordemServicoApp = new OrdemServicoApp(_db.OrdemServicoService)); }
        }

        public IPagamentoOrdemServicoAppService PagamentoOrdemServicoApp
        {
            get { return _pagamentoOrdemServicoApp ?? (_pagamentoOrdemServicoApp = new PagamentoOrdemServicoApp(_db.PagamentoOrdemServicoService)); }
        }

        public IPagamentoPedidoCompraAppService PagamentoPedidoCompraApp
        {
            get { return _pagamentoPedidoCompraApp ?? (_pagamentoPedidoCompraApp = new PagamentoPedidoCompraApp(_db.PagamentoPedidoCompraService)); }
        }

        public IPagamentoRetornoCotacaoAppService PagamentoRetornoCotacaoApp
        {
            get { return _pagamentoRetornoCotacaoApp ?? (_pagamentoRetornoCotacaoApp = new PagamentoRetornoCotacaoApp(_db.PagamentoRetornoCotacaoService)); }
        }

        public IPedidoCompraAppService PedidoCompraApp
        {
            get { return _pedidoCompraApp ?? (_pedidoCompraApp = new PedidoCompraApp(_db.PedidoCompraService)); }
        }

        public IPessoaFisicaAppService PessoaFisicaApp
        {
            get { return _pessoaFisicaApp ?? (_pessoaFisicaApp = new PessoaFisicaApp(_db.PessoaFisicaService)); }
        }

        public IPessoaJuridicaAppService PessoaJuridicaApp
        {
            get { return _pessoaJuridicaApp ?? (_pessoaJuridicaApp = new PessoaJuridicaApp(_db.PessoaJuridicaService)); }
        }

        public IPessoaAppService PessoaApp
        {
            get { return _pessoaApp ?? (_pessoaApp = new PessoaApp(_db.PessoaService)); }
        }

        public IProdutoCotacaoAppService ProdutoCotacaoApp
        {
            get { return _produtoCotacaoApp ?? (_produtoCotacaoApp = new ProdutoCotacaoApp(_db.ProdutoCotacaoService)); }
        }
        public IProdutoAppService ProdutoApp
        {
            get { return _produtoApp ?? (_produtoApp = new ProdutoApp(_db.ProdutoService)); }
        }
        public IProfissaoFuncionarioAppService ProfissaoFuncionarioApp
        {
            get { return _profissaoFuncionarioApp ?? (_profissaoFuncionarioApp = new ProfissaoFuncionarioApp(_db.ProfissaoFuncionarioService)); }
        }
        public IProfissaoAppService ProfissaoApp
        {
            get { return _profissaoApp ?? (_profissaoApp = new ProfissaoApp(_db.ProfissaoService)); }
        }
        public IReservaAppService ReservaApp
        {
            get { return _reservaApp ?? (_reservaApp = new ReservaApp(_db.ReservaService)); }
        }

        public ISolicitacaoCompraAppService SolicitacaoCompraApp
        {
            get { return _solicitacaoCompraApp ?? (_solicitacaoCompraApp = new SolicitacaoCompraApp(_db.SolicitacaoCompraService)); }
        }

        public ISolicitacaoPedidoCompraAppService SolicitacaoPedidoCompraApp
        {
            get { return _solicitacaoPedidoCompraApp ?? (_solicitacaoPedidoCompraApp = new SolicitacaoPedidoCompraApp(_db.SolicitacaoPedidoCompraService)); }
        }
        public IStatusCotacaoAppService StatusCotacaoApp
        {
            get { return _statusCotacaoApp ?? (_statusCotacaoApp = new StatusCotacaoApp(_db.StatusCotacaoService)); }
        }
        public IStatusOrdemServicoAppService StatusOrdemServicoApp
        {
            get { return _statusOrdemServicoApp ?? (_statusOrdemServicoApp = new StatusOrdemServicoApp(_db.StatusOrdemServicoService)); }
        }
        public ITabelaPrecoAppService TabelaPrecoApp
        {
            get { return _tabelaPrecoApp ?? (_tabelaPrecoApp = new TabelaPrecoApp(_db.TabelaPrecoService)); }
        }
        public ITelefoneAppService TelefoneApp
        {
            get { return _telefoneApp ?? (_telefoneApp = new TelefoneApp(_db.TelefoneService)); }
        }
        public ITipoProdutoAppService TipoProdutoApp
        {
            get { return _tipoProdutoApp ?? (_tipoProdutoApp = new TipoProdutoApp(_db.TipoProdutoService)); }
        }
        public ITransferenciaEstoqueAppService TransferenciaEstoqueApp
        {
            get { return _transferenciaEstoqueApp ?? (_transferenciaEstoqueApp = new TransferenciaEstoqueApp(_db.TransferenciaEstoqueService)); }
        }
        public IUnidadeMedidaAppService UnidadeMedidaApp
        {
            get { return _unidadeMedidaApp ?? (_unidadeMedidaApp = new UnidadeMedidaApp(_db.UnidadeMedidaService)); }
        }
        public IUnidadeAppService UnidadeApp
        {
            get { return _unidadeApp ?? (_unidadeApp = new UnidadeApp(_db.UnidadeService)); }
        }

        public IUsuarioAppService UsuarioApp
        {
            get { return _usuarioApp ?? (_usuarioApp = new UsuarioApp(_db.UsuarioService)); }
        }
        public IVendaProdutoNFAppService VendaProdutoNFApp
        {
            get { return _vendaProdutoNFApp ?? (_vendaProdutoNFApp = new VendaProdutoNFApp(_db.VendaProdutoNFService)); }
        }

        public IVendaProdutoAppService VendaProdutoApp
        {
            get { return _vendaProdutoApp ?? (_vendaProdutoApp = new VendaProdutoApp(_db.VendaProdutoService)); }
        }

        public IEcf_CaixaAppService Ecf_CaixaApp
        {
            get { return _ecf_CaixaApp ?? (_ecf_CaixaApp = new Ecf_CaixaApp(_db.Ecf_CaixaService)); }
        }

        public IEcf_ConfiguracaoAppService Ecf_ConfiguracaoApp
        {
            get { return _ecf_ConfiguracaoApp ?? (_ecf_ConfiguracaoApp = new Ecf_ConfiguracaoApp(_db.Ecf_ConfiguracaoService)); }

        }

        public IEcf_ImpressoraAppService Ecf_ImpressoraApp
        {
            get { return _ecf_ImpressoraApp ?? (_ecf_ImpressoraApp = new Ecf_ImpressoraApp(_db.Ecf_ImpressoraService)); }
        }

        public IEcf_MovimentoAppService Ecf_MovimentoApp
        {
            get { return _ecf_MovimentoApp ?? (_ecf_MovimentoApp = new Ecf_MovimentoApp(_db.Ecf_MovimentoService)); }
        }

        public IEcf_OperadorAppService Ecf_OperadorApp
        {
            get { return _ecf_OperadorApp ?? (_ecf_OperadorApp = new Ecf_OperadorApp(_db.Ecf_OperadorService)); }
        }

        public IEcf_ResolucaoAppService Ecf_ResolucaoApp
        {
            get { return _ecf_ResolucaoApp ?? (_ecf_ResolucaoApp = new Ecf_ResolucaoApp(_db.Ecf_ResolucaoService)); }
        }

        #endregion
    }
}
