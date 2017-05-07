-- MySQL dump 10.13  Distrib 5.7.9, for Win32 (AMD64)
--
-- Host: 127.0.0.1    Database: sysop
-- ------------------------------------------------------
-- Server version	5.7.11-log

/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8 */;
/*!40103 SET @OLD_TIME_ZONE=@@TIME_ZONE */;
/*!40103 SET TIME_ZONE='+00:00' */;
/*!40014 SET @OLD_UNIQUE_CHECKS=@@UNIQUE_CHECKS, UNIQUE_CHECKS=0 */;
/*!40014 SET @OLD_FOREIGN_KEY_CHECKS=@@FOREIGN_KEY_CHECKS, FOREIGN_KEY_CHECKS=0 */;
/*!40101 SET @OLD_SQL_MODE=@@SQL_MODE, SQL_MODE='NO_AUTO_VALUE_ON_ZERO' */;
/*!40111 SET @OLD_SQL_NOTES=@@SQL_NOTES, SQL_NOTES=0 */;

--
-- Table structure for table `acesso`
--

DROP TABLE IF EXISTS `acesso`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `acesso` (
  `IdAcesso` int(11) NOT NULL AUTO_INCREMENT,
  `Descricao` varchar(100) DEFAULT NULL,
  PRIMARY KEY (`IdAcesso`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `acesso`
--

LOCK TABLES `acesso` WRITE;
/*!40000 ALTER TABLE `acesso` DISABLE KEYS */;
/*!40000 ALTER TABLE `acesso` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `acessousuario`
--

DROP TABLE IF EXISTS `acessousuario`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `acessousuario` (
  `IdAcessoUsuario` int(11) NOT NULL AUTO_INCREMENT,
  `IdUsuario` int(11) DEFAULT NULL,
  `IdAcesso` int(11) DEFAULT NULL,
  PRIMARY KEY (`IdAcessoUsuario`),
  KEY `FK_AcessoUsuario_Acesso` (`IdAcesso`),
  KEY `FK_AcessoUsuario_Usuario` (`IdUsuario`),
  CONSTRAINT `FK_AcessoUsuario_Acesso` FOREIGN KEY (`IdAcesso`) REFERENCES `acesso` (`IdAcesso`) ON DELETE NO ACTION ON UPDATE NO ACTION,
  CONSTRAINT `FK_AcessoUsuario_Usuario` FOREIGN KEY (`IdUsuario`) REFERENCES `usuario` (`IdUsuario`) ON DELETE NO ACTION ON UPDATE NO ACTION
) ENGINE=InnoDB DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `acessousuario`
--

LOCK TABLES `acessousuario` WRITE;
/*!40000 ALTER TABLE `acessousuario` DISABLE KEYS */;
/*!40000 ALTER TABLE `acessousuario` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `arquivosordemservico`
--

DROP TABLE IF EXISTS `arquivosordemservico`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `arquivosordemservico` (
  `IdArquivosOrdemServico` int(11) NOT NULL AUTO_INCREMENT,
  `IdOrdemServico` int(11) DEFAULT NULL,
  `PathArquivo` varchar(50) DEFAULT NULL,
  PRIMARY KEY (`IdArquivosOrdemServico`),
  KEY `FK_ArquivosOrdemServico_OrdemServico` (`IdOrdemServico`),
  CONSTRAINT `FK_ArquivosOrdemServico_OrdemServico` FOREIGN KEY (`IdOrdemServico`) REFERENCES `ordemservico` (`IdOrdemServico`) ON DELETE NO ACTION ON UPDATE NO ACTION
) ENGINE=InnoDB DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `arquivosordemservico`
--

LOCK TABLES `arquivosordemservico` WRITE;
/*!40000 ALTER TABLE `arquivosordemservico` DISABLE KEYS */;
/*!40000 ALTER TABLE `arquivosordemservico` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `contato_pj`
--

DROP TABLE IF EXISTS `contato_pj`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `contato_pj` (
  `IdContatoPJ` int(11) NOT NULL,
  `IdPessoaJuridica` int(11) DEFAULT NULL,
  `Nome` varchar(100) DEFAULT NULL,
  PRIMARY KEY (`IdContatoPJ`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `contato_pj`
--

LOCK TABLES `contato_pj` WRITE;
/*!40000 ALTER TABLE `contato_pj` DISABLE KEYS */;
/*!40000 ALTER TABLE `contato_pj` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `cotacao`
--

DROP TABLE IF EXISTS `cotacao`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `cotacao` (
  `IdCotacao` int(11) NOT NULL AUTO_INCREMENT,
  `Descricao` varchar(50) DEFAULT NULL,
  `DataInicio` datetime(6) DEFAULT NULL,
  `DataFim` datetime(6) DEFAULT NULL,
  `IdStatusCotacao` int(11) DEFAULT NULL,
  PRIMARY KEY (`IdCotacao`),
  KEY `FK_Cotacao_StatusCotacao` (`IdStatusCotacao`),
  CONSTRAINT `FK_Cotacao_StatusCotacao` FOREIGN KEY (`IdStatusCotacao`) REFERENCES `statuscotacao` (`IdStatusCotacao`) ON DELETE NO ACTION ON UPDATE NO ACTION
) ENGINE=InnoDB DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `cotacao`
--

LOCK TABLES `cotacao` WRITE;
/*!40000 ALTER TABLE `cotacao` DISABLE KEYS */;
/*!40000 ALTER TABLE `cotacao` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `departamento`
--

DROP TABLE IF EXISTS `departamento`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `departamento` (
  `IdDepartamento` int(11) NOT NULL AUTO_INCREMENT,
  `Descricao` varchar(50) DEFAULT NULL,
  `Status` varchar(20) DEFAULT NULL,
  PRIMARY KEY (`IdDepartamento`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `departamento`
--

LOCK TABLES `departamento` WRITE;
/*!40000 ALTER TABLE `departamento` DISABLE KEYS */;
/*!40000 ALTER TABLE `departamento` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `email`
--

DROP TABLE IF EXISTS `email`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `email` (
  `IdEmail` int(11) NOT NULL AUTO_INCREMENT,
  `IdPessoa` int(11) DEFAULT NULL,
  `Email` varchar(50) DEFAULT NULL,
  PRIMARY KEY (`IdEmail`),
  KEY `FK_Email_Pessoa` (`IdPessoa`),
  CONSTRAINT `FK_Email_Pessoa` FOREIGN KEY (`IdPessoa`) REFERENCES `pessoa` (`IdPessoa`) ON DELETE NO ACTION ON UPDATE NO ACTION
) ENGINE=InnoDB DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `email`
--

LOCK TABLES `email` WRITE;
/*!40000 ALTER TABLE `email` DISABLE KEYS */;
/*!40000 ALTER TABLE `email` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `endereco`
--

DROP TABLE IF EXISTS `endereco`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `endereco` (
  `IdEndereco` int(11) NOT NULL AUTO_INCREMENT,
  `Logradouro` varchar(200) DEFAULT NULL,
  `Complemento` varchar(50) DEFAULT NULL,
  `Bairro` varchar(50) DEFAULT NULL,
  `Cidade` varchar(80) DEFAULT NULL,
  `CEP` varchar(20) DEFAULT NULL,
  `PontoReferencia` varchar(150) DEFAULT NULL,
  `Primario` tinyint(1) DEFAULT NULL,
  `IdPessoa` int(11) DEFAULT NULL,
  PRIMARY KEY (`IdEndereco`),
  KEY `FK_Endereco_Pessoa` (`IdPessoa`),
  CONSTRAINT `FK_Endereco_Pessoa` FOREIGN KEY (`IdPessoa`) REFERENCES `pessoa` (`IdPessoa`) ON DELETE NO ACTION ON UPDATE NO ACTION
) ENGINE=InnoDB DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `endereco`
--

LOCK TABLES `endereco` WRITE;
/*!40000 ALTER TABLE `endereco` DISABLE KEYS */;
/*!40000 ALTER TABLE `endereco` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `entradaproduto`
--

DROP TABLE IF EXISTS `entradaproduto`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `entradaproduto` (
  `IdEntradaProduto` int(11) NOT NULL AUTO_INCREMENT,
  `DataEntrada` datetime(6) DEFAULT NULL,
  `IdUsuario` int(11) DEFAULT NULL,
  PRIMARY KEY (`IdEntradaProduto`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `entradaproduto`
--

LOCK TABLES `entradaproduto` WRITE;
/*!40000 ALTER TABLE `entradaproduto` DISABLE KEYS */;
/*!40000 ALTER TABLE `entradaproduto` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `entradaprodutonf`
--

DROP TABLE IF EXISTS `entradaprodutonf`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `entradaprodutonf` (
  `IdEntradaProdutoNF` int(11) NOT NULL AUTO_INCREMENT,
  `IdEntradaProduto` int(11) DEFAULT NULL,
  `IdNotaFisacal` int(11) DEFAULT NULL,
  `IdPedidoCompra` int(11) DEFAULT NULL,
  PRIMARY KEY (`IdEntradaProdutoNF`),
  KEY `FK_EntradaProdutoNF_EntradaProduto` (`IdEntradaProduto`),
  KEY `FK_EntradaProdutoNF_NotaFiscal` (`IdNotaFisacal`),
  KEY `FK_EntradaProdutoNF_PedidoCompra` (`IdPedidoCompra`),
  CONSTRAINT `FK_EntradaProdutoNF_EntradaProduto` FOREIGN KEY (`IdEntradaProduto`) REFERENCES `entradaproduto` (`IdEntradaProduto`) ON DELETE NO ACTION ON UPDATE NO ACTION,
  CONSTRAINT `FK_EntradaProdutoNF_NotaFiscal` FOREIGN KEY (`IdNotaFisacal`) REFERENCES `notafiscal` (`IdNotaFiscal`) ON DELETE NO ACTION ON UPDATE NO ACTION,
  CONSTRAINT `FK_EntradaProdutoNF_PedidoCompra` FOREIGN KEY (`IdPedidoCompra`) REFERENCES `pedidocompra` (`IdPedidoCompra`) ON DELETE NO ACTION ON UPDATE NO ACTION
) ENGINE=InnoDB DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `entradaprodutonf`
--

LOCK TABLES `entradaprodutonf` WRITE;
/*!40000 ALTER TABLE `entradaprodutonf` DISABLE KEYS */;
/*!40000 ALTER TABLE `entradaprodutonf` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `equipeordemservico`
--

DROP TABLE IF EXISTS `equipeordemservico`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `equipeordemservico` (
  `IdEquipeOrdemServico` int(11) NOT NULL AUTO_INCREMENT,
  `IdOrdemServico` int(11) DEFAULT NULL,
  `IdFuncionario` int(11) DEFAULT NULL,
  PRIMARY KEY (`IdEquipeOrdemServico`),
  KEY `FK_EquipeOrdemServico_OrdemServico` (`IdOrdemServico`),
  CONSTRAINT `FK_EquipeOrdemServico_OrdemServico` FOREIGN KEY (`IdOrdemServico`) REFERENCES `ordemservico` (`IdOrdemServico`) ON DELETE NO ACTION ON UPDATE NO ACTION
) ENGINE=InnoDB DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `equipeordemservico`
--

LOCK TABLES `equipeordemservico` WRITE;
/*!40000 ALTER TABLE `equipeordemservico` DISABLE KEYS */;
/*!40000 ALTER TABLE `equipeordemservico` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `finalidade`
--

DROP TABLE IF EXISTS `finalidade`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `finalidade` (
  `IdFinalidade` int(11) NOT NULL AUTO_INCREMENT,
  `Descricao` varchar(50) DEFAULT NULL,
  `Status` varchar(20) DEFAULT NULL,
  PRIMARY KEY (`IdFinalidade`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `finalidade`
--

LOCK TABLES `finalidade` WRITE;
/*!40000 ALTER TABLE `finalidade` DISABLE KEYS */;
/*!40000 ALTER TABLE `finalidade` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `formapagamento`
--

DROP TABLE IF EXISTS `formapagamento`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `formapagamento` (
  `IdFormaPagamento` int(11) NOT NULL AUTO_INCREMENT,
  `Descricao` varchar(50) DEFAULT NULL,
  PRIMARY KEY (`IdFormaPagamento`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `formapagamento`
--

LOCK TABLES `formapagamento` WRITE;
/*!40000 ALTER TABLE `formapagamento` DISABLE KEYS */;
/*!40000 ALTER TABLE `formapagamento` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `fornecedorcotacao`
--

DROP TABLE IF EXISTS `fornecedorcotacao`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `fornecedorcotacao` (
  `IdFornecedorCotacao` int(11) NOT NULL AUTO_INCREMENT,
  `IdFornecedor` int(11) DEFAULT NULL,
  `IdCotacao` int(11) DEFAULT NULL,
  `ValorFrete` decimal(10,2) DEFAULT NULL,
  `Observacao` varchar(150) DEFAULT NULL,
  `DataRetorno` datetime(6) DEFAULT NULL,
  `IdPessoa` int(11) DEFAULT NULL,
  PRIMARY KEY (`IdFornecedorCotacao`),
  KEY `FK_FornecedorCotacao_Cotacao` (`IdCotacao`),
  KEY `FK_FornecedorCotacao_Pessoa` (`IdPessoa`),
  CONSTRAINT `FK_FornecedorCotacao_Cotacao` FOREIGN KEY (`IdCotacao`) REFERENCES `cotacao` (`IdCotacao`) ON DELETE NO ACTION ON UPDATE NO ACTION,
  CONSTRAINT `FK_FornecedorCotacao_Pessoa` FOREIGN KEY (`IdPessoa`) REFERENCES `pessoa` (`IdPessoa`) ON DELETE NO ACTION ON UPDATE NO ACTION
) ENGINE=InnoDB DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `fornecedorcotacao`
--

LOCK TABLES `fornecedorcotacao` WRITE;
/*!40000 ALTER TABLE `fornecedorcotacao` DISABLE KEYS */;
/*!40000 ALTER TABLE `fornecedorcotacao` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `funcionario`
--

DROP TABLE IF EXISTS `funcionario`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `funcionario` (
  `IdFuncionario` int(11) NOT NULL AUTO_INCREMENT,
  `IdPessoa` int(11) DEFAULT NULL,
  `ValorHora` decimal(10,2) DEFAULT NULL,
  `Foto` varchar(50) DEFAULT NULL,
  PRIMARY KEY (`IdFuncionario`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `funcionario`
--

LOCK TABLES `funcionario` WRITE;
/*!40000 ALTER TABLE `funcionario` DISABLE KEYS */;
/*!40000 ALTER TABLE `funcionario` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `historicoordemservico`
--

DROP TABLE IF EXISTS `historicoordemservico`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `historicoordemservico` (
  `IdHistoricoOrdemServico` int(11) NOT NULL AUTO_INCREMENT,
  `IdOrdemServico` int(11) DEFAULT NULL,
  `Data` datetime(6) DEFAULT NULL,
  `IdUsuario` int(11) DEFAULT NULL,
  `Observacao` varchar(250) DEFAULT NULL,
  PRIMARY KEY (`IdHistoricoOrdemServico`),
  KEY `FK_HistoricoOrdemServico_OrdemServico` (`IdOrdemServico`),
  CONSTRAINT `FK_HistoricoOrdemServico_OrdemServico` FOREIGN KEY (`IdOrdemServico`) REFERENCES `ordemservico` (`IdOrdemServico`) ON DELETE NO ACTION ON UPDATE NO ACTION
) ENGINE=InnoDB DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `historicoordemservico`
--

LOCK TABLES `historicoordemservico` WRITE;
/*!40000 ALTER TABLE `historicoordemservico` DISABLE KEYS */;
/*!40000 ALTER TABLE `historicoordemservico` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `historicostatuscotacao`
--

DROP TABLE IF EXISTS `historicostatuscotacao`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `historicostatuscotacao` (
  `IdHistoricoStatusCotacao` int(11) NOT NULL AUTO_INCREMENT,
  `IdCotacao` int(11) DEFAULT NULL,
  `IdStatusCotacao` int(11) DEFAULT NULL,
  `DataStatus` char(10) DEFAULT NULL,
  `IdUsuario` int(11) DEFAULT NULL,
  PRIMARY KEY (`IdHistoricoStatusCotacao`),
  KEY `FK_HistoricoStatusCotacao_Cotacao` (`IdCotacao`),
  KEY `FK_HistoricoStatusCotacao_StatusCotacao` (`IdStatusCotacao`),
  KEY `FK_HistoricoStatusCotacao_Usuario` (`IdUsuario`),
  CONSTRAINT `FK_HistoricoStatusCotacao_Cotacao` FOREIGN KEY (`IdCotacao`) REFERENCES `cotacao` (`IdCotacao`) ON DELETE NO ACTION ON UPDATE NO ACTION,
  CONSTRAINT `FK_HistoricoStatusCotacao_StatusCotacao` FOREIGN KEY (`IdStatusCotacao`) REFERENCES `statuscotacao` (`IdStatusCotacao`) ON DELETE NO ACTION ON UPDATE NO ACTION,
  CONSTRAINT `FK_HistoricoStatusCotacao_Usuario` FOREIGN KEY (`IdUsuario`) REFERENCES `usuario` (`IdUsuario`) ON DELETE NO ACTION ON UPDATE NO ACTION
) ENGINE=InnoDB DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `historicostatuscotacao`
--

LOCK TABLES `historicostatuscotacao` WRITE;
/*!40000 ALTER TABLE `historicostatuscotacao` DISABLE KEYS */;
/*!40000 ALTER TABLE `historicostatuscotacao` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `itementradaestoque`
--

DROP TABLE IF EXISTS `itementradaestoque`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `itementradaestoque` (
  `IdItemEntradaProduto` int(11) NOT NULL AUTO_INCREMENT,
  `IdEntradaProduto` int(11) DEFAULT NULL,
  `Lote` int(11) DEFAULT NULL,
  `Quantidade` int(11) DEFAULT NULL,
  `ValorUnitarioCusto` decimal(10,2) DEFAULT NULL,
  PRIMARY KEY (`IdItemEntradaProduto`),
  KEY `FK_ItemEntradaEstoque_EntradaProduto` (`IdEntradaProduto`),
  CONSTRAINT `FK_ItemEntradaEstoque_EntradaProduto` FOREIGN KEY (`IdEntradaProduto`) REFERENCES `entradaproduto` (`IdEntradaProduto`) ON DELETE NO ACTION ON UPDATE NO ACTION
) ENGINE=InnoDB DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `itementradaestoque`
--

LOCK TABLES `itementradaestoque` WRITE;
/*!40000 ALTER TABLE `itementradaestoque` DISABLE KEYS */;
/*!40000 ALTER TABLE `itementradaestoque` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `itemestoque`
--

DROP TABLE IF EXISTS `itemestoque`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `itemestoque` (
  `IdItemEstoque` int(11) NOT NULL AUTO_INCREMENT,
  `IdUnidade` int(11) DEFAULT NULL,
  `Quantidade` int(11) DEFAULT NULL,
  `IdProduto` int(11) DEFAULT NULL,
  `Data` datetime(6) DEFAULT NULL,
  PRIMARY KEY (`IdItemEstoque`),
  KEY `FK_ItemEstoque_Produto` (`IdProduto`),
  KEY `FK_ItemEstoque_Unidade` (`IdUnidade`),
  CONSTRAINT `FK_ItemEstoque_Produto` FOREIGN KEY (`IdProduto`) REFERENCES `produto` (`IdProduto`) ON DELETE NO ACTION ON UPDATE NO ACTION,
  CONSTRAINT `FK_ItemEstoque_Unidade` FOREIGN KEY (`IdUnidade`) REFERENCES `unidade` (`IdUnidade`) ON DELETE NO ACTION ON UPDATE NO ACTION
) ENGINE=InnoDB DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `itemestoque`
--

LOCK TABLES `itemestoque` WRITE;
/*!40000 ALTER TABLE `itemestoque` DISABLE KEYS */;
/*!40000 ALTER TABLE `itemestoque` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `itempedidocompra`
--

DROP TABLE IF EXISTS `itempedidocompra`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `itempedidocompra` (
  `IdItemPedidoCompra` int(11) NOT NULL AUTO_INCREMENT,
  `IdItemSolicitacaoCompra` int(11) DEFAULT NULL,
  `Quantidade` int(11) DEFAULT NULL,
  `Valor` decimal(10,2) DEFAULT NULL,
  `IdPedidoCompra` int(11) DEFAULT NULL,
  PRIMARY KEY (`IdItemPedidoCompra`),
  KEY `FK_ItemPedidoCompra_ItemSolicitacaoCompra` (`IdItemSolicitacaoCompra`),
  KEY `FK_ItemPedidoCompra_PedidoCompra` (`IdPedidoCompra`),
  CONSTRAINT `FK_ItemPedidoCompra_ItemSolicitacaoCompra` FOREIGN KEY (`IdItemSolicitacaoCompra`) REFERENCES `itemsolicitacaocompra` (`IdItemSolicitacaoCompra`) ON DELETE NO ACTION ON UPDATE NO ACTION,
  CONSTRAINT `FK_ItemPedidoCompra_PedidoCompra` FOREIGN KEY (`IdPedidoCompra`) REFERENCES `pedidocompra` (`IdPedidoCompra`) ON DELETE NO ACTION ON UPDATE NO ACTION
) ENGINE=InnoDB DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `itempedidocompra`
--

LOCK TABLES `itempedidocompra` WRITE;
/*!40000 ALTER TABLE `itempedidocompra` DISABLE KEYS */;
/*!40000 ALTER TABLE `itempedidocompra` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `itempedidocompracotacao`
--

DROP TABLE IF EXISTS `itempedidocompracotacao`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `itempedidocompracotacao` (
  `IdItemPedidoCompraCotacao` int(11) NOT NULL AUTO_INCREMENT,
  `IdItemSolicitacaoCompraCotatcao` int(11) DEFAULT NULL,
  `Quantidade` int(11) DEFAULT NULL,
  `Valor` decimal(10,2) DEFAULT NULL,
  `IdPedidoCompra` int(11) DEFAULT NULL,
  PRIMARY KEY (`IdItemPedidoCompraCotacao`),
  KEY `FK_ItemPedidoCompraCotacao_ItemSolicitacaoCompraCotacao` (`IdItemSolicitacaoCompraCotatcao`),
  KEY `FK_ItemPedidoCompraCotacao_PedidoCompra` (`IdPedidoCompra`),
  CONSTRAINT `FK_ItemPedidoCompraCotacao_ItemSolicitacaoCompraCotacao` FOREIGN KEY (`IdItemSolicitacaoCompraCotatcao`) REFERENCES `itemsolicitacaocompracotacao` (`IdItemSolicitacaoCompraCotacao`) ON DELETE NO ACTION ON UPDATE NO ACTION,
  CONSTRAINT `FK_ItemPedidoCompraCotacao_PedidoCompra` FOREIGN KEY (`IdPedidoCompra`) REFERENCES `pedidocompra` (`IdPedidoCompra`) ON DELETE NO ACTION ON UPDATE NO ACTION
) ENGINE=InnoDB DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `itempedidocompracotacao`
--

LOCK TABLES `itempedidocompracotacao` WRITE;
/*!40000 ALTER TABLE `itempedidocompracotacao` DISABLE KEYS */;
/*!40000 ALTER TABLE `itempedidocompracotacao` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `itemprodutonotafiscal`
--

DROP TABLE IF EXISTS `itemprodutonotafiscal`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `itemprodutonotafiscal` (
  `IdItemProdutoNotaFiscal` int(11) NOT NULL AUTO_INCREMENT,
  `IdProduto` int(11) DEFAULT NULL,
  `Lote` int(11) DEFAULT NULL,
  `Quantidade` int(11) DEFAULT NULL,
  `ValorUnitario` decimal(10,2) DEFAULT NULL,
  `ValorFrete` decimal(10,2) DEFAULT NULL,
  `ValorDesconto` decimal(10,2) DEFAULT NULL,
  `ValorSeguro` decimal(10,2) DEFAULT NULL,
  `IPI` decimal(10,2) DEFAULT NULL,
  `ICMS` decimal(10,2) DEFAULT NULL,
  `IdNotaFiscal` int(11) DEFAULT NULL,
  PRIMARY KEY (`IdItemProdutoNotaFiscal`),
  KEY `FK_ItemProdutoNotaFiscal_NotaFiscal` (`IdNotaFiscal`),
  KEY `FK_ItemProdutoNotaFiscal_Produto` (`IdProduto`),
  CONSTRAINT `FK_ItemProdutoNotaFiscal_NotaFiscal` FOREIGN KEY (`IdNotaFiscal`) REFERENCES `notafiscal` (`IdNotaFiscal`) ON DELETE NO ACTION ON UPDATE NO ACTION,
  CONSTRAINT `FK_ItemProdutoNotaFiscal_Produto` FOREIGN KEY (`IdProduto`) REFERENCES `produto` (`IdProduto`) ON DELETE NO ACTION ON UPDATE NO ACTION
) ENGINE=InnoDB DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `itemprodutonotafiscal`
--

LOCK TABLES `itemprodutonotafiscal` WRITE;
/*!40000 ALTER TABLE `itemprodutonotafiscal` DISABLE KEYS */;
/*!40000 ALTER TABLE `itemprodutonotafiscal` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `itemreservaproduto`
--

DROP TABLE IF EXISTS `itemreservaproduto`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `itemreservaproduto` (
  `IdItemReservaProduto` int(11) NOT NULL AUTO_INCREMENT,
  `IdProduto` int(11) DEFAULT NULL,
  `Quantidade` int(11) DEFAULT NULL,
  `DataSeparacao` datetime(6) DEFAULT NULL,
  `DataAtual` datetime(6) DEFAULT NULL,
  `Status` varchar(20) DEFAULT NULL,
  `IdVendaProduto` int(11) DEFAULT NULL,
  `IdTE` int(11) DEFAULT NULL,
  `QtdTotalEstoque` int(11) DEFAULT NULL,
  `IdUnidade` int(11) DEFAULT NULL,
  `IdReserva` int(11) DEFAULT NULL,
  PRIMARY KEY (`IdItemReservaProduto`),
  KEY `FK_ItemReservaProduto_Reserva` (`IdReserva`),
  KEY `FK_ItemReservaProduto_TransferenciaEstoque` (`IdTE`),
  KEY `FK_ItemReservaProduto_VendaProduto` (`IdVendaProduto`),
  KEY `FK_ItemReservaVendaProduto_Produto` (`IdProduto`),
  CONSTRAINT `FK_ItemReservaProduto_Reserva` FOREIGN KEY (`IdReserva`) REFERENCES `reserva` (`IdReserva`) ON DELETE NO ACTION ON UPDATE NO ACTION,
  CONSTRAINT `FK_ItemReservaProduto_TransferenciaEstoque` FOREIGN KEY (`IdTE`) REFERENCES `transferenciaestoque` (`IdTE`) ON DELETE NO ACTION ON UPDATE NO ACTION,
  CONSTRAINT `FK_ItemReservaProduto_VendaProduto` FOREIGN KEY (`IdVendaProduto`) REFERENCES `vendaproduto` (`IdVendaProduto`) ON DELETE NO ACTION ON UPDATE NO ACTION,
  CONSTRAINT `FK_ItemReservaVendaProduto_Produto` FOREIGN KEY (`IdProduto`) REFERENCES `produto` (`IdProduto`) ON DELETE NO ACTION ON UPDATE NO ACTION
) ENGINE=InnoDB DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `itemreservaproduto`
--

LOCK TABLES `itemreservaproduto` WRITE;
/*!40000 ALTER TABLE `itemreservaproduto` DISABLE KEYS */;
/*!40000 ALTER TABLE `itemreservaproduto` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `itemreservavendaproduto`
--

DROP TABLE IF EXISTS `itemreservavendaproduto`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `itemreservavendaproduto` (
  `IdItemReservaProduto` int(11) NOT NULL AUTO_INCREMENT,
  `IdProduto` int(11) DEFAULT NULL,
  `Quantidade` int(11) DEFAULT NULL,
  `DataSeparacao` datetime(6) DEFAULT NULL,
  `DataAtual` datetime(6) DEFAULT NULL,
  `Status` varchar(20) DEFAULT NULL,
  `IdVendaProduto` int(11) DEFAULT NULL,
  `IdTE` int(11) DEFAULT NULL,
  `QtdTotalEstoque` int(11) DEFAULT NULL,
  `IdUnidade` int(11) DEFAULT NULL,
  `IdReserva` int(11) DEFAULT NULL,
  PRIMARY KEY (`IdItemReservaProduto`),
  KEY `FK_ItemReservaVendaProduto_Reserva` (`IdReserva`),
  KEY `FK_ItemReservaVendaProduto_TransferenciaEstoque` (`IdTE`),
  KEY `FK_ItemReservaVendaProduto_Unidade` (`IdUnidade`),
  KEY `FK_ItemReservaVendaProduto_VendaProduto` (`IdVendaProduto`),
  CONSTRAINT `FK_ItemReservaVendaProduto_Reserva` FOREIGN KEY (`IdReserva`) REFERENCES `reserva` (`IdReserva`) ON DELETE NO ACTION ON UPDATE NO ACTION,
  CONSTRAINT `FK_ItemReservaVendaProduto_TransferenciaEstoque` FOREIGN KEY (`IdTE`) REFERENCES `transferenciaestoque` (`IdTE`) ON DELETE NO ACTION ON UPDATE NO ACTION,
  CONSTRAINT `FK_ItemReservaVendaProduto_Unidade` FOREIGN KEY (`IdUnidade`) REFERENCES `unidade` (`IdUnidade`) ON DELETE NO ACTION ON UPDATE NO ACTION,
  CONSTRAINT `FK_ItemReservaVendaProduto_VendaProduto` FOREIGN KEY (`IdVendaProduto`) REFERENCES `vendaproduto` (`IdVendaProduto`) ON DELETE NO ACTION ON UPDATE NO ACTION
) ENGINE=InnoDB DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `itemreservavendaproduto`
--

LOCK TABLES `itemreservavendaproduto` WRITE;
/*!40000 ALTER TABLE `itemreservavendaproduto` DISABLE KEYS */;
/*!40000 ALTER TABLE `itemreservavendaproduto` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `itemretornocotacao`
--

DROP TABLE IF EXISTS `itemretornocotacao`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `itemretornocotacao` (
  `IdItemRetornoCotacao` int(11) NOT NULL AUTO_INCREMENT,
  `IdProdutoCotacao` int(11) DEFAULT NULL,
  `IdFornecedorCotacao` int(11) DEFAULT NULL,
  `QuantidadeFornecedor` decimal(10,2) DEFAULT NULL,
  `ValorUnitarioFornecedor` decimal(10,2) DEFAULT NULL,
  `DiasParaEntrega` int(11) DEFAULT NULL,
  PRIMARY KEY (`IdItemRetornoCotacao`),
  KEY `FK_ItemRetornoCotacao_FornecedorCotacao` (`IdFornecedorCotacao`),
  KEY `FK_ItemRetornoCotacao_ProdutoCotacao` (`IdProdutoCotacao`),
  CONSTRAINT `FK_ItemRetornoCotacao_FornecedorCotacao` FOREIGN KEY (`IdFornecedorCotacao`) REFERENCES `fornecedorcotacao` (`IdFornecedorCotacao`) ON DELETE NO ACTION ON UPDATE NO ACTION,
  CONSTRAINT `FK_ItemRetornoCotacao_ProdutoCotacao` FOREIGN KEY (`IdProdutoCotacao`) REFERENCES `produtocotacao` (`IdProdutoCotacao`) ON DELETE NO ACTION ON UPDATE NO ACTION
) ENGINE=InnoDB DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `itemretornocotacao`
--

LOCK TABLES `itemretornocotacao` WRITE;
/*!40000 ALTER TABLE `itemretornocotacao` DISABLE KEYS */;
/*!40000 ALTER TABLE `itemretornocotacao` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `itemsolicitacaocompra`
--

DROP TABLE IF EXISTS `itemsolicitacaocompra`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `itemsolicitacaocompra` (
  `IdItemSolicitacaoCompra` int(11) NOT NULL AUTO_INCREMENT,
  `IdSolicitacaoCompra` int(11) DEFAULT NULL,
  `IdProduto` int(11) DEFAULT NULL,
  `IdFornecedor` int(11) DEFAULT NULL,
  `Quantidade` int(11) DEFAULT NULL,
  `ValorUnitario` decimal(10,2) DEFAULT NULL,
  PRIMARY KEY (`IdItemSolicitacaoCompra`),
  KEY `FK_ItemSolicitacaoCompra_SolicitacaoCompra` (`IdSolicitacaoCompra`),
  CONSTRAINT `FK_ItemSolicitacaoCompra_SolicitacaoCompra` FOREIGN KEY (`IdSolicitacaoCompra`) REFERENCES `solicitacaocompra` (`IdSolicitacaoCompra`) ON DELETE NO ACTION ON UPDATE NO ACTION
) ENGINE=InnoDB DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `itemsolicitacaocompra`
--

LOCK TABLES `itemsolicitacaocompra` WRITE;
/*!40000 ALTER TABLE `itemsolicitacaocompra` DISABLE KEYS */;
/*!40000 ALTER TABLE `itemsolicitacaocompra` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `itemsolicitacaocompracotacao`
--

DROP TABLE IF EXISTS `itemsolicitacaocompracotacao`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `itemsolicitacaocompracotacao` (
  `IdItemSolicitacaoCompraCotacao` int(11) NOT NULL AUTO_INCREMENT,
  `IdSolicitacaoCompra` int(11) DEFAULT NULL,
  `IdItemRetornoCotacao` int(11) DEFAULT NULL,
  `Quantidade` int(11) DEFAULT NULL,
  `ValorUnitario` decimal(10,2) DEFAULT NULL,
  PRIMARY KEY (`IdItemSolicitacaoCompraCotacao`),
  KEY `FK_ItemSolicitacaoCompraCotacao_ItemRetornoCotacao` (`IdItemRetornoCotacao`),
  KEY `FK_ItemSolicitacaoCompraCotacao_SolicitacaoCompra` (`IdSolicitacaoCompra`),
  CONSTRAINT `FK_ItemSolicitacaoCompraCotacao_ItemRetornoCotacao` FOREIGN KEY (`IdItemRetornoCotacao`) REFERENCES `itemretornocotacao` (`IdItemRetornoCotacao`) ON DELETE NO ACTION ON UPDATE NO ACTION,
  CONSTRAINT `FK_ItemSolicitacaoCompraCotacao_SolicitacaoCompra` FOREIGN KEY (`IdSolicitacaoCompra`) REFERENCES `solicitacaocompra` (`IdSolicitacaoCompra`) ON DELETE NO ACTION ON UPDATE NO ACTION
) ENGINE=InnoDB DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `itemsolicitacaocompracotacao`
--

LOCK TABLES `itemsolicitacaocompracotacao` WRITE;
/*!40000 ALTER TABLE `itemsolicitacaocompracotacao` DISABLE KEYS */;
/*!40000 ALTER TABLE `itemsolicitacaocompracotacao` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `itemtransferenciaestoque`
--

DROP TABLE IF EXISTS `itemtransferenciaestoque`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `itemtransferenciaestoque` (
  `IdItemTransferenciaEstoque` int(11) NOT NULL AUTO_INCREMENT,
  `IdProduto` int(11) DEFAULT NULL,
  `Quantidade` int(11) DEFAULT NULL,
  `Status` varchar(20) DEFAULT NULL,
  `IdLocalOrigem` int(11) DEFAULT NULL,
  `IdLocalDestino` int(11) DEFAULT NULL,
  `IdTE` int(11) DEFAULT NULL,
  PRIMARY KEY (`IdItemTransferenciaEstoque`),
  KEY `FK_ItemTransferenciaEstoque_Produto` (`IdProduto`),
  KEY `FK_ItemTransferenciaEstoque_TransferenciaEstoque` (`IdTE`),
  KEY `FK_ItemTransferenciaEstoque_UnidadeDestino` (`IdLocalDestino`),
  KEY `FK_ItemTransferenciaEstoque_UnidadeOrigem` (`IdLocalOrigem`),
  CONSTRAINT `FK_ItemTransferenciaEstoque_Produto` FOREIGN KEY (`IdProduto`) REFERENCES `produto` (`IdProduto`) ON DELETE NO ACTION ON UPDATE NO ACTION,
  CONSTRAINT `FK_ItemTransferenciaEstoque_TransferenciaEstoque` FOREIGN KEY (`IdTE`) REFERENCES `transferenciaestoque` (`IdTE`) ON DELETE NO ACTION ON UPDATE NO ACTION,
  CONSTRAINT `FK_ItemTransferenciaEstoque_UnidadeDestino` FOREIGN KEY (`IdLocalDestino`) REFERENCES `unidade` (`IdUnidade`) ON DELETE NO ACTION ON UPDATE NO ACTION,
  CONSTRAINT `FK_ItemTransferenciaEstoque_UnidadeOrigem` FOREIGN KEY (`IdLocalOrigem`) REFERENCES `unidade` (`IdUnidade`) ON DELETE NO ACTION ON UPDATE NO ACTION
) ENGINE=InnoDB DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `itemtransferenciaestoque`
--

LOCK TABLES `itemtransferenciaestoque` WRITE;
/*!40000 ALTER TABLE `itemtransferenciaestoque` DISABLE KEYS */;
/*!40000 ALTER TABLE `itemtransferenciaestoque` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `itemvendaestoque`
--

DROP TABLE IF EXISTS `itemvendaestoque`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `itemvendaestoque` (
  `IdItemVendaEstoque` int(11) NOT NULL AUTO_INCREMENT,
  `IdVendaProduto` int(11) DEFAULT NULL,
  `Quantidade` int(11) DEFAULT NULL,
  `Valor` int(11) DEFAULT NULL,
  `IdProduto` int(11) DEFAULT NULL,
  `desconto` decimal(10,2) DEFAULT NULL,
  PRIMARY KEY (`IdItemVendaEstoque`),
  KEY `FK_ItemVendaEstoque_Produto` (`IdProduto`),
  KEY `FK_ItemVendaEstoque_VendaProduto` (`IdVendaProduto`),
  CONSTRAINT `FK_ItemVendaEstoque_Produto` FOREIGN KEY (`IdProduto`) REFERENCES `produto` (`IdProduto`) ON DELETE NO ACTION ON UPDATE NO ACTION,
  CONSTRAINT `FK_ItemVendaEstoque_VendaProduto` FOREIGN KEY (`IdVendaProduto`) REFERENCES `vendaproduto` (`IdVendaProduto`) ON DELETE NO ACTION ON UPDATE NO ACTION
) ENGINE=InnoDB DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `itemvendaestoque`
--

LOCK TABLES `itemvendaestoque` WRITE;
/*!40000 ALTER TABLE `itemvendaestoque` DISABLE KEYS */;
/*!40000 ALTER TABLE `itemvendaestoque` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `marcaproduto`
--

DROP TABLE IF EXISTS `marcaproduto`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `marcaproduto` (
  `IdMarcaProduto` int(11) NOT NULL AUTO_INCREMENT,
  `Descricao` varchar(50) DEFAULT NULL,
  `Status` varchar(20) DEFAULT NULL,
  PRIMARY KEY (`IdMarcaProduto`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `marcaproduto`
--

LOCK TABLES `marcaproduto` WRITE;
/*!40000 ALTER TABLE `marcaproduto` DISABLE KEYS */;
/*!40000 ALTER TABLE `marcaproduto` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `notafiscal`
--

DROP TABLE IF EXISTS `notafiscal`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `notafiscal` (
  `IdNotaFiscal` int(11) NOT NULL AUTO_INCREMENT,
  `NumeroNF` int(11) DEFAULT NULL,
  `Serie` int(11) DEFAULT NULL,
  `CodRegimeTrib` int(11) DEFAULT NULL,
  `Data` datetime(6) DEFAULT NULL,
  `ChaveAcesso` varchar(30) DEFAULT NULL,
  `PalavrasChave` varchar(20) DEFAULT NULL,
  `Observacoes` varchar(100) DEFAULT NULL,
  PRIMARY KEY (`IdNotaFiscal`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `notafiscal`
--

LOCK TABLES `notafiscal` WRITE;
/*!40000 ALTER TABLE `notafiscal` DISABLE KEYS */;
/*!40000 ALTER TABLE `notafiscal` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `ordemservico`
--

DROP TABLE IF EXISTS `ordemservico`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `ordemservico` (
  `IdOrdemServico` int(11) NOT NULL AUTO_INCREMENT,
  `IdPessoa` int(11) DEFAULT NULL,
  `IdStatusOrdemServico` int(11) DEFAULT NULL,
  `Prioridade` tinyint(1) DEFAULT NULL,
  `Titulo` varchar(100) DEFAULT NULL,
  `Descricao` varchar(250) DEFAULT NULL,
  PRIMARY KEY (`IdOrdemServico`),
  KEY `FK_OrdemServico_Pessoa` (`IdPessoa`),
  KEY `FK_OrdemServico_StatusOrdemServico` (`IdStatusOrdemServico`),
  CONSTRAINT `FK_OrdemServico_Pessoa` FOREIGN KEY (`IdPessoa`) REFERENCES `pessoa` (`IdPessoa`) ON DELETE NO ACTION ON UPDATE NO ACTION,
  CONSTRAINT `FK_OrdemServico_StatusOrdemServico` FOREIGN KEY (`IdStatusOrdemServico`) REFERENCES `statusordemservico` (`IdStatusOrdemServico`) ON DELETE NO ACTION ON UPDATE NO ACTION
) ENGINE=InnoDB DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `ordemservico`
--

LOCK TABLES `ordemservico` WRITE;
/*!40000 ALTER TABLE `ordemservico` DISABLE KEYS */;
/*!40000 ALTER TABLE `ordemservico` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `pagamentoordemservico`
--

DROP TABLE IF EXISTS `pagamentoordemservico`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `pagamentoordemservico` (
  `IdPagamentoOrdemServico` int(11) NOT NULL AUTO_INCREMENT,
  `NumeroParcela` int(11) DEFAULT NULL,
  `Status` varchar(20) DEFAULT NULL,
  `NumeroDocumento` varchar(50) DEFAULT NULL,
  `Valor` decimal(10,2) DEFAULT NULL,
  `DataVencimento` datetime(6) DEFAULT NULL,
  `ValorPago` decimal(10,2) DEFAULT NULL,
  `DataPagamento` datetime(6) DEFAULT NULL,
  `IdOrdemServico` int(11) DEFAULT NULL,
  PRIMARY KEY (`IdPagamentoOrdemServico`),
  KEY `FK_PagamentoOrdemServico_OrdemServico` (`IdOrdemServico`),
  CONSTRAINT `FK_PagamentoOrdemServico_OrdemServico` FOREIGN KEY (`IdOrdemServico`) REFERENCES `ordemservico` (`IdOrdemServico`) ON DELETE NO ACTION ON UPDATE NO ACTION
) ENGINE=InnoDB DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `pagamentoordemservico`
--

LOCK TABLES `pagamentoordemservico` WRITE;
/*!40000 ALTER TABLE `pagamentoordemservico` DISABLE KEYS */;
/*!40000 ALTER TABLE `pagamentoordemservico` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `pagamentopedidocompra`
--

DROP TABLE IF EXISTS `pagamentopedidocompra`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `pagamentopedidocompra` (
  `IdPagamentoPedidoCompra` int(11) NOT NULL AUTO_INCREMENT,
  `IdPedidoCompra` int(11) DEFAULT NULL,
  `Parcela` int(11) DEFAULT NULL,
  `IdFormaPagamento` int(11) DEFAULT NULL,
  `NumeroDocumento` varchar(20) DEFAULT NULL,
  `Valor` decimal(10,2) DEFAULT NULL,
  `DataVencimento` datetime(6) DEFAULT NULL,
  `ValorPago` decimal(10,2) DEFAULT NULL,
  `DataPagamento` datetime(6) DEFAULT NULL,
  `Status` varchar(20) DEFAULT NULL,
  PRIMARY KEY (`IdPagamentoPedidoCompra`),
  KEY `FK_PagamentoPedidoCompra_PedidoCompra` (`IdPedidoCompra`),
  CONSTRAINT `FK_PagamentoPedidoCompra_PedidoCompra` FOREIGN KEY (`IdPedidoCompra`) REFERENCES `pedidocompra` (`IdPedidoCompra`) ON DELETE NO ACTION ON UPDATE NO ACTION
) ENGINE=InnoDB DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `pagamentopedidocompra`
--

LOCK TABLES `pagamentopedidocompra` WRITE;
/*!40000 ALTER TABLE `pagamentopedidocompra` DISABLE KEYS */;
/*!40000 ALTER TABLE `pagamentopedidocompra` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `pagamentoretornocotacao`
--

DROP TABLE IF EXISTS `pagamentoretornocotacao`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `pagamentoretornocotacao` (
  `IdPagamentoRetorno` int(11) NOT NULL AUTO_INCREMENT,
  `IdCotacao` int(11) DEFAULT NULL,
  `IdFormaPagamento` int(11) DEFAULT NULL,
  `Parcela` int(11) DEFAULT NULL,
  `DataVencimento` datetime(6) DEFAULT NULL,
  `ValorPago` decimal(10,2) DEFAULT NULL,
  PRIMARY KEY (`IdPagamentoRetorno`),
  KEY `FK_PagamentoRetornoCotacao_FormaPagamento` (`IdFormaPagamento`),
  CONSTRAINT `FK_PagamentoRetornoCotacao_FormaPagamento` FOREIGN KEY (`IdFormaPagamento`) REFERENCES `formapagamento` (`IdFormaPagamento`) ON DELETE NO ACTION ON UPDATE NO ACTION
) ENGINE=InnoDB DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `pagamentoretornocotacao`
--

LOCK TABLES `pagamentoretornocotacao` WRITE;
/*!40000 ALTER TABLE `pagamentoretornocotacao` DISABLE KEYS */;
/*!40000 ALTER TABLE `pagamentoretornocotacao` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `pedidocompra`
--

DROP TABLE IF EXISTS `pedidocompra`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `pedidocompra` (
  `IdPedidoCompra` int(11) NOT NULL AUTO_INCREMENT,
  `Data` datetime(6) DEFAULT NULL,
  `Automatico` varchar(20) DEFAULT NULL,
  `Status` varchar(20) DEFAULT NULL,
  PRIMARY KEY (`IdPedidoCompra`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `pedidocompra`
--

LOCK TABLES `pedidocompra` WRITE;
/*!40000 ALTER TABLE `pedidocompra` DISABLE KEYS */;
/*!40000 ALTER TABLE `pedidocompra` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `pessoa`
--

DROP TABLE IF EXISTS `pessoa`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `pessoa` (
  `IdPessoa` int(11) NOT NULL AUTO_INCREMENT,
  `Nome` varchar(100) DEFAULT NULL,
  `Status` varchar(20) DEFAULT NULL,
  `TipoCadastro` tinyint(1) DEFAULT NULL,
  PRIMARY KEY (`IdPessoa`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `pessoa`
--

LOCK TABLES `pessoa` WRITE;
/*!40000 ALTER TABLE `pessoa` DISABLE KEYS */;
/*!40000 ALTER TABLE `pessoa` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `pessoafisica`
--

DROP TABLE IF EXISTS `pessoafisica`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `pessoafisica` (
  `IdPessoaFisica` int(11) NOT NULL AUTO_INCREMENT,
  `CPF` varchar(11) DEFAULT NULL,
  `RG` varchar(9) DEFAULT NULL,
  `DataNascimento` datetime(6) DEFAULT NULL,
  `Sexo` char(1) DEFAULT NULL,
  `IdPessoa` int(11) DEFAULT NULL,
  PRIMARY KEY (`IdPessoaFisica`),
  KEY `FK_PessoaFisica_Pessoa` (`IdPessoa`),
  CONSTRAINT `FK_PessoaFisica_Pessoa` FOREIGN KEY (`IdPessoa`) REFERENCES `pessoa` (`IdPessoa`) ON DELETE NO ACTION ON UPDATE NO ACTION
) ENGINE=InnoDB DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `pessoafisica`
--

LOCK TABLES `pessoafisica` WRITE;
/*!40000 ALTER TABLE `pessoafisica` DISABLE KEYS */;
/*!40000 ALTER TABLE `pessoafisica` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `pessoajuridica`
--

DROP TABLE IF EXISTS `pessoajuridica`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `pessoajuridica` (
  `IdPessoaJuridica` int(11) NOT NULL AUTO_INCREMENT,
  `CNPJ` varchar(14) DEFAULT NULL,
  `IE` varchar(20) DEFAULT NULL,
  `IdPessoa` int(11) DEFAULT NULL,
  PRIMARY KEY (`IdPessoaJuridica`),
  KEY `FK_PessoaJuridica_Pessoa` (`IdPessoa`),
  CONSTRAINT `FK_PessoaJuridica_Pessoa` FOREIGN KEY (`IdPessoa`) REFERENCES `pessoa` (`IdPessoa`) ON DELETE NO ACTION ON UPDATE NO ACTION
) ENGINE=InnoDB DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `pessoajuridica`
--

LOCK TABLES `pessoajuridica` WRITE;
/*!40000 ALTER TABLE `pessoajuridica` DISABLE KEYS */;
/*!40000 ALTER TABLE `pessoajuridica` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `produto`
--

DROP TABLE IF EXISTS `produto`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `produto` (
  `IdProduto` int(11) NOT NULL AUTO_INCREMENT,
  `IdUnidadeMedida` int(11) DEFAULT NULL,
  `IdMarcaProduto` int(11) DEFAULT NULL,
  `IdTipoProduto` int(11) DEFAULT NULL,
  `Nome` varchar(100) DEFAULT NULL,
  `QtdMinimaEstoque` int(11) DEFAULT NULL,
  `CodigoBarras` varchar(50) DEFAULT NULL,
  `Observacoes` varchar(100) DEFAULT NULL,
  `Status` varchar(20) DEFAULT NULL,
  `DataValidade` datetime(6) DEFAULT NULL,
  PRIMARY KEY (`IdProduto`),
  KEY `FK_Produto_MarcaProduto` (`IdMarcaProduto`),
  KEY `FK_Produto_TipoProduto` (`IdTipoProduto`),
  KEY `FK_Produto_UnidadeMedida` (`IdUnidadeMedida`),
  CONSTRAINT `FK_Produto_MarcaProduto` FOREIGN KEY (`IdMarcaProduto`) REFERENCES `marcaproduto` (`IdMarcaProduto`) ON DELETE NO ACTION ON UPDATE NO ACTION,
  CONSTRAINT `FK_Produto_TipoProduto` FOREIGN KEY (`IdTipoProduto`) REFERENCES `tipoproduto` (`IdTipoProduto`) ON DELETE NO ACTION ON UPDATE NO ACTION,
  CONSTRAINT `FK_Produto_UnidadeMedida` FOREIGN KEY (`IdUnidadeMedida`) REFERENCES `unidademedida` (`IdUnidadeMedida`) ON DELETE NO ACTION ON UPDATE NO ACTION
) ENGINE=InnoDB DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `produto`
--

LOCK TABLES `produto` WRITE;
/*!40000 ALTER TABLE `produto` DISABLE KEYS */;
/*!40000 ALTER TABLE `produto` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `produtocotacao`
--

DROP TABLE IF EXISTS `produtocotacao`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `produtocotacao` (
  `IdProdutoCotacao` int(11) NOT NULL AUTO_INCREMENT,
  `IdProduto` int(11) DEFAULT NULL,
  `IdCotacao` int(11) DEFAULT NULL,
  `IdDepartamento` int(11) DEFAULT NULL,
  `IdFinalidade` int(11) DEFAULT NULL,
  `QuantidadeCotada` decimal(10,2) DEFAULT NULL,
  PRIMARY KEY (`IdProdutoCotacao`),
  KEY `FK_ProdutoCotacao_Cotacao` (`IdCotacao`),
  KEY `FK_ProdutoCotacao_Departamento` (`IdDepartamento`),
  KEY `FK_ProdutoCotacao_Finalidade` (`IdFinalidade`),
  CONSTRAINT `FK_ProdutoCotacao_Cotacao` FOREIGN KEY (`IdCotacao`) REFERENCES `cotacao` (`IdCotacao`) ON DELETE NO ACTION ON UPDATE NO ACTION,
  CONSTRAINT `FK_ProdutoCotacao_Departamento` FOREIGN KEY (`IdDepartamento`) REFERENCES `departamento` (`IdDepartamento`) ON DELETE NO ACTION ON UPDATE NO ACTION,
  CONSTRAINT `FK_ProdutoCotacao_Finalidade` FOREIGN KEY (`IdFinalidade`) REFERENCES `finalidade` (`IdFinalidade`) ON DELETE NO ACTION ON UPDATE NO ACTION
) ENGINE=InnoDB DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `produtocotacao`
--

LOCK TABLES `produtocotacao` WRITE;
/*!40000 ALTER TABLE `produtocotacao` DISABLE KEYS */;
/*!40000 ALTER TABLE `produtocotacao` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `profissao`
--

DROP TABLE IF EXISTS `profissao`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `profissao` (
  `IdProfissoes` int(11) NOT NULL AUTO_INCREMENT,
  `Nome` varchar(100) DEFAULT NULL,
  `Status` tinyint(1) DEFAULT NULL,
  PRIMARY KEY (`IdProfissoes`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `profissao`
--

LOCK TABLES `profissao` WRITE;
/*!40000 ALTER TABLE `profissao` DISABLE KEYS */;
/*!40000 ALTER TABLE `profissao` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `profissaofuncionario`
--

DROP TABLE IF EXISTS `profissaofuncionario`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `profissaofuncionario` (
  `IdProfissaoFuncionario` int(11) NOT NULL AUTO_INCREMENT,
  `IdProfissao` int(11) DEFAULT NULL,
  `IdFuncionario` int(11) DEFAULT NULL,
  `DataInicio` datetime(6) DEFAULT NULL,
  `DataFim` datetime(6) DEFAULT NULL,
  PRIMARY KEY (`IdProfissaoFuncionario`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `profissaofuncionario`
--

LOCK TABLES `profissaofuncionario` WRITE;
/*!40000 ALTER TABLE `profissaofuncionario` DISABLE KEYS */;
/*!40000 ALTER TABLE `profissaofuncionario` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `reserva`
--

DROP TABLE IF EXISTS `reserva`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `reserva` (
  `IdReserva` int(11) NOT NULL AUTO_INCREMENT,
  `Data` datetime(6) DEFAULT NULL,
  `Status` varchar(20) DEFAULT NULL,
  `IdUsuario` int(11) DEFAULT NULL,
  `IdUnidade` int(11) DEFAULT NULL,
  PRIMARY KEY (`IdReserva`),
  KEY `FK_Reserva_Unidade` (`IdUnidade`),
  KEY `FK_Reserva_Usuario` (`IdUsuario`),
  CONSTRAINT `FK_Reserva_Unidade` FOREIGN KEY (`IdUnidade`) REFERENCES `unidade` (`IdUnidade`) ON DELETE NO ACTION ON UPDATE NO ACTION,
  CONSTRAINT `FK_Reserva_Usuario` FOREIGN KEY (`IdUsuario`) REFERENCES `usuario` (`IdUsuario`) ON DELETE NO ACTION ON UPDATE NO ACTION
) ENGINE=InnoDB DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `reserva`
--

LOCK TABLES `reserva` WRITE;
/*!40000 ALTER TABLE `reserva` DISABLE KEYS */;
/*!40000 ALTER TABLE `reserva` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `solicitacaocompra`
--

DROP TABLE IF EXISTS `solicitacaocompra`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `solicitacaocompra` (
  `IdSolicitacaoCompra` int(11) NOT NULL AUTO_INCREMENT,
  `IdAprovador` int(11) DEFAULT NULL,
  `Data` datetime(6) DEFAULT NULL,
  PRIMARY KEY (`IdSolicitacaoCompra`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `solicitacaocompra`
--

LOCK TABLES `solicitacaocompra` WRITE;
/*!40000 ALTER TABLE `solicitacaocompra` DISABLE KEYS */;
/*!40000 ALTER TABLE `solicitacaocompra` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `solicitacaopedidocompra`
--

DROP TABLE IF EXISTS `solicitacaopedidocompra`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `solicitacaopedidocompra` (
  `IdSolicitacaoPedidoCompra` int(11) NOT NULL AUTO_INCREMENT,
  `IdSolicitacaoCompra` int(11) DEFAULT NULL,
  `IdPedidoCompra` int(11) DEFAULT NULL,
  PRIMARY KEY (`IdSolicitacaoPedidoCompra`),
  KEY `FK_SolicitacaoPedidoCompra_PedidoCompra` (`IdPedidoCompra`),
  KEY `FK_SolicitacaoPedidoCompra_SolicitacaoCompra` (`IdSolicitacaoCompra`),
  CONSTRAINT `FK_SolicitacaoPedidoCompra_PedidoCompra` FOREIGN KEY (`IdPedidoCompra`) REFERENCES `pedidocompra` (`IdPedidoCompra`) ON DELETE NO ACTION ON UPDATE NO ACTION,
  CONSTRAINT `FK_SolicitacaoPedidoCompra_SolicitacaoCompra` FOREIGN KEY (`IdSolicitacaoCompra`) REFERENCES `solicitacaocompra` (`IdSolicitacaoCompra`) ON DELETE NO ACTION ON UPDATE NO ACTION
) ENGINE=InnoDB DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `solicitacaopedidocompra`
--

LOCK TABLES `solicitacaopedidocompra` WRITE;
/*!40000 ALTER TABLE `solicitacaopedidocompra` DISABLE KEYS */;
/*!40000 ALTER TABLE `solicitacaopedidocompra` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `statuscotacao`
--

DROP TABLE IF EXISTS `statuscotacao`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `statuscotacao` (
  `IdStatusCotacao` int(11) NOT NULL AUTO_INCREMENT,
  `Descricao` varchar(50) DEFAULT NULL,
  PRIMARY KEY (`IdStatusCotacao`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `statuscotacao`
--

LOCK TABLES `statuscotacao` WRITE;
/*!40000 ALTER TABLE `statuscotacao` DISABLE KEYS */;
/*!40000 ALTER TABLE `statuscotacao` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `statusordemservico`
--

DROP TABLE IF EXISTS `statusordemservico`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `statusordemservico` (
  `IdStatusOrdemServico` int(11) NOT NULL AUTO_INCREMENT,
  `Descricao` varchar(100) DEFAULT NULL,
  `Status` varchar(20) DEFAULT NULL,
  PRIMARY KEY (`IdStatusOrdemServico`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `statusordemservico`
--

LOCK TABLES `statusordemservico` WRITE;
/*!40000 ALTER TABLE `statusordemservico` DISABLE KEYS */;
/*!40000 ALTER TABLE `statusordemservico` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `tabelapreco`
--

DROP TABLE IF EXISTS `tabelapreco`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `tabelapreco` (
  `IdTabelaPreco` int(11) NOT NULL AUTO_INCREMENT,
  `IdProduto` int(11) DEFAULT NULL,
  `ValorUnitarioVenda` decimal(10,2) DEFAULT NULL,
  `DataVenda` datetime(6) DEFAULT NULL,
  PRIMARY KEY (`IdTabelaPreco`),
  KEY `FK_TabelaPreco_Produto` (`IdProduto`),
  CONSTRAINT `FK_TabelaPreco_Produto` FOREIGN KEY (`IdProduto`) REFERENCES `produto` (`IdProduto`) ON DELETE NO ACTION ON UPDATE NO ACTION
) ENGINE=InnoDB DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `tabelapreco`
--

LOCK TABLES `tabelapreco` WRITE;
/*!40000 ALTER TABLE `tabelapreco` DISABLE KEYS */;
/*!40000 ALTER TABLE `tabelapreco` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `telefone`
--

DROP TABLE IF EXISTS `telefone`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `telefone` (
  `IdTelefone` int(11) NOT NULL AUTO_INCREMENT,
  `Tipo` varchar(20) DEFAULT NULL,
  `DDD` varchar(2) DEFAULT NULL,
  `Telefone` varchar(10) DEFAULT NULL,
  `IdPessoa` int(11) DEFAULT NULL,
  PRIMARY KEY (`IdTelefone`),
  KEY `FK_Telefone_Pessoa` (`IdPessoa`),
  CONSTRAINT `FK_Telefone_Pessoa` FOREIGN KEY (`IdPessoa`) REFERENCES `pessoa` (`IdPessoa`) ON DELETE NO ACTION ON UPDATE NO ACTION
) ENGINE=InnoDB DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `telefone`
--

LOCK TABLES `telefone` WRITE;
/*!40000 ALTER TABLE `telefone` DISABLE KEYS */;
/*!40000 ALTER TABLE `telefone` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `tipoproduto`
--

DROP TABLE IF EXISTS `tipoproduto`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `tipoproduto` (
  `IdTipoProduto` int(11) NOT NULL AUTO_INCREMENT,
  `Descricao` varchar(50) DEFAULT NULL,
  `Status` varchar(20) DEFAULT NULL,
  PRIMARY KEY (`IdTipoProduto`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `tipoproduto`
--

LOCK TABLES `tipoproduto` WRITE;
/*!40000 ALTER TABLE `tipoproduto` DISABLE KEYS */;
/*!40000 ALTER TABLE `tipoproduto` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `transferenciaestoque`
--

DROP TABLE IF EXISTS `transferenciaestoque`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `transferenciaestoque` (
  `IdTE` int(11) NOT NULL AUTO_INCREMENT,
  `Status` varchar(20) DEFAULT NULL,
  `DataSeparacao` datetime(6) DEFAULT NULL,
  `DataAtual` datetime(6) DEFAULT NULL,
  `IdOperador` int(11) DEFAULT NULL,
  PRIMARY KEY (`IdTE`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `transferenciaestoque`
--

LOCK TABLES `transferenciaestoque` WRITE;
/*!40000 ALTER TABLE `transferenciaestoque` DISABLE KEYS */;
/*!40000 ALTER TABLE `transferenciaestoque` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `unidade`
--

DROP TABLE IF EXISTS `unidade`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `unidade` (
  `IdUnidade` int(11) NOT NULL AUTO_INCREMENT,
  `IdPessoaJuridica` int(11) DEFAULT NULL,
  `IdMatriz` int(11) DEFAULT NULL,
  PRIMARY KEY (`IdUnidade`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `unidade`
--

LOCK TABLES `unidade` WRITE;
/*!40000 ALTER TABLE `unidade` DISABLE KEYS */;
/*!40000 ALTER TABLE `unidade` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `unidademedida`
--

DROP TABLE IF EXISTS `unidademedida`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `unidademedida` (
  `IdUnidadeMedida` int(11) NOT NULL AUTO_INCREMENT,
  `Descricao` varchar(50) DEFAULT NULL,
  `Status` varchar(20) DEFAULT NULL,
  PRIMARY KEY (`IdUnidadeMedida`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `unidademedida`
--

LOCK TABLES `unidademedida` WRITE;
/*!40000 ALTER TABLE `unidademedida` DISABLE KEYS */;
/*!40000 ALTER TABLE `unidademedida` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `usuario`
--

DROP TABLE IF EXISTS `usuario`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `usuario` (
  `IdUsuario` int(11) NOT NULL AUTO_INCREMENT,
  `IdPessoa` int(11) DEFAULT NULL,
  `Login` varchar(20) DEFAULT NULL,
  `Senha` varchar(20) DEFAULT NULL,
  `Status` tinyint(1) DEFAULT NULL,
  PRIMARY KEY (`IdUsuario`),
  KEY `FK_Usuario_Pessoa` (`IdPessoa`),
  CONSTRAINT `FK_Usuario_Pessoa` FOREIGN KEY (`IdPessoa`) REFERENCES `pessoa` (`IdPessoa`) ON DELETE NO ACTION ON UPDATE NO ACTION
) ENGINE=InnoDB AUTO_INCREMENT=2 DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `usuario`
--

LOCK TABLES `usuario` WRITE;
/*!40000 ALTER TABLE `usuario` DISABLE KEYS */;
INSERT INTO `usuario` VALUES (1,NULL,'teste','12345',1);
/*!40000 ALTER TABLE `usuario` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `vendaproduto`
--

DROP TABLE IF EXISTS `vendaproduto`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `vendaproduto` (
  `IdVendaProduto` int(11) NOT NULL AUTO_INCREMENT,
  `DataVenda` datetime(6) DEFAULT NULL,
  `IdVendedor` int(11) DEFAULT NULL,
  `IdCliente` int(11) DEFAULT NULL,
  `IdEndereco` int(11) DEFAULT NULL,
  `IdUnidade` int(11) DEFAULT NULL,
  `CodigoVenda` int(11) DEFAULT NULL,
  PRIMARY KEY (`IdVendaProduto`),
  KEY `FK_VendaProduto_Endereco` (`IdEndereco`),
  KEY `FK_VendaProduto_Unidade` (`IdUnidade`),
  CONSTRAINT `FK_VendaProduto_Endereco` FOREIGN KEY (`IdEndereco`) REFERENCES `endereco` (`IdEndereco`) ON DELETE NO ACTION ON UPDATE NO ACTION,
  CONSTRAINT `FK_VendaProduto_Unidade` FOREIGN KEY (`IdUnidade`) REFERENCES `unidade` (`IdUnidade`) ON DELETE NO ACTION ON UPDATE NO ACTION
) ENGINE=InnoDB DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `vendaproduto`
--

LOCK TABLES `vendaproduto` WRITE;
/*!40000 ALTER TABLE `vendaproduto` DISABLE KEYS */;
/*!40000 ALTER TABLE `vendaproduto` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `vendaprodutonf`
--

DROP TABLE IF EXISTS `vendaprodutonf`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `vendaprodutonf` (
  `IdVendaProdutoNF` int(11) NOT NULL AUTO_INCREMENT,
  `IdVendaProduto` int(11) DEFAULT NULL,
  `IdNotaFiscal` int(11) DEFAULT NULL,
  PRIMARY KEY (`IdVendaProdutoNF`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `vendaprodutonf`
--

LOCK TABLES `vendaprodutonf` WRITE;
/*!40000 ALTER TABLE `vendaprodutonf` DISABLE KEYS */;
/*!40000 ALTER TABLE `vendaprodutonf` ENABLE KEYS */;
UNLOCK TABLES;
/*!40103 SET TIME_ZONE=@OLD_TIME_ZONE */;

/*!40101 SET SQL_MODE=@OLD_SQL_MODE */;
/*!40014 SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS */;
/*!40014 SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
/*!40111 SET SQL_NOTES=@OLD_SQL_NOTES */;

-- Dump completed on 2017-04-15 18:50:28
