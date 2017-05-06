using System;
using System.Collections.Generic;

namespace SisOpe.Data.Context.Models
{
    public partial class ecf_dav_cabecalho
    {
        public ecf_dav_cabecalho()
        {
            this.ecf_dav_detalhe = new List<ecf_dav_detalhe>();
            this.ecf_venda_cabecalho = new List<ecf_venda_cabecalho>();
        }

        public long ID { get; set; }
        public Nullable<long> CCF { get; set; }
        public Nullable<long> COO { get; set; }
        public string NOME_DESTINATARIO { get; set; }
        public string CPF_CNPJ_DESTINATARIO { get; set; }
        public Nullable<System.DateTime> DATA_HORA_EMISSAO { get; set; }
        public string SITUACAO { get; set; }
        public Nullable<decimal> VALOR { get; set; }
        public virtual ICollection<ecf_dav_detalhe> ecf_dav_detalhe { get; set; }
        public virtual ICollection<ecf_venda_cabecalho> ecf_venda_cabecalho { get; set; }
    }
}
