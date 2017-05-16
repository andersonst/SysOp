using System;
using System.Collections.Generic;

namespace SisOpe.Domain.Entidades
{
    public partial class Ecf_Pre_Venda_Cabecalho
    {
        public Ecf_Pre_Venda_Cabecalho()
        {
            this.ecf_pre_venda_detalhe = new List<Ecf_Pre_Venda_Detalhe>();
            this.ecf_venda_cabecalho = new List<Ecf_Venda_Cabecalho>();
        }

        public long ID { get; set; }
        public Nullable<System.DateTime> DATA_HORA_PV { get; set; }
        public string SITUACAO { get; set; }
        public Nullable<long> CCF { get; set; }
        public Nullable<decimal> VALOR { get; set; }
        public virtual ICollection<Ecf_Pre_Venda_Detalhe> ecf_pre_venda_detalhe { get; set; }
        public virtual ICollection<Ecf_Venda_Cabecalho> ecf_venda_cabecalho { get; set; }
    }
}
