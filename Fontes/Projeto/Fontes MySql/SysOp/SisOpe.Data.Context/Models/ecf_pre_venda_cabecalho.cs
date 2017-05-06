using System;
using System.Collections.Generic;

namespace SisOpe.Data.Context.Models
{
    public partial class ecf_pre_venda_cabecalho
    {
        public ecf_pre_venda_cabecalho()
        {
            this.ecf_pre_venda_detalhe = new List<ecf_pre_venda_detalhe>();
            this.ecf_venda_cabecalho = new List<ecf_venda_cabecalho>();
        }

        public long ID { get; set; }
        public Nullable<System.DateTime> DATA_HORA_PV { get; set; }
        public string SITUACAO { get; set; }
        public Nullable<long> CCF { get; set; }
        public Nullable<decimal> VALOR { get; set; }
        public virtual ICollection<ecf_pre_venda_detalhe> ecf_pre_venda_detalhe { get; set; }
        public virtual ICollection<ecf_venda_cabecalho> ecf_venda_cabecalho { get; set; }
    }
}
