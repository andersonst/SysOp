using System;
using System.Collections.Generic;

namespace SisOpe.Data.Context.Models
{
    public partial class ecf_tributo_produto
    {
        public ecf_tributo_produto()
        {
            this.ecf_venda_detalhe = new List<ecf_venda_detalhe>();
            this.nf2_detalhe = new List<nf2_detalhe>();
            this.produtoes = new List<produto>();
        }

        public long ID { get; set; }
        public string DESCRICAO { get; set; }
        public Nullable<decimal> TAXA_IPI { get; set; }
        public Nullable<decimal> TAXA_ISSQN { get; set; }
        public Nullable<decimal> TAXA_PIS { get; set; }
        public Nullable<decimal> TAXA_COFINS { get; set; }
        public Nullable<decimal> TAXA_ICMS { get; set; }
        public string ECF_ICMS { get; set; }
        public string CST { get; set; }
        public string TOTALIZADOR_PARCIAL { get; set; }
        public virtual ICollection<ecf_venda_detalhe> ecf_venda_detalhe { get; set; }
        public virtual ICollection<nf2_detalhe> nf2_detalhe { get; set; }
        public virtual ICollection<produto> produtoes { get; set; }
    }
}
