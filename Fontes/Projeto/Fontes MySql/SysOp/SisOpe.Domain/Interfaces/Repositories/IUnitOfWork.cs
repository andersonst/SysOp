﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SisOpe.Domain.Interfaces.Repositories
{
    public interface IUnitOfWork : IDisposable
    {
        #region propriedades
        IAcessoRepository AcessoRepository { get;  }
        IAcessoUsuarioRepository AcessoUsuarioRepository { get; }
        IArquivosOrdemServicoRepository ArquivosOrdemServicoRepository { get; }
        IContato_PJRepository Contato_PJRepository { get; }
        ICotacaoRepository CotacaoRepository { get; }
        IDepartamentoRepository DepartamentoRepository { get; }
        IEmailRepository EmailRepository { get; }
        IEnderecoRepository EnderecoRepository { get; }
        IEntradaProdutoNFRepository EntradaProdutoNFRepository { get; }
        IEntradaProdutoRepository EntradaProdutoRepository { get; }
        IEquipeOrdemServicoRepository EquipeOrdemServicoRepository { get; }
        IFinalidadeRepository FinalidadeRepository { get; }
        IFormaPagamentoRepository FormaPagamentoRepository { get; }
        IFornecedorCotacaoRepository FornecedorCotacaoRepository { get; }
        IFuncionarioRepository FuncionarioRepository { get; }
        IHistoricoOrdemServicoRepository HistoricoOrdemServicoRepository { get; }

        IHistoricoStatusCotacaoRepository HistoricoStatusCotacaoRepository { get; }

        IItemEntradaEstoqueRepository ItemEntradaEstoqueRepository { get; }
        IItemEstoqueRepository ItemEstoqueRepository { get; }
        IItemPedidoCompraCotacaoRepository ItemPedidoCompraCotacaoRepository { get; }
        IItemPedidoCompraRepository ItemPedidoCompraRepository { get; }
        IItemProdutoNotaFiscalRepository ItemProdutoNotaFiscalRepository { get; }
        IItemReservaVendaProdutoRepository ItemReservaVendaProdutoRepository { get; }
        IItemRetornoCotacaoRepository ItemRetornoCotacaoRepository { get; }
        IItemSolicitacaoCompraCotacaoRepository ItemSolicitacaoCompraCotacaoRepository { get; }
        IItemSolicitacaoCompraRepository ItemSolicitacaoCompraRepository { get; }
        IItemTransferenciaEstoqueRepository ItemTransferenciaEstoqueRepository { get; }
        IItemVendaEstoqueRepository ItemVendaEstoqueRepository { get; }
        IMarcaProdutoRepository MarcaProdutoRepository { get; }
        INotaFiscalRepository NotaFiscalRepository { get; }
        IOrdemServicoRepository OrdemServicoRepository { get; }
        IPagamentoOrdemServicoRepository PagamentoOrdemServicoRepository { get; }
        IPagamentoPedidoCompraRepository PagamentoPedidoCompraRepository { get; }
        IPagamentoRetornoCotacaoRepository PagamentoRetornoCotacaoRepository { get; }
        IPedidoCompraRepository PedidoCompraRepository { get; }
        IPessoaFisicaRepository PessoaFisicaRepository { get; }
        IPessoaJuridicaRepository PessoaJuridicaRepository { get;  }

        IPessoaRepository PessoaRepository { get; }
        IProdutoCotacaoRepository ProdutoCotacaoRepository { get; }
        IProdutoRepository ProdutoRepository { get; }
        IProfissaoFuncionarioRepository ProfissaoFuncionarioRepository { get; }
        IProfissaoRepository ProfissaoRepository { get; }
        IReservaRepository ReservaRepository { get; }
        ISolicitacaoCompraRepository SolicitacaoCompraRepository { get; }
        ISolicitacaoPedidoCompraRepository SolicitacaoPedidoCompraRepository { get; }
        IStatusCotacaoRepository StatusCotacaoRepository { get; }
        IStatusOrdemServicoRepository StatusOrdemServicoRepository { get; }
        ITabelaPrecoRepository TabelaPrecoRepository { get; }
        ITelefoneRepository TelefoneRepository { get; }
        ITipoProdutoRepository TipoProdutoRepository { get; }
        ITransferenciaEstoqueRepository TransferenciaEstoqueRepository { get; }
        IUnidadeMedidaRepository UnidadeMedidaRepository { get; }
        IUnidadeRepository UnidadeRepository { get; }
        IUsuarioRepository UsuarioRepository { get; }
        IVendaProdutoNFRepository VendaProdutoNFRepository { get; }
        IVendaProdutoRepository VendaProdutoRepository { get; }

        IEcf_CaixaRepository Ecf_CaixaRepository { get; }
        IEcf_ConfiguracaoRepository Ecf_ConfiguracaoRepository { get; }
        IEcf_ImpressoraRepository Ecf_ImpressoraRepository { get; }
        IEcf_MovimentoRepository Ecf_MovimentoRepository { get; }
        IEcf_OperadorRepository Ecf_OperadorRepository { get; }
        IEcf_ResolucaoRepository Ecf_ResolucaoRepository { get; }

        IEcf_Posicao_ComponentesRepository Ecf_Posicao_ComponentesRepository { get; }

        IEcf_Dav_DetalheRepository Ecf_Dav_DetalheRepository { get; }

        IEcf_Dav_CabecalhoRepository Ecf_Dav_CabecalhoRepository { get; }

        IEcf_FuncionarioRepository Ecf_FuncionarioRepository { get; }
         
        #endregion


    }
}
