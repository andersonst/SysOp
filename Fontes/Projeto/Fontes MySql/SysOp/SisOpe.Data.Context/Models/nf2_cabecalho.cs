using System;
using System.Collections.Generic;

namespace SisOpe.Data.Context.Models
{
    public partial class nf2_cabecalho
    {
        //public nf2_cabecalho()
        //{
        //    this.nf2_detalhe = new List<nf2_detalhe>();
        //}

        public long ID { get; set; }
        public long ID_CFOP { get; set; }
        public long ID_ECF_FUNCIONARIO { get; set; }
        public long ID_CLIENTE { get; set; }
        public string NUMERO { get; set; }
        public Nullable<System.DateTime> DATA_HORA_EMISSAO { get; set; }
        public string SERIE { get; set; }
        public string SUBSERIE { get; set; }
        public Nullable<decimal> TOTAL_PRODUTOS { get; set; }
        public Nullable<decimal> TOTAL_NF { get; set; }
        public Nullable<decimal> BASE_ICMS { get; set; }
        public Nullable<decimal> ICMS { get; set; }
        public Nullable<decimal> ICMS_OUTRAS { get; set; }
        public Nullable<decimal> ISSQN { get; set; }
        public Nullable<decimal> PIS { get; set; }
        public Nullable<decimal> COFINS { get; set; }
        public Nullable<decimal> IPI { get; set; }
        public Nullable<decimal> TAXA_ACRESCIMO { get; set; }
        public Nullable<decimal> ACRESCIMO { get; set; }
        public Nullable<decimal> ACRESCIMO_ITENS { get; set; }
        public Nullable<decimal> TAXA_DESCONTO { get; set; }
        public Nullable<decimal> DESCONTO { get; set; }
        public Nullable<decimal> DESCONTO_ITENS { get; set; }
        public string CANCELADA { get; set; }
        public string SINCRONIZADO { get; set; }
        public virtual cfop cfop { get; set; }
        public virtual pessoa pessoa { get; set; }
        public virtual pessoa pessoa1 { get; set; }
        public virtual ICollection<nf2_detalhe> nf2_detalhe { get; set; }
    }
}
