using System;
using System.Collections.Generic;

namespace SisOpe.Data.Context.Models
{
    public partial class Cfop
    {
        public Cfop()
        {
            this.ecf_venda_cabecalho = new List<Ecf_Venda_Cabecalho>();
            this.ecf_venda_detalhe = new List<Ecf_Venda_Detalhe>();
            this.nf2_cabecalho = new List<Nf2_Cabecalho>();
            this.nf2_detalhe = new List<Nf2_Detalhe>();
        }

        public long ID { get; set; }
        public Nullable<long> CFOP1 { get; set; }
        public string DESCRICAO { get; set; }
        public string APLICACAO { get; set; }
        public virtual ICollection<Ecf_Venda_Cabecalho> ecf_venda_cabecalho { get; set; }
        public virtual ICollection<Ecf_Venda_Detalhe> ecf_venda_detalhe { get; set; }
        public virtual ICollection<Nf2_Cabecalho> nf2_cabecalho { get; set; }
        public virtual ICollection<Nf2_Detalhe> nf2_detalhe { get; set; }
    }
}
