using System;
using System.Collections.Generic;

namespace SisOpe.Domain.Entidades
{
    public partial class Ecf_Tributo_Produto
    {
        public Ecf_Tributo_Produto()
        {
            this.ecf_venda_detalhe = new List<Ecf_Venda_Detalhe>();
            this.nf2_detalhe = new List<Nf2_Detalhe>();
            this.produtoes = new List<Produto>();
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
        public virtual ICollection<Ecf_Venda_Detalhe> ecf_venda_detalhe { get; set; }
        public virtual ICollection<Nf2_Detalhe> nf2_detalhe { get; set; }
        public virtual ICollection<Produto> produtoes { get; set; }
    }
}
