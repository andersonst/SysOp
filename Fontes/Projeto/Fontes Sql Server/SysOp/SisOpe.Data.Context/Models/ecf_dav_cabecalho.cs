using System;
using System.Collections.Generic;

namespace SisOpe.Data.Context.Models
{
    public partial class Ecf_Dav_Cabecalho
    {
        public Ecf_Dav_Cabecalho()
        {
            this.ecf_dav_detalhe = new List<Ecf_Dav_Detalhe>();
            this.ecf_venda_cabecalho = new List<Ecf_Venda_Cabecalho>();
        }

        public long ID { get; set; }
        public Nullable<long> CCF { get; set; }
        public Nullable<long> COO { get; set; }
        public string NOME_DESTINATARIO { get; set; }
        public string CPF_CNPJ_DESTINATARIO { get; set; }
        public Nullable<System.DateTime> DATA_HORA_EMISSAO { get; set; }
        public string SITUACAO { get; set; }
        public Nullable<decimal> VALOR { get; set; }
        public virtual ICollection<Ecf_Dav_Detalhe> ecf_dav_detalhe { get; set; }
        public virtual ICollection<Ecf_Venda_Cabecalho> ecf_venda_cabecalho { get; set; }
    }
}
