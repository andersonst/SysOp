﻿using SisOpe.Domain.Interfaces.Repositories;
using SisOpe.Domain.Interfaces.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace SisOpe.Domain.Services
{
    public class UnitOfWorkService : IUnitOfWorkService
    {
         #region propriedades
        private IAcessoService _acessoService;
        private IAcessoUsuarioService _acessoUsuarioService;
        private IArquivosOrdemServicoService _arquivosOrdemServicoService;
        private IContato_PJService _contato_PJService;
        private ICotacaoService _cotacaoService;
        private IDepartamentoService _departamentoService;
        private IEmailService _emailService;
        private IEnderecoService _enderecoService;
        private IEntradaProdutoNFService _entradaProdutoNFService;
        private IEntradaProdutoService _entradaProdutoService;
        private IEquipeOrdemServicoService _equipeOrdemServicoService;
        private IFinalidadeService _finalidadeService;
        private IFormaPagamentoService _formaPagamentoService;
        private IFornecedorCotacaoService _fornecedorCotacaoService;
        private IFuncionarioService _funcionarioService;
        private IHistoricoOrdemServicoService _historicoOrdemServicoService;
        private IHistoricoStatusCotacaoService _historicoStatusCotacaoService;
        private IItemEntradaEstoqueService _itemEntradaEstoqueService;
        private IItemEstoqueService _itemEstoqueService;
        private IItemPedidoCompraCotacaoService _itemPedidoCompraCotacaoService;
        private IItemPedidoCompraService _itemPedidoCompraService;
        private IItemProdutoNotaFiscalService _itemProdutoNotaFiscalService;
        private IItemReservaVendaProdutoService _itemReservaVendaProdutoService;
        private IItemRetornoCotacaoService _itemRetornoCotacaoService;
        private IItemSolicitacaoCompraCotacaoService _itemSolicitacaoCompraCotacaoService;
        private IItemSolicitacaoCompraService _itemSolicitacaoCompraService;
        private IItemTransferenciaEstoqueService _itemTransferenciaEstoqueService;
        private IItemVendaEstoqueService _itemVendaEstoqueService;
        private IMarcaProdutoService _marcaProdutoService;
        private INotaFiscalService _notaFiscalService;
        private IOrdemServicoService _ordemServicoService;
        private IPagamentoOrdemServicoService _pagamentoOrdemServicoService;
        private IPagamentoPedidoCompraService _pagamentoPedidoCompraService;
        private IPagamentoRetornoCotacaoService _pagamentoRetornoCotacaoService;
        private IPedidoCompraService _pedidoCompraService;
        private IPessoaFisicaService _pessoaFisicaService;
        private IPessoaJuridicaService _pessoaJuridicaService;
        private IPessoaService _pessoaService;
        private IProdutoCotacaoService _produtoCotacaoService;
        private IProdutoService _produtoService;
        private IProfissaoFuncionarioService _profissaoFuncionarioService;
        private IProfissaoService _profissaoService;
        private IReservaService _reservaService;
        private ISolicitacaoCompraService _solicitacaoCompraService;
        private ISolicitacaoPedidoCompraService _solicitacaoPedidoCompraService;
        private IStatusCotacaoService _statusCotacaoService;
        private IStatusOrdemServicoService _statusOrdemServicoService;
        private ITabelaPrecoService _tabelaPrecoService;
        private ITelefoneService _telefoneService;
        private ITipoProdutoService _tipoProdutoService;
        private ITransferenciaEstoqueService _transferenciaEstoqueService;
        private IUnidadeMedidaService _unidadeMedidaService;
        private IUnidadeService _unidadeService;
        private IUsuarioService _usuarioService;
        private IVendaProdutoNFService _vendaProdutoNFService;
        private IVendaProdutoService _vendaProdutoService;

        private IEcf_CaixaService _ecf_CaixaService;
        private IEcf_ConfiguracaoService _ecf_ConfiguracaoService;
        private IEcf_ImpressoraService _ecf_ImpressoraService;
        private IEcf_MovimentoService _ecf_MovimentoService;
        private IEcf_OperadorService _ecf_OperadorService;
        private IEcf_ResolucaoService _ecf_ResolucaoService;

        private IEcf_Posicao_ComponentesService _ecf_Posicao_ComponentesService;
        private IEcf_Dav_DetalheService _ecf_Dav_DetalheService;
        private IEcf_Dav_CabecalhoService _ecf_Dav_CabecalhoService;

        private IEcf_FuncionarioService _ecf_FuncionarioService;
        #endregion

        public void Dispose()
        {

        }

        private readonly IUnitOfWork _db;

        public UnitOfWorkService(IUnitOfWork db)
        {
            _db = db;
        }

        

        #region Metodos

        public IAcessoService AcessoService
        {
            get { return _acessoService ??  (_acessoService = new AcessoService(_db.AcessoRepository)); }
        }

        public IAcessoUsuarioService  AcessoUsuarioService
        {
            get { return _acessoUsuarioService ?? (_acessoUsuarioService = new AcessoUsuarioService(_db.AcessoUsuarioRepository)); }

        }

        public  IArquivosOrdemServicoService  ArquivosOrdemServicoService
        {
            get { return _arquivosOrdemServicoService ?? (_arquivosOrdemServicoService = new ArquivosOrdemServicoService(_db.ArquivosOrdemServicoRepository)); }
        }

        public IContato_PJService Contato_PJService
        {
            get { return _contato_PJService ?? (_contato_PJService = new Contato_PJService(_db.Contato_PJRepository)); }
        }

        public ICotacaoService CotacaoService
        {
            get { return _cotacaoService ?? (_cotacaoService = new CotacaoService(_db.CotacaoRepository)); }
        }

        public IDepartamentoService  DepartamentoService
        {
            get { return _departamentoService ?? (_departamentoService = new DepartamentoService(_db.DepartamentoRepository)); }

        }

        public IEmailService EmailService
        {
            get { return _emailService ?? (_emailService = new EmailService(_db.EmailRepository)); }
        }

        public IEnderecoService EnderecoService
        {
            get { return _enderecoService ?? (_enderecoService = new EnderecoService(_db.EnderecoRepository)); }
        }

        public IEntradaProdutoNFService  EntradaProdutoNFService
        {
            get { return _entradaProdutoNFService ?? (_entradaProdutoNFService = new EntradaProdutoNFService(_db.EntradaProdutoNFRepository)); }
        }

        public IEntradaProdutoService EntradaProdutoService
        {
            get { return _entradaProdutoService ?? (_entradaProdutoService = new EntradaProdutoService(_db.EntradaProdutoRepository)); }
        }
        public IEquipeOrdemServicoService EquipeOrdemServicoService
        {
            get { return _equipeOrdemServicoService ?? (_equipeOrdemServicoService = new EquipeOrdemServicoService(_db.EquipeOrdemServicoRepository)); }
        }
        public IFinalidadeService FinalidadeService
        {
            get { return _finalidadeService ?? (_finalidadeService = new FinalidadeService(_db.FinalidadeRepository)); }
        }
        public IFormaPagamentoService  FormaPagamentoService
        {
            get { return _formaPagamentoService ?? (_formaPagamentoService = new FormaPagamentoService(_db.FormaPagamentoRepository));  }
        }

        public IFornecedorCotacaoService  FornecedorCotacaoService
        {
            get { return _fornecedorCotacaoService ?? (_fornecedorCotacaoService = new FornecedorCotacaoService(_db.FornecedorCotacaoRepository)); }
        }

        public IFuncionarioService FuncionarioService
        {
            get { return _funcionarioService ?? (_funcionarioService = new FuncionarioService(_db.FuncionarioRepository)); }
        }

        public IHistoricoOrdemServicoService HistoricoOrdemServicoService
        {
            get { return _historicoOrdemServicoService ?? (_historicoOrdemServicoService = new HistoricoOrdemServicoService(_db.HistoricoOrdemServicoRepository)); }
        }

        public IHistoricoStatusCotacaoService HistoricoStatusCotacaoService
        {
            get { return _historicoStatusCotacaoService ?? (_historicoStatusCotacaoService = new HistoricoStatusCotacaoService(_db.HistoricoStatusCotacaoRepository)); }
        }
        public IItemEntradaEstoqueService ItemEntradaEstoqueService
        {
            get { return _itemEntradaEstoqueService ?? (_itemEntradaEstoqueService = new ItemEntradaEstoqueService(_db.ItemEntradaEstoqueRepository)); }
        }
        public IItemEstoqueService ItemEstoqueService
        {
            get { return _itemEstoqueService ?? (_itemEstoqueService = new ItemEstoqueService(_db.ItemEstoqueRepository)); }
        }
        public IItemPedidoCompraCotacaoService ItemPedidoCompraCotacaoService
        {
            get { return _itemPedidoCompraCotacaoService ?? (_itemPedidoCompraCotacaoService = new ItemPedidoCompraCotacaoService(_db.ItemPedidoCompraCotacaoRepository)); }
        }
        public IItemPedidoCompraService ItemPedidoCompraService
        {
            get { return _itemPedidoCompraService ?? (_itemPedidoCompraService = new ItemPedidoCompraService(_db.ItemPedidoCompraRepository)); }
        }

        public IItemProdutoNotaFiscalService ItemProdutoNotaFiscalService
        {
            get { return _itemProdutoNotaFiscalService ?? (_itemProdutoNotaFiscalService = new ItemProdutoNotaFiscalService(_db.ItemProdutoNotaFiscalRepository)); }
        }

        public IItemReservaVendaProdutoService ItemReservaVendaProdutoService
        {
            get { return _itemReservaVendaProdutoService ?? (_itemReservaVendaProdutoService = new ItemReservaVendaProdutoService(_db.ItemReservaVendaProdutoRepository)); }
        }

        public IItemRetornoCotacaoService ItemRetornoCotacaoService
        {
            get { return _itemRetornoCotacaoService ?? (_itemRetornoCotacaoService = new ItemRetornoCotacaoService(_db.ItemRetornoCotacaoRepository)); }
        }
        public IItemSolicitacaoCompraCotacaoService ItemSolicitacaoCompraCotacaoService
        {
            get { return _itemSolicitacaoCompraCotacaoService ?? (_itemSolicitacaoCompraCotacaoService = new ItemSolicitacaoCompraCotacaoService(_db.ItemSolicitacaoCompraCotacaoRepository)); }
        }

        public IItemSolicitacaoCompraService ItemSolicitacaoCompraService
        {
            get { return _itemSolicitacaoCompraService ?? (_itemSolicitacaoCompraService = new ItemSolicitacaoCompraService(_db.ItemSolicitacaoCompraRepository)); }
        }
        public IItemTransferenciaEstoqueService ItemTransferenciaEstoqueService
        {
            get { return _itemTransferenciaEstoqueService ?? (_itemTransferenciaEstoqueService = new ItemTransferenciaEstoqueService(_db.ItemTransferenciaEstoqueRepository)); }
        }
        public IItemVendaEstoqueService ItemVendaEstoqueService
        {
            get { return _itemVendaEstoqueService ?? (_itemVendaEstoqueService = new ItemVendaEstoqueService(_db.ItemVendaEstoqueRepository)); }
        }

        public IMarcaProdutoService MarcaProdutoService
        {
            get { return _marcaProdutoService ?? (_marcaProdutoService = new MarcaProdutoService(_db.MarcaProdutoRepository)); }
        }

        public INotaFiscalService NotaFiscalService
        {
            get { return _notaFiscalService ?? (_notaFiscalService = new NotaFiscalService(_db.NotaFiscalRepository)); }
        }

        public IOrdemServicoService OrdemServicoService
        {
            get { return _ordemServicoService ?? (_ordemServicoService = new OrdemServicoService(_db.OrdemServicoRepository)); }
        }

        public IPagamentoOrdemServicoService PagamentoOrdemServicoService
        {
            get { return _pagamentoOrdemServicoService ?? (_pagamentoOrdemServicoService = new PagamentoOrdemServicoService(_db.PagamentoOrdemServicoRepository)); }
        }

        public IPagamentoPedidoCompraService PagamentoPedidoCompraService
        {
            get { return _pagamentoPedidoCompraService ?? (_pagamentoPedidoCompraService = new PagamentoPedidoCompraService(_db.PagamentoPedidoCompraRepository)); }
        }

        public IPagamentoRetornoCotacaoService PagamentoRetornoCotacaoService
        {
            get { return _pagamentoRetornoCotacaoService ?? (_pagamentoRetornoCotacaoService = new PagamentoRetornoCotacaoService(_db.PagamentoRetornoCotacaoRepository)); }
        }

        public IPedidoCompraService PedidoCompraService
        {
            get { return _pedidoCompraService ?? (_pedidoCompraService = new PedidoCompraService(_db.PedidoCompraRepository)); }
        }

        public IPessoaFisicaService PessoaFisicaService
        {
            get { return _pessoaFisicaService ?? (_pessoaFisicaService = new PessoaFisicaService(_db.PessoaFisicaRepository)); }
        }

        public IPessoaJuridicaService PessoaJuridicaService
        {
            get { return _pessoaJuridicaService ?? (_pessoaJuridicaService = new PessoaJuridicaService(_db.PessoaJuridicaRepository)); }
        }

        public IPessoaService PessoaService
        {
            get { return _pessoaService ?? (_pessoaService = new PessoaService(_db.PessoaRepository)); }
        }

        public IProdutoCotacaoService ProdutoCotacaoService
        {
            get { return _produtoCotacaoService ?? (_produtoCotacaoService = new ProdutoCotacaoService(_db.ProdutoCotacaoRepository)); }
        }
        public IProdutoService ProdutoService
        {
            get { return _produtoService ?? (_produtoService = new ProdutoService(_db.ProdutoRepository)); }
        }
        public IProfissaoFuncionarioService ProfissaoFuncionarioService
        {
            get { return _profissaoFuncionarioService ?? (_profissaoFuncionarioService = new ProfissaoFuncionarioService(_db.ProfissaoFuncionarioRepository)); }
        }
        public IProfissaoService ProfissaoService
        {
            get { return _profissaoService ?? (_profissaoService = new ProfissaoService(_db.ProfissaoRepository)); }
        }
        public IReservaService ReservaService
        {
            get { return _reservaService ?? (_reservaService = new ReservaService(_db.ReservaRepository)); }
        }

        public ISolicitacaoCompraService SolicitacaoCompraService
        {
            get { return _solicitacaoCompraService ?? (_solicitacaoCompraService = new SolicitacaoCompraService(_db.SolicitacaoCompraRepository)); }
        }

        public ISolicitacaoPedidoCompraService SolicitacaoPedidoCompraService
        {
            get { return _solicitacaoPedidoCompraService ?? (_solicitacaoPedidoCompraService = new SolicitacaoPedidoCompraService(_db.SolicitacaoPedidoCompraRepository)); }
        }
        public IStatusCotacaoService StatusCotacaoService
        {
            get { return _statusCotacaoService ?? (_statusCotacaoService = new StatusCotacaoService(_db.StatusCotacaoRepository)); }
        }
        public IStatusOrdemServicoService StatusOrdemServicoService
        {
            get { return _statusOrdemServicoService ?? (_statusOrdemServicoService = new StatusOrdemServicoService(_db.StatusOrdemServicoRepository)); }
        }
        public ITabelaPrecoService TabelaPrecoService
        {
            get { return _tabelaPrecoService ?? (_tabelaPrecoService = new TabelaPrecoService(_db.TabelaPrecoRepository)); }
        }
        public ITelefoneService TelefoneService
        {
            get { return _telefoneService ?? (_telefoneService = new TelefoneService(_db.TelefoneRepository)); }
        }
        public ITipoProdutoService TipoProdutoService
        {
            get { return _tipoProdutoService ?? (_tipoProdutoService = new TipoProdutoService(_db.TipoProdutoRepository)); }
        }
        public ITransferenciaEstoqueService TransferenciaEstoqueService
        {
            get { return _transferenciaEstoqueService ?? (_transferenciaEstoqueService = new TransferenciaEstoqueService(_db.TransferenciaEstoqueRepository)); }
        }
        public IUnidadeMedidaService UnidadeMedidaService
        {
            get { return _unidadeMedidaService ?? (_unidadeMedidaService = new UnidadeMedidaService(_db.UnidadeMedidaRepository)); }
        }
        public IUnidadeService UnidadeService
        {
            get { return _unidadeService ?? (_unidadeService = new UnidadeService(_db.UnidadeRepository)); }
        }

        public IUsuarioService UsuarioService
        {
            get { return _usuarioService ?? (_usuarioService = new UsuarioService(_db.UsuarioRepository)); }
        }
        public IVendaProdutoNFService VendaProdutoNFService
        {
            get { return _vendaProdutoNFService ?? (_vendaProdutoNFService = new VendaProdutoNFService(_db.VendaProdutoNFRepository)); }
        }

        public IVendaProdutoService VendaProdutoService
        {
            get { return _vendaProdutoService ?? (_vendaProdutoService = new VendaProdutoService(_db.VendaProdutoRepository)); }
        }


        public IEcf_CaixaService Ecf_CaixaService
        {
            get { return _ecf_CaixaService ?? (_ecf_CaixaService = new Ecf_CaixaService(_db.Ecf_CaixaRepository)); }
        }

        public IEcf_ConfiguracaoService Ecf_ConfiguracaoService
        {
            get { return _ecf_ConfiguracaoService ?? (_ecf_ConfiguracaoService = new Ecf_ConfiguracaoService(_db.Ecf_ConfiguracaoRepository)); }

        }

        public IEcf_ImpressoraService Ecf_ImpressoraService
        {
            get { return _ecf_ImpressoraService ?? (_ecf_ImpressoraService = new Ecf_ImpressoraService(_db.Ecf_ImpressoraRepository)); }
        }

        public IEcf_MovimentoService Ecf_MovimentoService
        {
            get { return _ecf_MovimentoService ?? (_ecf_MovimentoService = new Ecf_MovimentoService(_db.Ecf_MovimentoRepository)); }
        }

        public IEcf_OperadorService Ecf_OperadorService
        {
            get { return _ecf_OperadorService ?? (_ecf_OperadorService = new Ecf_OperadorService(_db.Ecf_OperadorRepository)); }
        }

        public IEcf_ResolucaoService Ecf_ResolucaoService
        {
            get { return _ecf_ResolucaoService ?? (_ecf_ResolucaoService = new Ecf_ResolucaoService(_db.Ecf_ResolucaoRepository)); }
        }

        public IEcf_Posicao_ComponentesService Ecf_Posicao_ComponentesService
        {
            get { return _ecf_Posicao_ComponentesService ?? (_ecf_Posicao_ComponentesService = new Ecf_Posicao_ComponentesService(_db.Ecf_Posicao_ComponentesRepository)); }
        }

        public IEcf_Dav_DetalheService Ecf_Dav_DetalheService
        {
            get { return _ecf_Dav_DetalheService ?? (_ecf_Dav_DetalheService = new Ecf_Dav_DetalheService(_db.Ecf_Dav_DetalheRepository)); }
        }

        public IEcf_Dav_CabecalhoService Ecf_Dav_CabecalhoService
        {
            get { return _ecf_Dav_CabecalhoService ?? (_ecf_Dav_CabecalhoService = new Ecf_Dav_CabecalhoService(_db.Ecf_Dav_CabecalhoRepository)); }
        }

        public IEcf_FuncionarioService Ecf_FuncionarioService
        {
            get { return _ecf_FuncionarioService ?? (_ecf_FuncionarioService = new Ecf_FuncionarioService(_db.Ecf_FuncionarioRepository)); }
        }
        #endregion
    }
}
