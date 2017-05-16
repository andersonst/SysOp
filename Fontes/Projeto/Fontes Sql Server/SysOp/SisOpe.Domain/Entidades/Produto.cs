using System;
using System.Collections.Generic;

namespace SisOpe.Domain.Entidades
{
    public partial class Produto
    {
        public Produto()
        {
            this.ecf_dav_detalhe = new List<Ecf_Dav_Detalhe>();
            this.ecf_pre_venda_detalhe = new List<Ecf_Pre_Venda_Detalhe>();
            this.ecf_venda_detalhe = new List<Ecf_Venda_Detalhe>();
            this.ficha_tecnica = new List<Ficha_Tecnica>();
            this.itemestoques = new List<ItemEstoque>();
            this.itemprodutonotafiscals = new List<ItemProdutoNotaFiscal>();
            this.itemsolicitacaocompras = new List<ItemSolicitacaoCompra>();
            this.itemvendaestoques = new List<ItemVendaEstoque>();
            this.nf2_detalhe = new List<Nf2_Detalhe>();
            this.produto_promocao = new List<Produto_Promocao>();
        }

        public long ID { get; set; }
        public long ID_ECF_TRIBUTOS { get; set; }
        public long ID_UNIDADE_PRODUTO { get; set; }
        public string GTIN { get; set; }
        public string CODIGO_INTERNO { get; set; }
        public string NOME { get; set; }
        public string DESCRICAO { get; set; }
        public string DESCRICAO_PDV { get; set; }
        public Nullable<decimal> VALOR_VENDA { get; set; }
        public Nullable<decimal> QTD_ESTOQUE { get; set; }
        public Nullable<decimal> ESTOQUE_MIN { get; set; }
        public Nullable<decimal> ESTOQUE_MAX { get; set; }
        public string IAT { get; set; }
        public string IPPT { get; set; }
        public string NCM { get; set; }
        public virtual ICollection<Ecf_Dav_Detalhe> ecf_dav_detalhe { get; set; }
        public virtual ICollection<Ecf_Pre_Venda_Detalhe> ecf_pre_venda_detalhe { get; set; }
        public virtual Ecf_Tributo_Produto ecf_tributo_produto { get; set; }
        public virtual ICollection<Ecf_Venda_Detalhe> ecf_venda_detalhe { get; set; }
        public virtual ICollection<Ficha_Tecnica> ficha_tecnica { get; set; }
        public virtual ICollection<ItemEstoque> itemestoques { get; set; }
        public virtual ICollection<ItemProdutoNotaFiscal> itemprodutonotafiscals { get; set; }
        public virtual ICollection<ItemSolicitacaoCompra> itemsolicitacaocompras { get; set; }
        public virtual ICollection<ItemVendaEstoque> itemvendaestoques { get; set; }
        public virtual ICollection<Nf2_Detalhe> nf2_detalhe { get; set; }
        public virtual Unidade_Produto unidade_produto { get; set; }
        public virtual ICollection<Produto_Promocao> produto_promocao { get; set; }
    }
}
