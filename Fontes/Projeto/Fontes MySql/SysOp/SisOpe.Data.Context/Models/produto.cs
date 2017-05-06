using System;
using System.Collections.Generic;

namespace SisOpe.Data.Context.Models
{
    public partial class produto
    {
        public produto()
        {
            this.ecf_dav_detalhe = new List<ecf_dav_detalhe>();
            this.ecf_pre_venda_detalhe = new List<ecf_pre_venda_detalhe>();
            this.ecf_venda_detalhe = new List<ecf_venda_detalhe>();
            this.ficha_tecnica = new List<ficha_tecnica>();
            this.itemestoques = new List<itemestoque>();
            this.itemprodutonotafiscals = new List<itemprodutonotafiscal>();
            this.itemsolicitacaocompras = new List<itemsolicitacaocompra>();
            this.itemvendaestoques = new List<itemvendaestoque>();
            this.nf2_detalhe = new List<nf2_detalhe>();
            this.produto_promocao = new List<produto_promocao>();
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
        public virtual ICollection<ecf_dav_detalhe> ecf_dav_detalhe { get; set; }
        public virtual ICollection<ecf_pre_venda_detalhe> ecf_pre_venda_detalhe { get; set; }
        public virtual ecf_tributo_produto ecf_tributo_produto { get; set; }
        public virtual ICollection<ecf_venda_detalhe> ecf_venda_detalhe { get; set; }
        public virtual ICollection<ficha_tecnica> ficha_tecnica { get; set; }
        public virtual ICollection<itemestoque> itemestoques { get; set; }
        public virtual ICollection<itemprodutonotafiscal> itemprodutonotafiscals { get; set; }
        public virtual ICollection<itemsolicitacaocompra> itemsolicitacaocompras { get; set; }
        public virtual ICollection<itemvendaestoque> itemvendaestoques { get; set; }
        public virtual ICollection<nf2_detalhe> nf2_detalhe { get; set; }
        public virtual unidade_produto unidade_produto { get; set; }
        public virtual ICollection<produto_promocao> produto_promocao { get; set; }
    }
}
