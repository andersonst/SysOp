using System;
using System.Collections.Generic;

namespace SisOpe.Data.Context.Models
{
    public partial class ecf_venda_cabecalho
    {
        public ecf_venda_cabecalho()
        {
            this.ecf_total_tipo_pgto = new List<ecf_total_tipo_pgto>();
            this.ecf_venda_detalhe = new List<ecf_venda_detalhe>();
        }

        public long ID { get; set; }
        public Nullable<long> ID_CFOP { get; set; }
        public Nullable<long> ID_ECF_DAV { get; set; }
        public Nullable<long> ID_ECF_PRE_VENDA_CABECALHO { get; set; }
        public Nullable<long> ID_CLIENTE { get; set; }
        public Nullable<long> ID_ECF_FUNCIONARIO { get; set; }
        public long ID_ECF_MOVIMENTO { get; set; }
        public Nullable<long> COO { get; set; }
        public Nullable<long> CCF { get; set; }
        public Nullable<System.DateTime> DATA_HORA_VENDA { get; set; }
        public Nullable<decimal> VALOR_VENDA { get; set; }
        public Nullable<decimal> TAXA_DESCONTO { get; set; }
        public Nullable<decimal> DESCONTO { get; set; }
        public Nullable<decimal> TAXA_ACRESCIMO { get; set; }
        public Nullable<decimal> ACRESCIMO { get; set; }
        public Nullable<decimal> VALOR_FINAL { get; set; }
        public Nullable<decimal> VALOR_RECEBIDO { get; set; }
        public Nullable<decimal> TROCO { get; set; }
        public Nullable<decimal> VALOR_CANCELADO { get; set; }
        public string SINCRONIZADO { get; set; }
        public Nullable<decimal> TOTAL_PRODUTOS { get; set; }
        public Nullable<decimal> TOTAL_DOCUMENTO { get; set; }
        public Nullable<decimal> BASE_ICMS { get; set; }
        public Nullable<decimal> ICMS { get; set; }
        public Nullable<decimal> ICMS_OUTRAS { get; set; }
        public Nullable<decimal> ISSQN { get; set; }
        public Nullable<decimal> PIS { get; set; }
        public Nullable<decimal> COFINS { get; set; }
        public Nullable<decimal> ACRESCIMO_ITENS { get; set; }
        public Nullable<decimal> DESCONTO_ITENS { get; set; }
        public string STATUS_VENDA { get; set; }
        public string NOME_CLIENTE { get; set; }
        public string CPF_CNPJ_CLIENTE { get; set; }
        public virtual cfop cfop { get; set; }
        public virtual ecf_dav_cabecalho ecf_dav_cabecalho { get; set; }
        public virtual ecf_movimento ecf_movimento { get; set; }
        public virtual ecf_pre_venda_cabecalho ecf_pre_venda_cabecalho { get; set; }
        public virtual ICollection<ecf_total_tipo_pgto> ecf_total_tipo_pgto { get; set; }
        public virtual pessoa pessoa { get; set; }
        public virtual pessoa pessoa1 { get; set; }
        public virtual ICollection<ecf_venda_detalhe> ecf_venda_detalhe { get; set; }
    }
}
