using System;
using System.Collections.Generic;

namespace SisOpe.Data.Context.Models
{
    public partial class cfop
    {
        public cfop()
        {
            this.ecf_venda_cabecalho = new List<ecf_venda_cabecalho>();
            this.ecf_venda_detalhe = new List<ecf_venda_detalhe>();
            this.nf2_cabecalho = new List<nf2_cabecalho>();
            this.nf2_detalhe = new List<nf2_detalhe>();
        }

        public long ID { get; set; }
        public Nullable<long> CFOP1 { get; set; }
        public string DESCRICAO { get; set; }
        public string APLICACAO { get; set; }
        public virtual ICollection<ecf_venda_cabecalho> ecf_venda_cabecalho { get; set; }
        public virtual ICollection<ecf_venda_detalhe> ecf_venda_detalhe { get; set; }
        public virtual ICollection<nf2_cabecalho> nf2_cabecalho { get; set; }
        public virtual ICollection<nf2_detalhe> nf2_detalhe { get; set; }
    }
}
