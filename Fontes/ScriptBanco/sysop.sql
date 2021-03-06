USE [SysOp]
GO
/****** Object:  Table [dbo].[Acesso]    Script Date: 21/05/2016 18:06:59 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Acesso](
	[IdAcesso] [int] IDENTITY(1,1) NOT NULL,
	[Descricao] [varchar](100) NULL,
 CONSTRAINT [PK_Acesso] PRIMARY KEY CLUSTERED 
(
	[IdAcesso] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[AcessoUsuario]    Script Date: 21/05/2016 18:06:59 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[AcessoUsuario](
	[IdAcessoUsuario] [int] IDENTITY(1,1) NOT NULL,
	[IdUsuario] [int] NULL,
	[IdAcesso] [int] NULL,
 CONSTRAINT [PK_AcessoUsuario] PRIMARY KEY CLUSTERED 
(
	[IdAcessoUsuario] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[ArquivosOrdemServico]    Script Date: 21/05/2016 18:06:59 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[ArquivosOrdemServico](
	[IdArquivosOrdemServico] [int] IDENTITY(1,1) NOT NULL,
	[IdOrdemServico] [int] NULL,
	[PathArquivo] [varchar](50) NULL,
 CONSTRAINT [PK_ArquivosOrdemServico] PRIMARY KEY CLUSTERED 
(
	[IdArquivosOrdemServico] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Contato_PJ]    Script Date: 21/05/2016 18:06:59 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Contato_PJ](
	[IdContatoPJ] [int] NOT NULL,
	[IdPessoaJuridica] [int] NULL,
	[Nome] [varchar](100) NULL,
 CONSTRAINT [PK_Contato_PJ] PRIMARY KEY CLUSTERED 
(
	[IdContatoPJ] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Cotacao]    Script Date: 21/05/2016 18:06:59 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Cotacao](
	[IdCotacao] [int] IDENTITY(1,1) NOT NULL,
	[Descricao] [varchar](50) NULL,
	[DataInicio] [datetime] NULL,
	[DataFim] [datetime] NULL,
	[IdStatusCotacao] [int] NULL,
 CONSTRAINT [PK_Cotacao] PRIMARY KEY CLUSTERED 
(
	[IdCotacao] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Departamento]    Script Date: 21/05/2016 18:06:59 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Departamento](
	[IdDepartamento] [int] IDENTITY(1,1) NOT NULL,
	[Descricao] [varchar](50) NULL,
	[Status] [varchar](20) NULL,
 CONSTRAINT [PK_Departamento] PRIMARY KEY CLUSTERED 
(
	[IdDepartamento] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Email]    Script Date: 21/05/2016 18:06:59 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Email](
	[IdEmail] [int] IDENTITY(1,1) NOT NULL,
	[IdPessoa] [int] NULL,
	[Email] [varchar](50) NULL,
 CONSTRAINT [PK_Email] PRIMARY KEY CLUSTERED 
(
	[IdEmail] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Endereco]    Script Date: 21/05/2016 18:06:59 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Endereco](
	[IdEndereco] [int] IDENTITY(1,1) NOT NULL,
	[Logradouro] [varchar](200) NULL,
	[Complemento] [varchar](50) NULL,
	[Bairro] [varchar](50) NULL,
	[Cidade] [varchar](80) NULL,
	[CEP] [varchar](20) NULL,
	[PontoReferencia] [varchar](150) NULL,
	[Primario] [bit] NULL,
	[IdPessoa] [int] NULL,
 CONSTRAINT [PK_Endereco] PRIMARY KEY CLUSTERED 
(
	[IdEndereco] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[EntradaProduto]    Script Date: 21/05/2016 18:06:59 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[EntradaProduto](
	[IdEntradaProduto] [int] IDENTITY(1,1) NOT NULL,
	[DataEntrada] [datetime] NULL,
	[IdUsuario] [int] NULL,
 CONSTRAINT [PK_EntradaProduto] PRIMARY KEY CLUSTERED 
(
	[IdEntradaProduto] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[EntradaProdutoNF]    Script Date: 21/05/2016 18:06:59 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[EntradaProdutoNF](
	[IdEntradaProdutoNF] [int] IDENTITY(1,1) NOT NULL,
	[IdEntradaProduto] [int] NULL,
	[IdNotaFisacal] [int] NULL,
	[IdPedidoCompra] [int] NULL,
 CONSTRAINT [PK_EntradaProdutoNF] PRIMARY KEY CLUSTERED 
(
	[IdEntradaProdutoNF] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[EquipeOrdemServico]    Script Date: 21/05/2016 18:06:59 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[EquipeOrdemServico](
	[IdEquipeOrdemServico] [int] IDENTITY(1,1) NOT NULL,
	[IdOrdemServico] [int] NULL,
	[IdFuncionario] [int] NULL,
 CONSTRAINT [PK_EquipeOrdemServico] PRIMARY KEY CLUSTERED 
(
	[IdEquipeOrdemServico] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Finalidade]    Script Date: 21/05/2016 18:06:59 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Finalidade](
	[IdFinalidade] [int] IDENTITY(1,1) NOT NULL,
	[Descricao] [varchar](50) NULL,
	[Status] [varchar](20) NULL,
 CONSTRAINT [PK_Finalidade] PRIMARY KEY CLUSTERED 
(
	[IdFinalidade] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[FormaPagamento]    Script Date: 21/05/2016 18:06:59 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[FormaPagamento](
	[IdFormaPagamento] [int] IDENTITY(1,1) NOT NULL,
	[Descricao] [varchar](50) NULL,
 CONSTRAINT [PK_FormaPagamento] PRIMARY KEY CLUSTERED 
(
	[IdFormaPagamento] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[FornecedorCotacao]    Script Date: 21/05/2016 18:06:59 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[FornecedorCotacao](
	[IdFornecedorCotacao] [int] IDENTITY(1,1) NOT NULL,
	[IdFornecedor] [int] NULL,
	[IdCotacao] [int] NULL,
	[ValorFrete] [decimal](10, 2) NULL,
	[Observacao] [varchar](150) NULL,
	[DataRetorno] [datetime] NULL,
	[IdPessoa] [int] NULL,
 CONSTRAINT [PK_FornecedorCotacao] PRIMARY KEY CLUSTERED 
(
	[IdFornecedorCotacao] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Funcionario]    Script Date: 21/05/2016 18:06:59 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Funcionario](
	[IdFuncionario] [int] IDENTITY(1,1) NOT NULL,
	[IdPessoa] [int] NULL,
	[ValorHora] [decimal](10, 2) NULL,
	[Foto] [varchar](50) NULL,
 CONSTRAINT [PK_Funcionario] PRIMARY KEY CLUSTERED 
(
	[IdFuncionario] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[HistoricoOrdemServico]    Script Date: 21/05/2016 18:06:59 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[HistoricoOrdemServico](
	[IdHistoricoOrdemServico] [int] IDENTITY(1,1) NOT NULL,
	[IdOrdemServico] [int] NULL,
	[Data] [datetime] NULL,
	[IdUsuario] [int] NULL,
	[Observacao] [varchar](250) NULL,
 CONSTRAINT [PK_HistoricoOrdemServico] PRIMARY KEY CLUSTERED 
(
	[IdHistoricoOrdemServico] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[HistoricoStatusCotacao]    Script Date: 21/05/2016 18:06:59 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[HistoricoStatusCotacao](
	[IdHistoricoStatusCotacao] [int] IDENTITY(1,1) NOT NULL,
	[IdCotacao] [int] NULL,
	[IdStatusCotacao] [int] NULL,
	[DataStatus] [nchar](10) NULL,
	[IdUsuario] [int] NULL,
 CONSTRAINT [PK_HistoricoStatusCotacao] PRIMARY KEY CLUSTERED 
(
	[IdHistoricoStatusCotacao] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[ItemEntradaEstoque]    Script Date: 21/05/2016 18:06:59 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ItemEntradaEstoque](
	[IdItemEntradaProduto] [int] IDENTITY(1,1) NOT NULL,
	[IdEntradaProduto] [int] NULL,
	[Lote] [int] NULL,
	[Quantidade] [int] NULL,
	[ValorUnitarioCusto] [decimal](10, 2) NULL,
 CONSTRAINT [PK_ItemEntradaEstoque] PRIMARY KEY CLUSTERED 
(
	[IdItemEntradaProduto] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[ItemEstoque]    Script Date: 21/05/2016 18:06:59 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ItemEstoque](
	[IdItemEstoque] [int] IDENTITY(1,1) NOT NULL,
	[IdUnidade] [int] NULL,
	[Quantidade] [int] NULL,
	[IdProduto] [int] NULL,
	[Data] [datetime] NULL,
 CONSTRAINT [PK_ItemEstoque] PRIMARY KEY CLUSTERED 
(
	[IdItemEstoque] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[ItemPedidoCompra]    Script Date: 21/05/2016 18:06:59 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ItemPedidoCompra](
	[IdItemPedidoCompra] [int] IDENTITY(1,1) NOT NULL,
	[IdItemSolicitacaoCompra] [int] NULL,
	[Quantidade] [int] NULL,
	[Valor] [decimal](10, 2) NULL,
	[IdPedidoCompra] [int] NULL,
 CONSTRAINT [PK_ItemPedidoCompra] PRIMARY KEY CLUSTERED 
(
	[IdItemPedidoCompra] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[ItemPedidoCompraCotacao]    Script Date: 21/05/2016 18:06:59 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ItemPedidoCompraCotacao](
	[IdItemPedidoCompraCotacao] [int] IDENTITY(1,1) NOT NULL,
	[IdItemSolicitacaoCompraCotatcao] [int] NULL,
	[Quantidade] [int] NULL,
	[Valor] [decimal](10, 2) NULL,
	[IdPedidoCompra] [int] NULL,
 CONSTRAINT [PK_ItemPedidoCompraCotacao] PRIMARY KEY CLUSTERED 
(
	[IdItemPedidoCompraCotacao] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[ItemProdutoNotaFiscal]    Script Date: 21/05/2016 18:06:59 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ItemProdutoNotaFiscal](
	[IdItemProdutoNotaFiscal] [int] IDENTITY(1,1) NOT NULL,
	[IdProduto] [int] NULL,
	[Lote] [int] NULL,
	[Quantidade] [int] NULL,
	[ValorUnitario] [decimal](10, 2) NULL,
	[ValorFrete] [decimal](10, 2) NULL,
	[ValorDesconto] [decimal](10, 2) NULL,
	[ValorSeguro] [decimal](10, 2) NULL,
	[IPI] [decimal](10, 2) NULL,
	[ICMS] [decimal](10, 2) NULL,
	[IdNotaFiscal] [int] NULL,
 CONSTRAINT [PK_ItemProdutoNotaFiscal] PRIMARY KEY CLUSTERED 
(
	[IdItemProdutoNotaFiscal] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[ItemReservaProduto]    Script Date: 21/05/2016 18:06:59 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[ItemReservaProduto](
	[IdItemReservaProduto] [int] IDENTITY(1,1) NOT NULL,
	[IdProduto] [int] NULL,
	[Quantidade] [int] NULL,
	[DataSeparacao] [datetime] NULL,
	[DataAtual] [datetime] NULL,
	[Status] [varchar](20) NULL,
	[IdVendaProduto] [int] NULL,
	[IdTE] [int] NULL,
	[QtdTotalEstoque] [int] NULL,
	[IdUnidade] [int] NULL,
	[IdReserva] [int] NULL,
 CONSTRAINT [PK_ItemReservaProduto] PRIMARY KEY CLUSTERED 
(
	[IdItemReservaProduto] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[ItemReservaVendaProduto]    Script Date: 21/05/2016 18:06:59 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[ItemReservaVendaProduto](
	[IdItemReservaProduto] [int] IDENTITY(1,1) NOT NULL,
	[IdProduto] [int] NULL,
	[Quantidade] [int] NULL,
	[DataSeparacao] [datetime] NULL,
	[DataAtual] [datetime] NULL,
	[Status] [varchar](20) NULL,
	[IdVendaProduto] [int] NULL,
	[IdTE] [int] NULL,
	[QtdTotalEstoque] [int] NULL,
	[IdUnidade] [int] NULL,
	[IdReserva] [int] NULL,
 CONSTRAINT [PK_ItemReservaVendaProduto] PRIMARY KEY CLUSTERED 
(
	[IdItemReservaProduto] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[ItemRetornoCotacao]    Script Date: 21/05/2016 18:06:59 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ItemRetornoCotacao](
	[IdItemRetornoCotacao] [int] IDENTITY(1,1) NOT NULL,
	[IdProdutoCotacao] [int] NULL,
	[IdFornecedorCotacao] [int] NULL,
	[QuantidadeFornecedor] [decimal](10, 2) NULL,
	[ValorUnitarioFornecedor] [decimal](10, 2) NULL,
	[DiasParaEntrega] [int] NULL,
 CONSTRAINT [PK_ItemRetornoCotacao] PRIMARY KEY CLUSTERED 
(
	[IdItemRetornoCotacao] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[ItemSolicitacaoCompra]    Script Date: 21/05/2016 18:06:59 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ItemSolicitacaoCompra](
	[IdItemSolicitacaoCompra] [int] IDENTITY(1,1) NOT NULL,
	[IdSolicitacaoCompra] [int] NULL,
	[IdProduto] [int] NULL,
	[IdFornecedor] [int] NULL,
	[Quantidade] [int] NULL,
	[ValorUnitario] [decimal](10, 2) NULL,
 CONSTRAINT [PK_ItemSolicitacaoCompra] PRIMARY KEY CLUSTERED 
(
	[IdItemSolicitacaoCompra] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[ItemSolicitacaoCompraCotacao]    Script Date: 21/05/2016 18:06:59 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ItemSolicitacaoCompraCotacao](
	[IdItemSolicitacaoCompraCotacao] [int] IDENTITY(1,1) NOT NULL,
	[IdSolicitacaoCompra] [int] NULL,
	[IdItemRetornoCotacao] [int] NULL,
	[Quantidade] [int] NULL,
	[ValorUnitario] [decimal](10, 2) NULL,
 CONSTRAINT [PK_ItemSolicitacaoCompraCotacao] PRIMARY KEY CLUSTERED 
(
	[IdItemSolicitacaoCompraCotacao] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[ItemTransferenciaEstoque]    Script Date: 21/05/2016 18:06:59 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[ItemTransferenciaEstoque](
	[IdItemTransferenciaEstoque] [int] IDENTITY(1,1) NOT NULL,
	[IdProduto] [int] NULL,
	[Quantidade] [int] NULL,
	[Status] [varchar](20) NULL,
	[IdLocalOrigem] [int] NULL,
	[IdLocalDestino] [int] NULL,
	[IdTE] [int] NULL,
 CONSTRAINT [PK_ItemTransferenciaEstoque] PRIMARY KEY CLUSTERED 
(
	[IdItemTransferenciaEstoque] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[ItemVendaEstoque]    Script Date: 21/05/2016 18:06:59 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ItemVendaEstoque](
	[IdItemVendaEstoque] [int] IDENTITY(1,1) NOT NULL,
	[IdVendaProduto] [int] NULL,
	[Quantidade] [int] NULL,
	[Valor] [int] NULL,
	[IdProduto] [int] NULL,
	[desconto] [decimal](10, 2) NULL,
 CONSTRAINT [PK_ItemVendaEstoque] PRIMARY KEY CLUSTERED 
(
	[IdItemVendaEstoque] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[MarcaProduto]    Script Date: 21/05/2016 18:06:59 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[MarcaProduto](
	[IdMarcaProduto] [int] IDENTITY(1,1) NOT NULL,
	[Descricao] [varchar](50) NULL,
	[Status] [varchar](20) NULL,
 CONSTRAINT [PK_MarcaProduto] PRIMARY KEY CLUSTERED 
(
	[IdMarcaProduto] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[NotaFiscal]    Script Date: 21/05/2016 18:06:59 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[NotaFiscal](
	[IdNotaFiscal] [int] IDENTITY(1,1) NOT NULL,
	[NumeroNF] [int] NULL,
	[Serie] [int] NULL,
	[CodRegimeTrib] [int] NULL,
	[Data] [datetime] NULL,
	[ChaveAcesso] [varchar](30) NULL,
	[PalavrasChave] [varchar](20) NULL,
	[Observacoes] [varchar](100) NULL,
 CONSTRAINT [PK_NotaFiscal] PRIMARY KEY CLUSTERED 
(
	[IdNotaFiscal] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[OrdemServico]    Script Date: 21/05/2016 18:06:59 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[OrdemServico](
	[IdOrdemServico] [int] IDENTITY(1,1) NOT NULL,
	[IdPessoa] [int] NULL,
	[IdStatusOrdemServico] [int] NULL,
	[Prioridade] [bit] NULL,
	[Titulo] [varchar](100) NULL,
	[Descricao] [varchar](250) NULL,
 CONSTRAINT [PK_OrdemServico] PRIMARY KEY CLUSTERED 
(
	[IdOrdemServico] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[PagamentoOrdemServico]    Script Date: 21/05/2016 18:06:59 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[PagamentoOrdemServico](
	[IdPagamentoOrdemServico] [int] IDENTITY(1,1) NOT NULL,
	[NumeroParcela] [int] NULL,
	[Status] [varchar](20) NULL,
	[NumeroDocumento] [varchar](50) NULL,
	[Valor] [decimal](10, 2) NULL,
	[DataVencimento] [datetime] NULL,
	[ValorPago] [decimal](10, 2) NULL,
	[DataPagamento] [datetime] NULL,
	[IdOrdemServico] [int] NULL,
 CONSTRAINT [PK_PagamentoOrdemServico] PRIMARY KEY CLUSTERED 
(
	[IdPagamentoOrdemServico] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[PagamentoPedidoCompra]    Script Date: 21/05/2016 18:06:59 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[PagamentoPedidoCompra](
	[IdPagamentoPedidoCompra] [int] IDENTITY(1,1) NOT NULL,
	[IdPedidoCompra] [int] NULL,
	[Parcela] [int] NULL,
	[IdFormaPagamento] [int] NULL,
	[NumeroDocumento] [varchar](20) NULL,
	[Valor] [decimal](10, 2) NULL,
	[DataVencimento] [datetime] NULL,
	[ValorPago] [decimal](10, 2) NULL,
	[DataPagamento] [datetime] NULL,
	[Status] [varchar](20) NULL,
 CONSTRAINT [PK_PagamentoPedidoCompra] PRIMARY KEY CLUSTERED 
(
	[IdPagamentoPedidoCompra] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[PagamentoRetornoCotacao]    Script Date: 21/05/2016 18:06:59 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[PagamentoRetornoCotacao](
	[IdPagamentoRetorno] [int] IDENTITY(1,1) NOT NULL,
	[IdCotacao] [int] NULL,
	[IdFormaPagamento] [int] NULL,
	[Parcela] [int] NULL,
	[DataVencimento] [datetime] NULL,
	[ValorPago] [decimal](10, 2) NULL,
 CONSTRAINT [PK_PagamentoRetornoCotacao] PRIMARY KEY CLUSTERED 
(
	[IdPagamentoRetorno] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[PedidoCompra]    Script Date: 21/05/2016 18:06:59 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[PedidoCompra](
	[IdPedidoCompra] [int] IDENTITY(1,1) NOT NULL,
	[Data] [datetime] NULL,
	[Automatico] [varchar](20) NULL,
	[Status] [varchar](20) NULL,
 CONSTRAINT [PK_PedidoCompra] PRIMARY KEY CLUSTERED 
(
	[IdPedidoCompra] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Pessoa]    Script Date: 21/05/2016 18:06:59 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Pessoa](
	[IdPessoa] [int] IDENTITY(1,1) NOT NULL,
	[Nome] [varchar](100) NULL,
	[Status] [varchar](20) NULL,
	[TipoCadastro] [bit] NULL,
 CONSTRAINT [PK_Pessoa] PRIMARY KEY CLUSTERED 
(
	[IdPessoa] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[PessoaFisica]    Script Date: 21/05/2016 18:06:59 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[PessoaFisica](
	[IdPessoaFisica] [int] IDENTITY(1,1) NOT NULL,
	[CPF] [varchar](11) NULL,
	[RG] [varchar](9) NULL,
	[DataNascimento] [datetime] NULL,
	[Sexo] [char](1) NULL,
	[IdPessoa] [int] NULL,
 CONSTRAINT [PK_PessoaFisica] PRIMARY KEY CLUSTERED 
(
	[IdPessoaFisica] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[PessoaJuridica]    Script Date: 21/05/2016 18:06:59 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[PessoaJuridica](
	[IdPessoaJuridica] [int] IDENTITY(1,1) NOT NULL,
	[CNPJ] [varchar](14) NULL,
	[IE] [varchar](20) NULL,
	[IdPessoa] [int] NULL,
 CONSTRAINT [PK_PessoaJuridica] PRIMARY KEY CLUSTERED 
(
	[IdPessoaJuridica] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Produto]    Script Date: 21/05/2016 18:06:59 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Produto](
	[IdProduto] [int] IDENTITY(1,1) NOT NULL,
	[IdUnidadeMedida] [int] NULL,
	[IdMarcaProduto] [int] NULL,
	[IdTipoProduto] [int] NULL,
	[Nome] [varchar](100) NULL,
	[QtdMinimaEstoque] [int] NULL,
	[CodigoBarras] [varchar](50) NULL,
	[Observacoes] [varchar](100) NULL,
	[Status] [varchar](20) NULL,
	[DataValidade] [datetime] NULL,
 CONSTRAINT [PK_Produto] PRIMARY KEY CLUSTERED 
(
	[IdProduto] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[ProdutoCotacao]    Script Date: 21/05/2016 18:06:59 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ProdutoCotacao](
	[IdProdutoCotacao] [int] IDENTITY(1,1) NOT NULL,
	[IdProduto] [int] NULL,
	[IdCotacao] [int] NULL,
	[IdDepartamento] [int] NULL,
	[IdFinalidade] [int] NULL,
	[QuantidadeCotada] [decimal](10, 2) NULL,
 CONSTRAINT [PK_ProdutoCotacao] PRIMARY KEY CLUSTERED 
(
	[IdProdutoCotacao] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Profissao]    Script Date: 21/05/2016 18:06:59 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Profissao](
	[IdProfissoes] [int] IDENTITY(1,1) NOT NULL,
	[Nome] [varchar](100) NULL,
	[Status] [bit] NULL,
 CONSTRAINT [PK_Profissao] PRIMARY KEY CLUSTERED 
(
	[IdProfissoes] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[ProfissaoFuncionario]    Script Date: 21/05/2016 18:06:59 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ProfissaoFuncionario](
	[IdProfissaoFuncionario] [int] IDENTITY(1,1) NOT NULL,
	[IdProfissao] [int] NULL,
	[IdFuncionario] [int] NULL,
	[DataInicio] [datetime] NULL,
	[DataFim] [datetime] NULL,
 CONSTRAINT [PK_ProfissaoFuncionario] PRIMARY KEY CLUSTERED 
(
	[IdProfissaoFuncionario] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Reserva]    Script Date: 21/05/2016 18:06:59 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Reserva](
	[IdReserva] [int] IDENTITY(1,1) NOT NULL,
	[Data] [datetime] NULL,
	[Status] [varchar](20) NULL,
	[IdUsuario] [int] NULL,
	[IdUnidade] [int] NULL,
 CONSTRAINT [PK_Reserva] PRIMARY KEY CLUSTERED 
(
	[IdReserva] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[SolicitacaoCompra]    Script Date: 21/05/2016 18:06:59 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[SolicitacaoCompra](
	[IdSolicitacaoCompra] [int] IDENTITY(1,1) NOT NULL,
	[IdAprovador] [int] NULL,
	[Data] [datetime] NULL,
 CONSTRAINT [PK_SolicitacaoCompra] PRIMARY KEY CLUSTERED 
(
	[IdSolicitacaoCompra] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[SolicitacaoPedidoCompra]    Script Date: 21/05/2016 18:06:59 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[SolicitacaoPedidoCompra](
	[IdSolicitacaoPedidoCompra] [int] IDENTITY(1,1) NOT NULL,
	[IdSolicitacaoCompra] [int] NULL,
	[IdPedidoCompra] [int] NULL,
 CONSTRAINT [PK_SolicitacaoPedidoCompra] PRIMARY KEY CLUSTERED 
(
	[IdSolicitacaoPedidoCompra] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[StatusCotacao]    Script Date: 21/05/2016 18:06:59 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[StatusCotacao](
	[IdStatusCotacao] [int] IDENTITY(1,1) NOT NULL,
	[Descricao] [varchar](50) NULL,
 CONSTRAINT [PK_StatusCotacao] PRIMARY KEY CLUSTERED 
(
	[IdStatusCotacao] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[StatusOrdemServico]    Script Date: 21/05/2016 18:06:59 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[StatusOrdemServico](
	[IdStatusOrdemServico] [int] IDENTITY(1,1) NOT NULL,
	[Descricao] [varchar](100) NULL,
	[Status] [varchar](20) NULL,
 CONSTRAINT [PK_StatusOrdemServico] PRIMARY KEY CLUSTERED 
(
	[IdStatusOrdemServico] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[TabelaPreco]    Script Date: 21/05/2016 18:06:59 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TabelaPreco](
	[IdTabelaPreco] [int] IDENTITY(1,1) NOT NULL,
	[IdProduto] [int] NULL,
	[ValorUnitarioVenda] [decimal](10, 2) NULL,
	[DataVenda] [datetime] NULL,
 CONSTRAINT [PK_TabelaPreco] PRIMARY KEY CLUSTERED 
(
	[IdTabelaPreco] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Telefone]    Script Date: 21/05/2016 18:06:59 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Telefone](
	[IdTelefone] [int] IDENTITY(1,1) NOT NULL,
	[Tipo] [varchar](20) NULL,
	[DDD] [varchar](2) NULL,
	[Telefone] [varchar](10) NULL,
	[IdPessoa] [int] NULL,
 CONSTRAINT [PK_Telefone] PRIMARY KEY CLUSTERED 
(
	[IdTelefone] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[TipoProduto]    Script Date: 21/05/2016 18:06:59 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[TipoProduto](
	[IdTipoProduto] [int] IDENTITY(1,1) NOT NULL,
	[Descricao] [varchar](50) NULL,
	[Status] [varchar](20) NULL,
 CONSTRAINT [PK_TipoProduto] PRIMARY KEY CLUSTERED 
(
	[IdTipoProduto] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[TransferenciaEstoque]    Script Date: 21/05/2016 18:06:59 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[TransferenciaEstoque](
	[IdTE] [int] IDENTITY(1,1) NOT NULL,
	[Status] [varchar](20) NULL,
	[DataSeparacao] [datetime] NULL,
	[DataAtual] [datetime] NULL,
	[IdOperador] [int] NULL,
 CONSTRAINT [PK_TransferenciaEstoque] PRIMARY KEY CLUSTERED 
(
	[IdTE] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Unidade]    Script Date: 21/05/2016 18:06:59 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Unidade](
	[IdUnidade] [int] IDENTITY(1,1) NOT NULL,
	[IdPessoaJuridica] [int] NULL,
	[IdMatriz] [int] NULL,
 CONSTRAINT [PK_Unidade] PRIMARY KEY CLUSTERED 
(
	[IdUnidade] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[UnidadeMedida]    Script Date: 21/05/2016 18:06:59 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[UnidadeMedida](
	[IdUnidadeMedida] [int] IDENTITY(1,1) NOT NULL,
	[Descricao] [varchar](50) NULL,
	[Status] [varchar](20) NULL,
 CONSTRAINT [PK_UnidadeMedida] PRIMARY KEY CLUSTERED 
(
	[IdUnidadeMedida] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Usuario]    Script Date: 21/05/2016 18:06:59 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Usuario](
	[IdUsuario] [int] IDENTITY(1,1) NOT NULL,
	[IdPessoa] [int] NULL,
	[Login] [varchar](20) NULL,
	[Senha] [varchar](20) NULL,
	[Status] [bit] NULL,
 CONSTRAINT [PK_Usuario] PRIMARY KEY CLUSTERED 
(
	[IdUsuario] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[VendaProduto]    Script Date: 21/05/2016 18:06:59 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[VendaProduto](
	[IdVendaProduto] [int] IDENTITY(1,1) NOT NULL,
	[DataVenda] [datetime] NULL,
	[IdVendedor] [int] NULL,
	[IdCliente] [int] NULL,
	[IdEndereco] [int] NULL,
	[IdUnidade] [int] NULL,
	[CodigoVenda] [int] NULL,
 CONSTRAINT [PK_VendaProduto] PRIMARY KEY CLUSTERED 
(
	[IdVendaProduto] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[VendaProdutoNF]    Script Date: 21/05/2016 18:06:59 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[VendaProdutoNF](
	[IdVendaProdutoNF] [int] IDENTITY(1,1) NOT NULL,
	[IdVendaProduto] [int] NULL,
	[IdNotaFiscal] [int] NULL,
 CONSTRAINT [PK_VendaProdutoNF] PRIMARY KEY CLUSTERED 
(
	[IdVendaProdutoNF] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
ALTER TABLE [dbo].[AcessoUsuario]  WITH CHECK ADD  CONSTRAINT [FK_AcessoUsuario_Acesso] FOREIGN KEY([IdAcesso])
REFERENCES [dbo].[Acesso] ([IdAcesso])
GO
ALTER TABLE [dbo].[AcessoUsuario] CHECK CONSTRAINT [FK_AcessoUsuario_Acesso]
GO
ALTER TABLE [dbo].[AcessoUsuario]  WITH CHECK ADD  CONSTRAINT [FK_AcessoUsuario_Usuario] FOREIGN KEY([IdUsuario])
REFERENCES [dbo].[Usuario] ([IdUsuario])
GO
ALTER TABLE [dbo].[AcessoUsuario] CHECK CONSTRAINT [FK_AcessoUsuario_Usuario]
GO
ALTER TABLE [dbo].[ArquivosOrdemServico]  WITH CHECK ADD  CONSTRAINT [FK_ArquivosOrdemServico_OrdemServico] FOREIGN KEY([IdOrdemServico])
REFERENCES [dbo].[OrdemServico] ([IdOrdemServico])
GO
ALTER TABLE [dbo].[ArquivosOrdemServico] CHECK CONSTRAINT [FK_ArquivosOrdemServico_OrdemServico]
GO
ALTER TABLE [dbo].[Cotacao]  WITH CHECK ADD  CONSTRAINT [FK_Cotacao_StatusCotacao] FOREIGN KEY([IdStatusCotacao])
REFERENCES [dbo].[StatusCotacao] ([IdStatusCotacao])
GO
ALTER TABLE [dbo].[Cotacao] CHECK CONSTRAINT [FK_Cotacao_StatusCotacao]
GO
ALTER TABLE [dbo].[Email]  WITH CHECK ADD  CONSTRAINT [FK_Email_Pessoa] FOREIGN KEY([IdPessoa])
REFERENCES [dbo].[Pessoa] ([IdPessoa])
GO
ALTER TABLE [dbo].[Email] CHECK CONSTRAINT [FK_Email_Pessoa]
GO
ALTER TABLE [dbo].[Endereco]  WITH CHECK ADD  CONSTRAINT [FK_Endereco_Pessoa] FOREIGN KEY([IdPessoa])
REFERENCES [dbo].[Pessoa] ([IdPessoa])
GO
ALTER TABLE [dbo].[Endereco] CHECK CONSTRAINT [FK_Endereco_Pessoa]
GO
ALTER TABLE [dbo].[EntradaProdutoNF]  WITH CHECK ADD  CONSTRAINT [FK_EntradaProdutoNF_EntradaProduto] FOREIGN KEY([IdEntradaProduto])
REFERENCES [dbo].[EntradaProduto] ([IdEntradaProduto])
GO
ALTER TABLE [dbo].[EntradaProdutoNF] CHECK CONSTRAINT [FK_EntradaProdutoNF_EntradaProduto]
GO
ALTER TABLE [dbo].[EntradaProdutoNF]  WITH CHECK ADD  CONSTRAINT [FK_EntradaProdutoNF_NotaFiscal] FOREIGN KEY([IdNotaFisacal])
REFERENCES [dbo].[NotaFiscal] ([IdNotaFiscal])
GO
ALTER TABLE [dbo].[EntradaProdutoNF] CHECK CONSTRAINT [FK_EntradaProdutoNF_NotaFiscal]
GO
ALTER TABLE [dbo].[EntradaProdutoNF]  WITH CHECK ADD  CONSTRAINT [FK_EntradaProdutoNF_PedidoCompra] FOREIGN KEY([IdPedidoCompra])
REFERENCES [dbo].[PedidoCompra] ([IdPedidoCompra])
GO
ALTER TABLE [dbo].[EntradaProdutoNF] CHECK CONSTRAINT [FK_EntradaProdutoNF_PedidoCompra]
GO
ALTER TABLE [dbo].[EquipeOrdemServico]  WITH CHECK ADD  CONSTRAINT [FK_EquipeOrdemServico_OrdemServico] FOREIGN KEY([IdOrdemServico])
REFERENCES [dbo].[OrdemServico] ([IdOrdemServico])
GO
ALTER TABLE [dbo].[EquipeOrdemServico] CHECK CONSTRAINT [FK_EquipeOrdemServico_OrdemServico]
GO
ALTER TABLE [dbo].[FornecedorCotacao]  WITH CHECK ADD  CONSTRAINT [FK_FornecedorCotacao_Cotacao] FOREIGN KEY([IdCotacao])
REFERENCES [dbo].[Cotacao] ([IdCotacao])
GO
ALTER TABLE [dbo].[FornecedorCotacao] CHECK CONSTRAINT [FK_FornecedorCotacao_Cotacao]
GO
ALTER TABLE [dbo].[FornecedorCotacao]  WITH CHECK ADD  CONSTRAINT [FK_FornecedorCotacao_Pessoa] FOREIGN KEY([IdPessoa])
REFERENCES [dbo].[Pessoa] ([IdPessoa])
GO
ALTER TABLE [dbo].[FornecedorCotacao] CHECK CONSTRAINT [FK_FornecedorCotacao_Pessoa]
GO
ALTER TABLE [dbo].[HistoricoOrdemServico]  WITH CHECK ADD  CONSTRAINT [FK_HistoricoOrdemServico_OrdemServico] FOREIGN KEY([IdOrdemServico])
REFERENCES [dbo].[OrdemServico] ([IdOrdemServico])
GO
ALTER TABLE [dbo].[HistoricoOrdemServico] CHECK CONSTRAINT [FK_HistoricoOrdemServico_OrdemServico]
GO
ALTER TABLE [dbo].[HistoricoStatusCotacao]  WITH CHECK ADD  CONSTRAINT [FK_HistoricoStatusCotacao_Cotacao] FOREIGN KEY([IdCotacao])
REFERENCES [dbo].[Cotacao] ([IdCotacao])
GO
ALTER TABLE [dbo].[HistoricoStatusCotacao] CHECK CONSTRAINT [FK_HistoricoStatusCotacao_Cotacao]
GO
ALTER TABLE [dbo].[HistoricoStatusCotacao]  WITH CHECK ADD  CONSTRAINT [FK_HistoricoStatusCotacao_StatusCotacao] FOREIGN KEY([IdStatusCotacao])
REFERENCES [dbo].[StatusCotacao] ([IdStatusCotacao])
GO
ALTER TABLE [dbo].[HistoricoStatusCotacao] CHECK CONSTRAINT [FK_HistoricoStatusCotacao_StatusCotacao]
GO
ALTER TABLE [dbo].[HistoricoStatusCotacao]  WITH CHECK ADD  CONSTRAINT [FK_HistoricoStatusCotacao_Usuario] FOREIGN KEY([IdUsuario])
REFERENCES [dbo].[Usuario] ([IdUsuario])
GO
ALTER TABLE [dbo].[HistoricoStatusCotacao] CHECK CONSTRAINT [FK_HistoricoStatusCotacao_Usuario]
GO
ALTER TABLE [dbo].[ItemEntradaEstoque]  WITH CHECK ADD  CONSTRAINT [FK_ItemEntradaEstoque_EntradaProduto] FOREIGN KEY([IdEntradaProduto])
REFERENCES [dbo].[EntradaProduto] ([IdEntradaProduto])
GO
ALTER TABLE [dbo].[ItemEntradaEstoque] CHECK CONSTRAINT [FK_ItemEntradaEstoque_EntradaProduto]
GO
ALTER TABLE [dbo].[ItemEstoque]  WITH CHECK ADD  CONSTRAINT [FK_ItemEstoque_Produto] FOREIGN KEY([IdProduto])
REFERENCES [dbo].[Produto] ([IdProduto])
GO
ALTER TABLE [dbo].[ItemEstoque] CHECK CONSTRAINT [FK_ItemEstoque_Produto]
GO
ALTER TABLE [dbo].[ItemEstoque]  WITH CHECK ADD  CONSTRAINT [FK_ItemEstoque_Unidade] FOREIGN KEY([IdUnidade])
REFERENCES [dbo].[Unidade] ([IdUnidade])
GO
ALTER TABLE [dbo].[ItemEstoque] CHECK CONSTRAINT [FK_ItemEstoque_Unidade]
GO
ALTER TABLE [dbo].[ItemPedidoCompra]  WITH CHECK ADD  CONSTRAINT [FK_ItemPedidoCompra_ItemSolicitacaoCompra] FOREIGN KEY([IdItemSolicitacaoCompra])
REFERENCES [dbo].[ItemSolicitacaoCompra] ([IdItemSolicitacaoCompra])
GO
ALTER TABLE [dbo].[ItemPedidoCompra] CHECK CONSTRAINT [FK_ItemPedidoCompra_ItemSolicitacaoCompra]
GO
ALTER TABLE [dbo].[ItemPedidoCompra]  WITH CHECK ADD  CONSTRAINT [FK_ItemPedidoCompra_PedidoCompra] FOREIGN KEY([IdPedidoCompra])
REFERENCES [dbo].[PedidoCompra] ([IdPedidoCompra])
GO
ALTER TABLE [dbo].[ItemPedidoCompra] CHECK CONSTRAINT [FK_ItemPedidoCompra_PedidoCompra]
GO
ALTER TABLE [dbo].[ItemPedidoCompraCotacao]  WITH CHECK ADD  CONSTRAINT [FK_ItemPedidoCompraCotacao_ItemSolicitacaoCompraCotacao] FOREIGN KEY([IdItemSolicitacaoCompraCotatcao])
REFERENCES [dbo].[ItemSolicitacaoCompraCotacao] ([IdItemSolicitacaoCompraCotacao])
GO
ALTER TABLE [dbo].[ItemPedidoCompraCotacao] CHECK CONSTRAINT [FK_ItemPedidoCompraCotacao_ItemSolicitacaoCompraCotacao]
GO
ALTER TABLE [dbo].[ItemPedidoCompraCotacao]  WITH CHECK ADD  CONSTRAINT [FK_ItemPedidoCompraCotacao_PedidoCompra] FOREIGN KEY([IdPedidoCompra])
REFERENCES [dbo].[PedidoCompra] ([IdPedidoCompra])
GO
ALTER TABLE [dbo].[ItemPedidoCompraCotacao] CHECK CONSTRAINT [FK_ItemPedidoCompraCotacao_PedidoCompra]
GO
ALTER TABLE [dbo].[ItemProdutoNotaFiscal]  WITH CHECK ADD  CONSTRAINT [FK_ItemProdutoNotaFiscal_NotaFiscal] FOREIGN KEY([IdNotaFiscal])
REFERENCES [dbo].[NotaFiscal] ([IdNotaFiscal])
GO
ALTER TABLE [dbo].[ItemProdutoNotaFiscal] CHECK CONSTRAINT [FK_ItemProdutoNotaFiscal_NotaFiscal]
GO
ALTER TABLE [dbo].[ItemProdutoNotaFiscal]  WITH CHECK ADD  CONSTRAINT [FK_ItemProdutoNotaFiscal_Produto] FOREIGN KEY([IdProduto])
REFERENCES [dbo].[Produto] ([IdProduto])
GO
ALTER TABLE [dbo].[ItemProdutoNotaFiscal] CHECK CONSTRAINT [FK_ItemProdutoNotaFiscal_Produto]
GO
ALTER TABLE [dbo].[ItemReservaProduto]  WITH CHECK ADD  CONSTRAINT [FK_ItemReservaProduto_Reserva] FOREIGN KEY([IdReserva])
REFERENCES [dbo].[Reserva] ([IdReserva])
GO
ALTER TABLE [dbo].[ItemReservaProduto] CHECK CONSTRAINT [FK_ItemReservaProduto_Reserva]
GO
ALTER TABLE [dbo].[ItemReservaProduto]  WITH CHECK ADD  CONSTRAINT [FK_ItemReservaProduto_TransferenciaEstoque] FOREIGN KEY([IdTE])
REFERENCES [dbo].[TransferenciaEstoque] ([IdTE])
GO
ALTER TABLE [dbo].[ItemReservaProduto] CHECK CONSTRAINT [FK_ItemReservaProduto_TransferenciaEstoque]
GO
ALTER TABLE [dbo].[ItemReservaProduto]  WITH CHECK ADD  CONSTRAINT [FK_ItemReservaProduto_VendaProduto] FOREIGN KEY([IdVendaProduto])
REFERENCES [dbo].[VendaProduto] ([IdVendaProduto])
GO
ALTER TABLE [dbo].[ItemReservaProduto] CHECK CONSTRAINT [FK_ItemReservaProduto_VendaProduto]
GO
ALTER TABLE [dbo].[ItemReservaProduto]  WITH CHECK ADD  CONSTRAINT [FK_ItemReservaVendaProduto_Produto] FOREIGN KEY([IdProduto])
REFERENCES [dbo].[Produto] ([IdProduto])
GO
ALTER TABLE [dbo].[ItemReservaProduto] CHECK CONSTRAINT [FK_ItemReservaVendaProduto_Produto]
GO
ALTER TABLE [dbo].[ItemReservaVendaProduto]  WITH CHECK ADD  CONSTRAINT [FK_ItemReservaVendaProduto_Reserva] FOREIGN KEY([IdReserva])
REFERENCES [dbo].[Reserva] ([IdReserva])
GO
ALTER TABLE [dbo].[ItemReservaVendaProduto] CHECK CONSTRAINT [FK_ItemReservaVendaProduto_Reserva]
GO
ALTER TABLE [dbo].[ItemReservaVendaProduto]  WITH CHECK ADD  CONSTRAINT [FK_ItemReservaVendaProduto_TransferenciaEstoque] FOREIGN KEY([IdTE])
REFERENCES [dbo].[TransferenciaEstoque] ([IdTE])
GO
ALTER TABLE [dbo].[ItemReservaVendaProduto] CHECK CONSTRAINT [FK_ItemReservaVendaProduto_TransferenciaEstoque]
GO
ALTER TABLE [dbo].[ItemReservaVendaProduto]  WITH CHECK ADD  CONSTRAINT [FK_ItemReservaVendaProduto_Unidade] FOREIGN KEY([IdUnidade])
REFERENCES [dbo].[Unidade] ([IdUnidade])
GO
ALTER TABLE [dbo].[ItemReservaVendaProduto] CHECK CONSTRAINT [FK_ItemReservaVendaProduto_Unidade]
GO
ALTER TABLE [dbo].[ItemReservaVendaProduto]  WITH CHECK ADD  CONSTRAINT [FK_ItemReservaVendaProduto_VendaProduto] FOREIGN KEY([IdVendaProduto])
REFERENCES [dbo].[VendaProduto] ([IdVendaProduto])
GO
ALTER TABLE [dbo].[ItemReservaVendaProduto] CHECK CONSTRAINT [FK_ItemReservaVendaProduto_VendaProduto]
GO
ALTER TABLE [dbo].[ItemRetornoCotacao]  WITH CHECK ADD  CONSTRAINT [FK_ItemRetornoCotacao_FornecedorCotacao] FOREIGN KEY([IdFornecedorCotacao])
REFERENCES [dbo].[FornecedorCotacao] ([IdFornecedorCotacao])
GO
ALTER TABLE [dbo].[ItemRetornoCotacao] CHECK CONSTRAINT [FK_ItemRetornoCotacao_FornecedorCotacao]
GO
ALTER TABLE [dbo].[ItemRetornoCotacao]  WITH CHECK ADD  CONSTRAINT [FK_ItemRetornoCotacao_ProdutoCotacao] FOREIGN KEY([IdProdutoCotacao])
REFERENCES [dbo].[ProdutoCotacao] ([IdProdutoCotacao])
GO
ALTER TABLE [dbo].[ItemRetornoCotacao] CHECK CONSTRAINT [FK_ItemRetornoCotacao_ProdutoCotacao]
GO
ALTER TABLE [dbo].[ItemSolicitacaoCompra]  WITH CHECK ADD  CONSTRAINT [FK_ItemSolicitacaoCompra_SolicitacaoCompra] FOREIGN KEY([IdSolicitacaoCompra])
REFERENCES [dbo].[SolicitacaoCompra] ([IdSolicitacaoCompra])
GO
ALTER TABLE [dbo].[ItemSolicitacaoCompra] CHECK CONSTRAINT [FK_ItemSolicitacaoCompra_SolicitacaoCompra]
GO
ALTER TABLE [dbo].[ItemSolicitacaoCompraCotacao]  WITH CHECK ADD  CONSTRAINT [FK_ItemSolicitacaoCompraCotacao_ItemRetornoCotacao] FOREIGN KEY([IdItemRetornoCotacao])
REFERENCES [dbo].[ItemRetornoCotacao] ([IdItemRetornoCotacao])
GO
ALTER TABLE [dbo].[ItemSolicitacaoCompraCotacao] CHECK CONSTRAINT [FK_ItemSolicitacaoCompraCotacao_ItemRetornoCotacao]
GO
ALTER TABLE [dbo].[ItemSolicitacaoCompraCotacao]  WITH CHECK ADD  CONSTRAINT [FK_ItemSolicitacaoCompraCotacao_SolicitacaoCompra] FOREIGN KEY([IdSolicitacaoCompra])
REFERENCES [dbo].[SolicitacaoCompra] ([IdSolicitacaoCompra])
GO
ALTER TABLE [dbo].[ItemSolicitacaoCompraCotacao] CHECK CONSTRAINT [FK_ItemSolicitacaoCompraCotacao_SolicitacaoCompra]
GO
ALTER TABLE [dbo].[ItemTransferenciaEstoque]  WITH CHECK ADD  CONSTRAINT [FK_ItemTransferenciaEstoque_Produto] FOREIGN KEY([IdProduto])
REFERENCES [dbo].[Produto] ([IdProduto])
GO
ALTER TABLE [dbo].[ItemTransferenciaEstoque] CHECK CONSTRAINT [FK_ItemTransferenciaEstoque_Produto]
GO
ALTER TABLE [dbo].[ItemTransferenciaEstoque]  WITH CHECK ADD  CONSTRAINT [FK_ItemTransferenciaEstoque_TransferenciaEstoque] FOREIGN KEY([IdTE])
REFERENCES [dbo].[TransferenciaEstoque] ([IdTE])
GO
ALTER TABLE [dbo].[ItemTransferenciaEstoque] CHECK CONSTRAINT [FK_ItemTransferenciaEstoque_TransferenciaEstoque]
GO
ALTER TABLE [dbo].[ItemTransferenciaEstoque]  WITH CHECK ADD  CONSTRAINT [FK_ItemTransferenciaEstoque_UnidadeDestino] FOREIGN KEY([IdLocalDestino])
REFERENCES [dbo].[Unidade] ([IdUnidade])
GO
ALTER TABLE [dbo].[ItemTransferenciaEstoque] CHECK CONSTRAINT [FK_ItemTransferenciaEstoque_UnidadeDestino]
GO
ALTER TABLE [dbo].[ItemTransferenciaEstoque]  WITH CHECK ADD  CONSTRAINT [FK_ItemTransferenciaEstoque_UnidadeOrigem] FOREIGN KEY([IdLocalOrigem])
REFERENCES [dbo].[Unidade] ([IdUnidade])
GO
ALTER TABLE [dbo].[ItemTransferenciaEstoque] CHECK CONSTRAINT [FK_ItemTransferenciaEstoque_UnidadeOrigem]
GO
ALTER TABLE [dbo].[ItemVendaEstoque]  WITH CHECK ADD  CONSTRAINT [FK_ItemVendaEstoque_Produto] FOREIGN KEY([IdProduto])
REFERENCES [dbo].[Produto] ([IdProduto])
GO
ALTER TABLE [dbo].[ItemVendaEstoque] CHECK CONSTRAINT [FK_ItemVendaEstoque_Produto]
GO
ALTER TABLE [dbo].[ItemVendaEstoque]  WITH CHECK ADD  CONSTRAINT [FK_ItemVendaEstoque_VendaProduto] FOREIGN KEY([IdVendaProduto])
REFERENCES [dbo].[VendaProduto] ([IdVendaProduto])
GO
ALTER TABLE [dbo].[ItemVendaEstoque] CHECK CONSTRAINT [FK_ItemVendaEstoque_VendaProduto]
GO
ALTER TABLE [dbo].[OrdemServico]  WITH CHECK ADD  CONSTRAINT [FK_OrdemServico_Pessoa] FOREIGN KEY([IdPessoa])
REFERENCES [dbo].[Pessoa] ([IdPessoa])
GO
ALTER TABLE [dbo].[OrdemServico] CHECK CONSTRAINT [FK_OrdemServico_Pessoa]
GO
ALTER TABLE [dbo].[OrdemServico]  WITH CHECK ADD  CONSTRAINT [FK_OrdemServico_StatusOrdemServico] FOREIGN KEY([IdStatusOrdemServico])
REFERENCES [dbo].[StatusOrdemServico] ([IdStatusOrdemServico])
GO
ALTER TABLE [dbo].[OrdemServico] CHECK CONSTRAINT [FK_OrdemServico_StatusOrdemServico]
GO
ALTER TABLE [dbo].[PagamentoOrdemServico]  WITH CHECK ADD  CONSTRAINT [FK_PagamentoOrdemServico_OrdemServico] FOREIGN KEY([IdOrdemServico])
REFERENCES [dbo].[OrdemServico] ([IdOrdemServico])
GO
ALTER TABLE [dbo].[PagamentoOrdemServico] CHECK CONSTRAINT [FK_PagamentoOrdemServico_OrdemServico]
GO
ALTER TABLE [dbo].[PagamentoPedidoCompra]  WITH CHECK ADD  CONSTRAINT [FK_PagamentoPedidoCompra_PedidoCompra] FOREIGN KEY([IdPedidoCompra])
REFERENCES [dbo].[PedidoCompra] ([IdPedidoCompra])
GO
ALTER TABLE [dbo].[PagamentoPedidoCompra] CHECK CONSTRAINT [FK_PagamentoPedidoCompra_PedidoCompra]
GO
ALTER TABLE [dbo].[PagamentoRetornoCotacao]  WITH CHECK ADD  CONSTRAINT [FK_PagamentoRetornoCotacao_FormaPagamento] FOREIGN KEY([IdFormaPagamento])
REFERENCES [dbo].[FormaPagamento] ([IdFormaPagamento])
GO
ALTER TABLE [dbo].[PagamentoRetornoCotacao] CHECK CONSTRAINT [FK_PagamentoRetornoCotacao_FormaPagamento]
GO
ALTER TABLE [dbo].[PessoaFisica]  WITH CHECK ADD  CONSTRAINT [FK_PessoaFisica_Pessoa] FOREIGN KEY([IdPessoa])
REFERENCES [dbo].[Pessoa] ([IdPessoa])
GO
ALTER TABLE [dbo].[PessoaFisica] CHECK CONSTRAINT [FK_PessoaFisica_Pessoa]
GO
ALTER TABLE [dbo].[PessoaJuridica]  WITH CHECK ADD  CONSTRAINT [FK_PessoaJuridica_Pessoa] FOREIGN KEY([IdPessoa])
REFERENCES [dbo].[Pessoa] ([IdPessoa])
GO
ALTER TABLE [dbo].[PessoaJuridica] CHECK CONSTRAINT [FK_PessoaJuridica_Pessoa]
GO
ALTER TABLE [dbo].[Produto]  WITH CHECK ADD  CONSTRAINT [FK_Produto_MarcaProduto] FOREIGN KEY([IdMarcaProduto])
REFERENCES [dbo].[MarcaProduto] ([IdMarcaProduto])
GO
ALTER TABLE [dbo].[Produto] CHECK CONSTRAINT [FK_Produto_MarcaProduto]
GO
ALTER TABLE [dbo].[Produto]  WITH CHECK ADD  CONSTRAINT [FK_Produto_TipoProduto] FOREIGN KEY([IdTipoProduto])
REFERENCES [dbo].[TipoProduto] ([IdTipoProduto])
GO
ALTER TABLE [dbo].[Produto] CHECK CONSTRAINT [FK_Produto_TipoProduto]
GO
ALTER TABLE [dbo].[Produto]  WITH CHECK ADD  CONSTRAINT [FK_Produto_UnidadeMedida] FOREIGN KEY([IdUnidadeMedida])
REFERENCES [dbo].[UnidadeMedida] ([IdUnidadeMedida])
GO
ALTER TABLE [dbo].[Produto] CHECK CONSTRAINT [FK_Produto_UnidadeMedida]
GO
ALTER TABLE [dbo].[ProdutoCotacao]  WITH CHECK ADD  CONSTRAINT [FK_ProdutoCotacao_Cotacao] FOREIGN KEY([IdCotacao])
REFERENCES [dbo].[Cotacao] ([IdCotacao])
GO
ALTER TABLE [dbo].[ProdutoCotacao] CHECK CONSTRAINT [FK_ProdutoCotacao_Cotacao]
GO
ALTER TABLE [dbo].[ProdutoCotacao]  WITH CHECK ADD  CONSTRAINT [FK_ProdutoCotacao_Departamento] FOREIGN KEY([IdDepartamento])
REFERENCES [dbo].[Departamento] ([IdDepartamento])
GO
ALTER TABLE [dbo].[ProdutoCotacao] CHECK CONSTRAINT [FK_ProdutoCotacao_Departamento]
GO
ALTER TABLE [dbo].[ProdutoCotacao]  WITH CHECK ADD  CONSTRAINT [FK_ProdutoCotacao_Finalidade] FOREIGN KEY([IdFinalidade])
REFERENCES [dbo].[Finalidade] ([IdFinalidade])
GO
ALTER TABLE [dbo].[ProdutoCotacao] CHECK CONSTRAINT [FK_ProdutoCotacao_Finalidade]
GO
ALTER TABLE [dbo].[Reserva]  WITH CHECK ADD  CONSTRAINT [FK_Reserva_Unidade] FOREIGN KEY([IdUnidade])
REFERENCES [dbo].[Unidade] ([IdUnidade])
GO
ALTER TABLE [dbo].[Reserva] CHECK CONSTRAINT [FK_Reserva_Unidade]
GO
ALTER TABLE [dbo].[Reserva]  WITH CHECK ADD  CONSTRAINT [FK_Reserva_Usuario] FOREIGN KEY([IdUsuario])
REFERENCES [dbo].[Usuario] ([IdUsuario])
GO
ALTER TABLE [dbo].[Reserva] CHECK CONSTRAINT [FK_Reserva_Usuario]
GO
ALTER TABLE [dbo].[SolicitacaoPedidoCompra]  WITH CHECK ADD  CONSTRAINT [FK_SolicitacaoPedidoCompra_PedidoCompra] FOREIGN KEY([IdPedidoCompra])
REFERENCES [dbo].[PedidoCompra] ([IdPedidoCompra])
GO
ALTER TABLE [dbo].[SolicitacaoPedidoCompra] CHECK CONSTRAINT [FK_SolicitacaoPedidoCompra_PedidoCompra]
GO
ALTER TABLE [dbo].[SolicitacaoPedidoCompra]  WITH CHECK ADD  CONSTRAINT [FK_SolicitacaoPedidoCompra_SolicitacaoCompra] FOREIGN KEY([IdSolicitacaoCompra])
REFERENCES [dbo].[SolicitacaoCompra] ([IdSolicitacaoCompra])
GO
ALTER TABLE [dbo].[SolicitacaoPedidoCompra] CHECK CONSTRAINT [FK_SolicitacaoPedidoCompra_SolicitacaoCompra]
GO
ALTER TABLE [dbo].[TabelaPreco]  WITH CHECK ADD  CONSTRAINT [FK_TabelaPreco_Produto] FOREIGN KEY([IdProduto])
REFERENCES [dbo].[Produto] ([IdProduto])
GO
ALTER TABLE [dbo].[TabelaPreco] CHECK CONSTRAINT [FK_TabelaPreco_Produto]
GO
ALTER TABLE [dbo].[Telefone]  WITH CHECK ADD  CONSTRAINT [FK_Telefone_Pessoa] FOREIGN KEY([IdPessoa])
REFERENCES [dbo].[Pessoa] ([IdPessoa])
GO
ALTER TABLE [dbo].[Telefone] CHECK CONSTRAINT [FK_Telefone_Pessoa]
GO
ALTER TABLE [dbo].[Usuario]  WITH CHECK ADD  CONSTRAINT [FK_Usuario_Pessoa] FOREIGN KEY([IdPessoa])
REFERENCES [dbo].[Pessoa] ([IdPessoa])
GO
ALTER TABLE [dbo].[Usuario] CHECK CONSTRAINT [FK_Usuario_Pessoa]
GO
ALTER TABLE [dbo].[VendaProduto]  WITH CHECK ADD  CONSTRAINT [FK_VendaProduto_Endereco] FOREIGN KEY([IdEndereco])
REFERENCES [dbo].[Endereco] ([IdEndereco])
GO
ALTER TABLE [dbo].[VendaProduto] CHECK CONSTRAINT [FK_VendaProduto_Endereco]
GO
ALTER TABLE [dbo].[VendaProduto]  WITH CHECK ADD  CONSTRAINT [FK_VendaProduto_Unidade] FOREIGN KEY([IdUnidade])
REFERENCES [dbo].[Unidade] ([IdUnidade])
GO
ALTER TABLE [dbo].[VendaProduto] CHECK CONSTRAINT [FK_VendaProduto_Unidade]
GO
